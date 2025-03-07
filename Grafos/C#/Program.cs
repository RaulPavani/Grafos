class Program
{
    static void Main()
    {
        //Cria um novo grafo
        Graph graph = new Graph(5);

        //Adiciona as conexoes do grafo (arestas)
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        //graph.AddEdge(1, 3);
        //graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);

        //Verifica se um grafo é conectado ou nao
        graph.IsConnected();
    }
}