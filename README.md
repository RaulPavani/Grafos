# Grafos e Complexidade de Algoritmo #
Este repositório foi criado para a disciplina de Grafos e Complexidade de Algoritmos, e contém implementações e estudos relacionados à teoria dos grafos. Aborda conceitos fundamentais e algoritmos utilizados na análise de grafos.<br>
Os [grafos](https://pt.wikipedia.org/wiki/Teoria_dos_grafos) são modelos matemáticos amplamente utilizados para representar relações entre elementos, sendo aplicáveis em diversas áreas, como redes de computadores, inteligência artificial, logística, biologia computacional, entre outras.

Neste repositório, você encontrará implementações de algoritmos clássicos em C# para manipulação de grafos, incluindo busca, percorrimento e estruturação.

## Algoritmos

### [Criação de Grafo e Lista de Adjacência](https://pt.wikipedia.org/wiki/Lista_de_adjac%C3%AAncia)
A representação de um grafo pode ser feita de várias formas, sendo a lista de adjacência uma das mais eficientes em termos de espaço. Nesse método, cada vértice mantém uma lista de nós adjacentes, facilitando operações como inserção e busca de conexões. A adição de arestas conecta os vértices, permitindo a modelagem de diferentes tipos de grafos. <br>
[Implementação Grafo e Lista de Adjacência](https://github.com/RaulPavani/Grafos/tree/main/Grafos/Graph.cs#L3-L40)
<br><br><br>

### [Breadth-first search (BFS)](https://pt.wikipedia.org/wiki/Busca_em_largura)
A busca em largura (BFS) é um algoritmo de percorrimento de grafos que explora todos os vértices de um nível antes de avançar para o próximo. Ele utiliza uma fila para garantir que os nós sejam visitados na ordem correta, sendo útil para encontrar o caminho mais curto em grafos não ponderados.<br>
[Implementação BFS](https://github.com/RaulPavani/Grafos/tree/main/Grafos/Graph.cs#L46-L73)
<br><br><br>
