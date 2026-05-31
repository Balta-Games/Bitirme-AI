import xgboost as xgb
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score, f1_score
import pandas as pd

df = pd.read_csv('Dataset/soulslike_500.csv')
x = df.drop(columns=['is_won']) 
y = df['is_won']

x_train, x_test, y_train, y_test = train_test_split(x, y, test_size=0.2, random_state=42)

model = xgb.XGBClassifier(
    n_estimators=100,      # tree number
    learning_rate=0.1,     
    max_depth=3,           # tree depth
    random_state=42
)

model.fit(x_train, y_train)
y_pred = model.predict(x_test)

model.save_model('Models/XGBoost/model.json')

accuracy = accuracy_score(y_test, y_pred)
f1 = f1_score(y_test, y_pred, average='macro')
print(f"Modelin Doğruluk Skoru (Accuracy): {accuracy * 100:.2f}%")
print(f"Modelin F1 Skoru: {f1:.2f}")