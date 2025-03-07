#include <stdio.h>
#include <stdlib.h>
#include "stack.h"

// Função para criar uma pilha vazia
Stack* createStack() {
    Stack* stack = (Stack*)malloc(sizeof(Stack));
    stack->top = -1;
    return stack;
}

// Verifica se a pilha está vazia
bool isStackEmpty(Stack* stack) {
    return stack->top == -1;
}

// Verifica se a pilha está cheia
bool isStackFull(Stack* stack) {
    return stack->top == MAX_STACK_SIZE - 1;
}

// Adiciona um item na pilha
void push(Stack* stack, int value) {
    if (isStackFull(stack)) {
        printf("Pilha cheia!\n");
        return;
    }

    stack->items[++stack->top] = value;
}

// Remove um item da pilha
int pop(Stack* stack) {
    if (isStackEmpty(stack)) {
        printf("Pilha vazia!\n");
        return -1;  // Retorna um valor inválido se a pilha estiver vazia
    }

    return stack->items[stack->top--];
}

// Obtém o elemento do topo da pilha sem removê-lo
int peekStack(Stack* stack) {
    if (isStackEmpty(stack)) {
        printf("Pilha vazia!\n");
        return -1;
    }
    return stack->items[stack->top];
}

// Libera a memória alocada para a pilha
void freeStack(Stack* stack) {
    free(stack);
}
