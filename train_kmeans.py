import pandas as pd
from sklearn.cluster import KMeans
import joblib
from sklearn.preprocessing import StandardScaler

df = pd.read_csv('Dataset/soulslike_500.csv')

scaler = StandardScaler()
df_scaled = scaler.fit_transform(df)

kmeans = KMeans(n_clusters=2, random_state=42)
kmeans.fit(df_scaled)

joblib.dump(kmeans, 'Models/Kmeans/model.joblib')
joblib.dump(scaler, 'Models/Kmeans/scaler.joblib')