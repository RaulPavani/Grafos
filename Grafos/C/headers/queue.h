#ifndef QUEUE_H
#define QUEUE_H

#include <stdbool.h>

#define MAX_QUEUE_SIZE 100

// Estrutura da Fila
typedef struct Queue {
    int front;
    int rear;
    int items[MAX_QUEUE_SIZE];
} Queue;

// Protótipos das funções
Queue* createQueue();
bool isQueueEmpty(Queue* queue);
bool isQueueFull(Queue* queue);
void enqueue(Queue* queue, int value);
int dequeue(Queue* queue);
int peekQueue(Queue* queue);
void freeQueue(Queue* queue);

#endif

