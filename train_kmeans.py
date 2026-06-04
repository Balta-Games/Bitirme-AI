import pandas as pd
from sklearn.cluster import KMeans
from sklearn.preprocessing import StandardScaler
from sklearn.pipeline import Pipeline
import joblib
from skl2onnx import convert_sklearn
from skl2onnx.common.data_types import FloatTensorType


def train_kmeans(file_path):
    df = pd.read_csv(file_path)

    scaler = StandardScaler()
    df_scaled = scaler.fit_transform(df)

    kmeans = KMeans(n_clusters=2, random_state=42)
    kmeans.fit(df_scaled)
    return kmeans, scaler

def save_model(kmeans, scaler):
    joblib.dump(kmeans, 'Models/Kmeans/model.joblib')
    joblib.dump(scaler, 'Models/Kmeans/scaler.joblib')

def transform_model2cs():
    kmeans_model = joblib.load('Models/Kmeans/model.joblib')
    kmeans_scaler = joblib.load('Models/Kmeans/scaler.joblib')

    with open("Models/Kmeans/values.txt", "w") as f:
        f.write("--- SCALER MEAN ---" + "\n")
        f.write(str(list(kmeans_scaler.mean_)) + "\n\n")
        f.write("--- SCALER VARIANCE ---" + "\n")
        f.write(str(list(kmeans_scaler.var_)) + "\n\n")
        f.write("--- KMEANS CENTROIDS ---" + "\n")
        for i, center in enumerate(kmeans_model.cluster_centers_):
            f.write(f"Cluster {i}: {list(center)}\n")

#-------------------------------------------------------------------------------

#kmeans_model, scaler = train_kmeans('Dataset/soulslike_500.csv')
#save_model(kmeans_model, scaler)
transform_model2cs()