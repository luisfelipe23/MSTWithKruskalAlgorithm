using MSTWithKruskalAlgorithm;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        /*string data = ReadFile.Reader("EdgesFile.txt");
        string[] graphInformation = data.Split('\n');

        var adjMatrixGraph = new GraphImplementation(int.Parse(graphInformation[0]));

        List<Edge> edges = new List<Edge>();

        for (int i = 2; i < int.Parse(graphInformation[1]) + 2; i++)
        {
            string[] graphEdge = graphInformation[i].Split(' ');
            edges.Add(new Edge(int.Parse(graphEdge[0]), int.Parse(graphEdge[1]), decimal.Parse(graphEdge[2], System.Globalization.CultureInfo.InvariantCulture)));
        }

        adjMatrixGraph.Display(edges);

        Console.WriteLine();
        List<Edge> mst = adjMatrixGraph.MST_Kruskal(edges);

        foreach (Edge m in mst)
        {
            Console.WriteLine($"{m.Source} - {m.Destination}: {m.Weight}");
        }*/

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int count = 0;
        int numVertices = 15;
        int numEdges = 100;

        do
        {
            var adjMatrixGraph = new GraphImplementation(numVertices);

            List<Edge> edges = new List<Edge>();
            edges = GraphGenerator.GenerateRandomGraph(numVertices, numEdges);

            List<Edge> mst = adjMatrixGraph.MST_Kruskal(edges, numEdges);

            count++;
        } while (count < 10) ;

        stopwatch.Stop();

        Console.WriteLine("Tempo decorrido: {0} ms", stopwatch.ElapsedMilliseconds);
    }
}