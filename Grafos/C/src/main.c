#include <stdio.h>
#include <stdbool.h>
#include "graph.h"

int main() {
    // Cria um novo grafo
    Graph* graph = createGraph(5);

    // Adiciona arestas ao grafo
    addEdge(graph, 0, 1);
    addEdge(graph, 0, 2);
    addEdge(graph, 1, 2);
    addEdge(graph, 1, 3);
    addEdge(graph, 2, 4);
    addEdge(graph, 3, 4);

    // Verifica se o grafo é conectado
    if (isConnected(graph)) {
        printf("O Grafo nao eh conexo\n");
    } else {
        printf("O Grafo nao eh conexo\n");
    }

    // Realiza BFS a partir do vértice 0
    printf("BFS comecando do vertice 0: ");
    bool visited[MAX_VERTICES] = {false};
    bfs(graph, 0, visited);
    printf("\n");

    // Realiza DFS a partir do vértice 0
    printf("DFS comecando do vertice 0: ");
    for (int i = 0; i < graph->numVertices; i++) {
        visited[i] = false;
    }
    dfs(graph, 0, visited);
    printf("\n");

    // Realiza DFS Recursivo a partir do vértice 0
    printf("DFS Recursivo comecando do vertice 0: ");
    depthFirstSearchRecursive(graph, 0);
    printf("\n");

    return 0;
}
