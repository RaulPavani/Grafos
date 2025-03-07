#ifndef GRAPH_H
#define GRAPH_H

#include <stdbool.h>
#include "queue.h"
#include "stack.h"

#define MAX_VERTICES 100

// Estrutura do Grafo
typedef struct Graph {
    int numVertices;
    bool adjMatrix[MAX_VERTICES][MAX_VERTICES];
    int* adjList[MAX_VERTICES];
} Graph;

// Protótipos das funções
Graph* createGraph(int vertices);
void addEdge(Graph* graph, int src, int dest);
void bfs(Graph* graph, int startVertex, bool* visited);
void dfs(Graph* graph, int startVertex, bool* visited);
void dfsRecursive(Graph* graph, int vertex, bool* visited);
void depthFirstSearchRecursive(Graph* graph, int startVertex);
bool isConnected(Graph* graph);

#endif
