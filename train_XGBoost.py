import xgboost as xgb
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score, f1_score
import pandas as pd
import joblib
import onnxmltools
from onnxmltools.convert.common.data_types import FloatTensorType

def train_xgboost(file_path):
    df = pd.read_csv(file_path)
    x = df.drop(columns=['is_won']) 
    y = df['is_won']

    x_train, x_test, y_train, y_test = train_test_split(x, y, test_size=0.2, random_state=42)

    model = xgb.XGBClassifier(
        n_estimators=100,      # tree number
        learning_rate=0.1,     
        max_depth=3,           # tree depth
        random_state=42
    )

    model.fit(x_train.values, y_train.values)
    y_pred = model.predict(x_test.values)

    accuracy = accuracy_score(y_test, y_pred)
    f1 = f1_score(y_test, y_pred, average='macro')
    print(f"Modelin Doğruluk Skoru (Accuracy): {accuracy * 100:.2f}%")
    print(f"Modelin F1 Skoru: {f1:.2f}")

    return model

def save_model(model):
    model.save_model('Models/XGBoost/model.json')

def transform_model2ONNX():
    xgb_model = xgb.XGBClassifier()
    xgb_model.load_model('Models/XGBoost/model.json')

    #Veriniz kaç sütundan oluşuyorsa (Örn: 4 sütun) buraya yazın
    initial_type = [('float_input', FloatTensorType([None, 5]))]

    onnx_xgb = onnxmltools.convert_xgboost(xgb_model, initial_types=initial_type)
    with open("Models/XGBoost/model.onnx", "wb") as f:
        f.write(onnx_xgb.SerializeToString())

#-------------------------------------------------------------------------

model = train_xgboost('Dataset/soulslike_500.csv')
save_model(model)
transform_model2ONNX()