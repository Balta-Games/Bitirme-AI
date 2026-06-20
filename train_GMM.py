import numpy as np
import pandas as pd
from sklearn.mixture import GaussianMixture
import matplotlib.pyplot as plt
from sklearn.decomposition import PCA
from sklearn.preprocessing import StandardScaler
from sklearn.metrics import silhouette_score

def plot_clusters(df_scaled, model, labels):
    pca = PCA(n_components=2)
    df_pca = pca.fit_transform(df_scaled)
    feature_count = df_scaled.shape[1]
    centroids_df = pd.DataFrame(model.means_, columns=range(feature_count))
    centroids_pca = pca.transform(centroids_df)
    
    plt.figure(figsize=(8, 6))
    scatter = plt.scatter(df_pca[:, 0], df_pca[:, 1], c=labels, cmap='viridis', alpha=0.6, edgecolors='k')
    
    plt.scatter(centroids_pca[:, 0], centroids_pca[:, 1], c='red', marker='X', s=200, label='Centroids')
    
    plt.title('GMM Cluster Distribution')
    plt.xlabel('Bileşen 1')
    plt.ylabel('Bileşen 2')
    plt.legend(*scatter.legend_elements(), title="Clusters")
    plt.grid(True, linestyle='--', alpha=0.5)
    plt.savefig('Analytics/gmm_clusters.png')
    plt.close()

def plot_bic_method(df_scaled):
    bic_scores = [] 
    aic_scores = []
    k_range = range(1, 11) 
    
    for k in k_range:
        gmm = GaussianMixture(n_components=k, covariance_type='full', random_state=42)
        gmm.fit(df_scaled)
        bic_scores.append(gmm.bic(df_scaled))
        aic_scores.append(gmm.aic(df_scaled))
        
    plt.figure(figsize=(10, 5))
    plt.plot(k_range, bic_scores, marker='o', linestyle='--', color='b')
    plt.plot(k_range, aic_scores, marker='o', linestyle='--', color='r')
    plt.title('GMM BIC and AIC METHOD')
    plt.xlabel('Cluster Number (k)')
    plt.ylabel('BIC / AIC Score')
    plt.grid(True)
    plt.savefig('Analytics/gmm_bic.png')
    plt.close()

def print_and_plot_silhouette(df_scaled, labels):
    score = silhouette_score(df_scaled, labels)
    print(f"GMM Silhouette Score: {score:.4f}")
    
    plt.figure(figsize=(4, 5))
    plt.bar(['Silhouette Score'], [score], color='orange', width=0.4)
    plt.ylim(-1, 1) 
    plt.text(0, score + 0.05, f"{score:.2f}", ha='center', fontweight='bold')
    plt.title('Cluster Quality')
    plt.savefig('Analytics/gmm_silhouette.png')
    plt.close()

def train_gmm(file_path):
    X_train = pd.read_csv(file_path)
    scaler = StandardScaler()
    X_scaled = scaler.fit_transform(X_train) 
    pca = PCA(n_components=2, random_state=42)
    X_pca = pca.fit_transform(X_scaled)

    gmm = GaussianMixture(n_components=4, covariance_type='full', random_state=42)
    gmm.fit(X_pca)

    labels = gmm.predict(X_pca)
    probabilities = gmm.predict_proba(X_pca)

    X_train['label'] = labels
    X_train.to_csv("Dataset/player_data_labeled_gmm.csv", index=False)

    plot_clusters(X_pca, gmm, labels)
    plot_bic_method(X_pca)
    print_and_plot_silhouette(X_pca, labels)

    print("Sert Etiketler:", labels)

train_gmm('Dataset/player_data_expanded_5000.csv')

