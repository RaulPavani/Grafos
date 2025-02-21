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
}
