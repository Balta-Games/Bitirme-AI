import joblib
import xgboost as xgb
import pandas as pd

def predict_kmeans(filepath):
    new_sample = pd.read_csv(filepath)

    kmeans_model = joblib.load('Models/Kmeans/model.joblib')
    kmeans_scaler = joblib.load('Models/Kmeans/scaler.joblib')

    new_sample_scaled = kmeans_scaler.transform(new_sample)
    prediction = kmeans_model.predict(new_sample_scaled)
    return prediction

def predict_xgboost(filepath):
    new_sample = pd.read_csv(filepath)

    xgb_model = xgb.XGBClassifier()
    xgb_model.load_model('Models/XGBoost/model.json')

    prediction = xgb_model.predict(new_sample)
    return prediction