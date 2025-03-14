class Program
{
    static void Main()
    {
        //Cria um novo grafo
        Graph graph = new Graph(6);

        //Adiciona as conexoes do grafo (arestas)
        graph.AddEdge(0, 1, 10);
        graph.AddEdge(0, 2, 5);

        graph.AddEdge(1, 2, 3);
        graph.AddEdge(1, 3, 1);

        graph.AddEdge(2, 3, 8);
        graph.AddEdge(2, 4, 2);

        graph.AddEdge(3, 4, 4);
        graph.AddEdge(3, 5, 4);

        graph.AddEdge(4, 5, 6);

        //Verifica se um grafo é conectado ou nao
        //graph.IsConnected();
        int init = 0;
        int dest = 5;
        int[] shortPath = graph.Dijkstra(init);
        Console.WriteLine($"Menor distancia do ponto inicial {init}: " +
            $"até o {dest}: {shortPath[dest]}");
    }
}