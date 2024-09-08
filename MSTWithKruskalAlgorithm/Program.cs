using MSTWithKruskalAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        var adjMatrixGraph = new GraphImplementation(9);
        adjMatrixGraph.AddEdge(0, 8, 2);
        adjMatrixGraph.AddEdge(0, 3, 3);
        adjMatrixGraph.AddEdge(8, 4, 4);

        adjMatrixGraph.Display();
        Console.WriteLine();

        var adjacent = adjMatrixGraph.GetAdjacentVertices(8);

        foreach (int vertex in adjacent)
        {
            Console.WriteLine(vertex);
        }
    }
}