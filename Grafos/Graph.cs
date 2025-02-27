public class Graph
{
    //Numero de vertices que compoe o grafo
    private int numVertices;
    //Lista de adjacência - Grafo representado em uma lista de listas
    //(Cada vertice, tem uma lista de vizinhos adjacentes)
    public List<List<int>> adjList = new List<List<int>>();

    //Representação das arestas em forma de matriz de adjacência
    public bool[,] adjMatrix;


    /// <summary>
    /// Construtor do Grafo
    /// </summary>
    /// <param name="vertices">Numero de vertices que compoe o grafo</param>
    public Graph(int vertices)
    {
        numVertices = vertices;
        adjMatrix = new bool[vertices, vertices];

        for (int i = 0; i < numVertices; i++)
        {
            adjList.Add(new List<int>());
        }
    }

    /// <summary>
    /// Adiciona arestas entre os vertices do grafo
    /// </summary>
    /// <param name="src">Vertice Origem</param>
    /// <param name="dest">Vertice Destino</param>
    public void AddEdge(int src, int dest)
    {
        adjList[src].Add(dest);
        adjList[dest].Add(src);

        adjMatrix[src, dest] = true;
        adjMatrix[dest, src] = true;
    }

    #region BFS
    /// <summary>
    /// Realiza busca em largura na lista de adjacência
    /// </summary>
    /// <param name="startVertice">Vertice para começar a busca</param>
    public void BreadthFirstSearch(int startVertice)
    {
        //Vetor dos vertices - se foram visitados ou nao
        bool[] visited = new bool[numVertices];
        //Fila de vizinhos
        Queue<int> queue = new Queue<int>();

        //Marca o nosso vertice inicial como visitado,
        //e adiciona na fila para visitar os vizinhos dele
        visited[startVertice] = true;
        queue.Enqueue(startVertice);

        while (queue.Count > 0)
        {
            //Pega o primeiro elemento da fila
            int currentVertex = queue.Dequeue();
            Console.Write(currentVertex + " ");

            //Visita dos vizinhos desse elemento e adiciona na fila
            foreach (int adj in adjList[currentVertex])
            {
                if (!visited[adj])
                {
                    visited[adj] = true;
                    queue.Enqueue(adj);
                }
            }
        }
    }
    #endregion

    #region DFS
    /// <summary>
    /// Realiza busca em profundidade na lista de adjacência utilizando uma pilha
    /// </summary>
    /// <param name="startVertice">Vertice para começar a busca</param>
    public void DepthFirstSearch(int startVertice)
    {
        // Vetor dos vértices - se foram visitados ou não
        bool[] visited = new bool[numVertices];

        // Pilha para simular o comportamento recursivo
        Stack<int> stack = new Stack<int>();

        // Adiciona o vértice inicial na pilha
        stack.Push(startVertice);

        while (stack.Count > 0)
        {
            // Pega o topo da pilha (último vértice inserido)
            int currentVertex = stack.Pop();

            // Se o vértice já foi visitado, continua para o próximo
            if (visited[currentVertex])
                continue;

            // Marca o vértice como visitado e imprime
            visited[currentVertex] = true;
            Console.Write(currentVertex + " ");

            // Adiciona os vizinhos não visitados à pilha
            // Os vizinhos são inseridos na pilha na ordem inversa para que o primeiro da lista seja visitado primeiro
            foreach (int adj in adjList[currentVertex])
            {
                if (!visited[adj])
                {
                    stack.Push(adj);
                }
            }
        }
    }


    /// <summary>
    /// Realiza busca em profundidade na lista de adjacência utilizando recursividade
    /// </summary>
    /// <param name="startVertice">Vertice para começar a busca</param>
    public void DepthFirstSearchRecursive(int startVertice)
    {
        // Vetor dos vértices - se foram visitados ou não
        bool[] visited = new bool[numVertices];

        // Chama o método auxiliar recursivo
        DFSRecursive(startVertice, visited);
    }

    /// <summary>
    /// Método auxiliar recursivo para realizar a busca em profundidade
    /// </summary>
    /// <param name="vertex">Vértice atual</param>
    /// <param name="visited">Vetor de vértices visitados</param>
    private void DFSRecursive(int vertex, bool[] visited)
    {
        // Marca o vértice como visitado
        visited[vertex] = true;

        // Exibe o vértice visitado
        Console.Write(vertex + " ");

        // Visita todos os vizinhos não visitados
        foreach (int adj in adjList[vertex])
        {
            if (!visited[adj])
            {
                DFSRecursive(adj, visited);
            }
        }
    }
    #endregion
}
