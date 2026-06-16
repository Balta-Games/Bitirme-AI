import xgboost as xgb
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score, f1_score, confusion_matrix
import pandas as pd
import m2cgen as m2c
import matplotlib.pyplot as plt
import seaborn as sns

def train_xgboost(file_path):
    df = pd.read_csv(file_path)
    x = df.drop(columns=['label']) 
    y = df['label']

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

    # ------------------ DRAWING GRAPHIC ------------------
    metrics = ['Accuracy', 'F1 Score']
    scores = [accuracy, f1]
    
    plt.bar(metrics, scores, color=['#4CAF50', '#2196F3'], width=0.4)
    plt.ylim(0, 1.0) 
    
    for i, v in enumerate(scores):
        plt.text(i, v + 0.02, f"{v:.2f}", ha='center', fontweight='bold')
        
    plt.title('Model Performance Metrics')
    plt.ylabel('Score')
    plt.savefig('Analytics/model_metrics.png') 
    plt.close()                       

    cm = confusion_matrix(y_test, y_pred)
    sns.heatmap(cm, annot=True, fmt='d', cmap='Blues', xticklabels=['0', '1'], yticklabels=['0', '1'])
    plt.title('Confusion Matrix')
    plt.xlabel('Prediction')
    plt.ylabel('Actual')
    plt.savefig('Analytics/confusion_matrix.png') 
    plt.close()
    # -----------------------------------------------------
    return model

def save_model(model):
    model.save_model('Models/XGBoost/model.json')

def transform_model2cs():
    xgb_model = xgb.XGBClassifier()
    xgb_model.load_model('Models/XGBoost/model.json')

    if hasattr(xgb_model, 'base_score') and isinstance(xgb_model.base_score, list):
        xgb_model.base_score = xgb_model.base_score[0]
    '''elif hasattr(xgb_model, '_Booster') and hasattr(xgb_model._Booster, 'meta_info') and 'base_score' in xgb_model._Booster.meta_info:
        # Bazı XGBoost versiyonlarında base_score booster meta_info içinde saklanabilir
        try:
            xgb_model.base_score = float(xgb_model._Booster.meta_info['base_score'])
        except (ValueError, TypeError):
            pass'''

    csharp_code = m2c.export_to_c_sharp(xgb_model)
    with open("Models/XGBoost/Predictor.cs", "w") as f:
        f.write(csharp_code)

#-------------------------------------------------------------------------

model = train_xgboost('Dataset/player_data_labeled.csv')
#save_model(model)
#transform_model2cs()
