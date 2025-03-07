#ifndef STACK_H
#define STACK_H

#include <stdbool.h>

#define MAX_STACK_SIZE 100

// Estrutura da Pilha
typedef struct Stack {
    int top;
    int items[MAX_STACK_SIZE];
} Stack;

// Protótipos das funções
Stack* createStack();
bool isStackEmpty(Stack* stack);
bool isStackFull(Stack* stack);
void push(Stack* stack, int value);
int pop(Stack* stack);
int peekStack(Stack* stack);
void freeStack(Stack* stack);

#endif

