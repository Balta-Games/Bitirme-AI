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

def transform_model2ONNX():
    kmeans_model = joblib.load('Models/Kmeans/model.joblib')
    kmeans_scaler = joblib.load('Models/Kmeans/scaler.joblib')

    #Veriniz kaç sütundan oluşuyorsa (Örn: 4 sütun) buraya yazın
    initial_type = [('float_input', FloatTensorType([None, 5]))] 

    pipeline = Pipeline([('scaler', kmeans_scaler), ('kmeans', kmeans_model)])
    onnx_kmeans = convert_sklearn(pipeline, initial_types=initial_type)

    with open("Models/Kmeans/pipeline.onnx", "wb") as f:
        f.write(onnx_kmeans.SerializeToString())

#-------------------------------------------------------------------------------

#kmeans_model, scaler = train_kmeans('Dataset/soulslike_500.csv')
#save_model(kmeans_model, scaler)
transform_model2ONNX()