#include <stdio.h>
#include <stdlib.h>
#include "queue.h"

// Fun��o para criar uma fila vazia
Queue* createQueue() {
    Queue* queue = (Queue*)malloc(sizeof(Queue));
    queue->front = -1;
    queue->rear = -1;
    return queue;
}

// Verifica se a fila est� vazia
bool isQueueEmpty(Queue* queue) {
    return queue->front == -1;
}

// Verifica se a fila est� cheia
bool isQueueFull(Queue* queue) {
    return queue->rear == MAX_QUEUE_SIZE - 1;
}

// Adiciona um item na fila
void enqueue(Queue* queue, int value) {
    if (isQueueFull(queue)) {
        printf("Fila cheia!\n");
        return;
    }

    if (queue->front == -1) {
        queue->front = 0;
    }

    queue->items[++queue->rear] = value;
}

// Remove um item da fila
int dequeue(Queue* queue) {
    if (isQueueEmpty(queue)) {
        printf("Fila vazia!\n");
        return -1;  // Retorna um valor inv�lido se a fila estiver vazia
    }

    int item = queue->items[queue->front];

    if (queue->front == queue->rear) {
        queue->front = queue->rear = -1;
    } else {
        queue->front++;
    }

    return item;
}

// Obt�m o elemento da frente da fila sem remov�-lo
int peekQueue(Queue* queue) {
    if (isQueueEmpty(queue)) {
        printf("Fila vazia!\n");
        return -1;
    }
    return queue->items[queue->front];
}

// Libera a mem�ria alocada para a fila
void freeQueue(Queue* queue) {
    free(queue);
}
