#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include "graph.h"

// Função para criar um grafo com o número de vértices especificado
Graph* createGraph(int vertices) {
    Graph* graph = (Graph*)malloc(sizeof(Graph));
    graph->numVertices = vertices;

    for (int i = 0; i < vertices; i++) {
        graph->adjList[i] = (int*)malloc(vertices * sizeof(int));  // Aloca memória para a lista de adjacência
        for (int j = 0; j < vertices; j++) {
            graph->adjMatrix[i][j] = false;  // Inicializa a matriz de adjacência
        }
    }

    return graph;
}

// Função para adicionar uma aresta entre dois vértices
void addEdge(Graph* graph, int src, int dest) {
    graph->adjList[src][dest] = 1;
    graph->adjList[dest][src] = 1;

    graph->adjMatrix[src][dest] = true;
    graph->adjMatrix[dest][src] = true;
}

// Função BFS (Busca em Largura)
void bfs(Graph* graph, int startVertex, bool* visited) {
    Queue* queue = createQueue();
    visited[startVertex] = true;
    enqueue(queue, startVertex);

    while (!isQueueEmpty(queue)) {
        int currentVertex = dequeue(queue);
        printf("%d ", currentVertex);

        // Visita todos os vértices adjacentes
        for (int i = 0; i < graph->numVertices; i++) {
            if (graph->adjMatrix[currentVertex][i] && !visited[i]) {
                visited[i] = true;
                enqueue(queue, i);
            }
        }
    }

    freeQueue(queue);
}

// Função DFS (Busca em Profundidade)
void dfs(Graph* graph, int startVertex, bool* visited) {
    Stack* stack = createStack();
    push(stack, startVertex);

    while (!isStackEmpty(stack)) {
        int currentVertex = pop(stack);
        if (visited[currentVertex]) continue;

        visited[currentVertex] = true;
        printf("%d ", currentVertex);

        // Adiciona os vértices adjacentes na pilha
        for (int i = 0; i < graph->numVertices; i++) {
            if (graph->adjMatrix[currentVertex][i] && !visited[i]) {
                push(stack, i);
            }
        }
    }

    freeStack(stack);
}

// Função auxiliar recursiva para DFS
void dfsRecursive(Graph* graph, int vertex, bool* visited) {
    visited[vertex] = true;
    printf("%d ", vertex);

    for (int i = 0; i < graph->numVertices; i++) {
        if (graph->adjMatrix[vertex][i] && !visited[i]) {
            dfsRecursive(graph, i, visited);
        }
    }
}

// Função DFS Recursiva
void depthFirstSearchRecursive(Graph* graph, int startVertex) {
    bool visited[MAX_VERTICES] = {false};
    dfsRecursive(graph, startVertex, visited);
}

// Função para verificar se o grafo é conectado
bool isConnected(Graph* graph) {
    bool visited[MAX_VERTICES] = {false};

    bfs(graph, 0, visited);

    for (int i = 0; i < graph->numVertices; i++) {
        if (!visited[i]) {
            return false;
        }
    }
    return true;
}
