class Program
{
    static void Main()
    {
        Graph graph = new Graph(5);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);

        graph.BreadthFirstSearch(0);
    }

    class Graph
    {
        private int numVertices;
        public List<List<int>> adjList = new List<List<int>>();
        public bool[,] adjMatrix;

        public Graph(int vertices)
        {
            numVertices = vertices;
            adjMatrix = new bool[vertices, vertices];

            for (int i = 0; i < numVertices; i++)
            {
                adjList.Add(new List<int>());
            }
        }

        public void AddEdge(int src, int dest)
        {
            adjList[src].Add(dest);
            adjList[dest].Add(src);

            adjMatrix[src, dest] = true;
            adjMatrix[dest, src] = true;
        }

        public void BreadthFirstSearch(int startVertice)
        {
            bool[] visited = new bool[numVertices];
            Queue<int> queue = new Queue<int>();

            visited[startVertice] = true;
            queue.Enqueue(startVertice);

            while(queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write(currentVertex + " ");

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
}


