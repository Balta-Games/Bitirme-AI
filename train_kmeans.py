import pandas as pd
from sklearn.cluster import KMeans
from sklearn.preprocessing import StandardScaler
from sklearn.pipeline import Pipeline
import joblib
from skl2onnx import convert_sklearn
from skl2onnx.common.data_types import FloatTensorType
import matplotlib.pyplot as plt
from sklearn.decomposition import PCA
import numpy as np
from sklearn.metrics import silhouette_score

def plot_clusters(df_scaled, kmeans_model):
    pca = PCA(n_components=2)
    df_pca = pca.fit_transform(df_scaled)
    feature_count = df_scaled.shape[1]
    centroids_df = pd.DataFrame(kmeans_model.cluster_centers_, columns=range(feature_count))
    centroids_pca = pca.transform(centroids_df)
    
    plt.figure(figsize=(8, 6))
    
    labels = kmeans_model.labels_
    scatter = plt.scatter(df_pca[:, 0], df_pca[:, 1], c=labels, cmap='viridis', alpha=0.6, edgecolors='k')
    
    plt.scatter(centroids_pca[:, 0], centroids_pca[:, 1], c='red', marker='X', s=200, label='Centroids')
    
    plt.title('K-Means Cluster Distribution')
    plt.xlabel('Bileşen 1')
    plt.ylabel('Bileşen 2')
    plt.legend(*scatter.legend_elements(), title="Clusters")
    plt.grid(True, linestyle='--', alpha=0.5)
    plt.savefig('Analytics/kmeans_clusters.png')
    plt.close()

def plot_elbow_method(df_scaled):
    wcss = [] 
    k_range = range(1, 11) 
    
    for k in k_range:
        km = KMeans(n_clusters=k, random_state=42)
        km.fit(df_scaled)
        wcss.append(km.inertia_)
        
    plt.figure(figsize=(11, 5))
    plt.plot(k_range, wcss, marker='o', linestyle='--', color='b')
    plt.title('Elbow Method')
    plt.xlabel('Cluster Number (k)')
    plt.ylabel('WCSS (Inertia)')
    plt.grid(True)
    plt.savefig('Analytics/kmeans_elbow.png')
    plt.close()

def print_and_plot_silhouette(df_scaled, kmeans_model):
    score = silhouette_score(df_scaled, kmeans_model.labels_)
    print(f"K-Means Silhouette Score: {score:.4f}")
    
    plt.figure(figsize=(4, 5))
    plt.bar(['Silhouette Score'], [score], color='orange', width=0.4)
    plt.ylim(-1, 1) 
    plt.text(0, score + 0.05, f"{score:.2f}", ha='center', fontweight='bold')
    plt.title('Cluster Quality')
    plt.savefig('Analytics/kmeans_silhouette.png')
    plt.close()

def train_kmeans(file_path):
    df = pd.read_csv(file_path)

    scaler = StandardScaler()
    df_scaled = scaler.fit_transform(df)

    kmeans = KMeans(n_clusters=4, random_state=42)
    kmeans.fit(df_scaled)

    df['label'] = kmeans.labels_
    df.to_csv("Dataset/player_data_labeled.csv", index=False)

    plot_clusters(df_scaled,kmeans)
    plot_elbow_method(df_scaled)
    print_and_plot_silhouette(df_scaled,kmeans)

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

kmeans_model, scaler = train_kmeans('Dataset/player_data_expanded_5000.csv')
#save_model(kmeans_model, scaler)
#transform_model2cs()