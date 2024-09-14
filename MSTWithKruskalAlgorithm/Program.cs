using MSTWithKruskalAlgorithm;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string data = ReadFile.Reader("EdgesFile.txt");
        string[] graphInformation = data.Split('\n');

        var adjMatrixGraph = new GraphImplementation(int.Parse(graphInformation[0]));

        List<Edge> edges = new List<Edge>();

        for (int i = 2; i < int.Parse(graphInformation[1]) + 2; i++)
        {
            string[] graphEdge = graphInformation[i].Split(' ');
            edges.Add(new Edge(int.Parse(graphEdge[0]), int.Parse(graphEdge[1]), decimal.Parse(graphEdge[2], System.Globalization.CultureInfo.InvariantCulture)));
        }

        Console.WriteLine("Starting getting data from file\n");

        adjMatrixGraph.Display(edges);

        Console.WriteLine();
        foreach (Edge e in edges)
        {
            Console.WriteLine($"{e.Source} - {e.Destination}: {e.Weight}");
        }

        Console.WriteLine();
        List<Edge> mst = adjMatrixGraph.MST_Kruskal(edges, int.Parse(graphInformation[1]));

        foreach (Edge m in mst)
        {
            Console.WriteLine($"{m.Source} - {m.Destination}: {m.Weight}");
        }

        Console.WriteLine("\nEnd of getting data from file");
        Console.WriteLine("\n");

        int count = 0;
        int[] verticesNumbers = { 100, 200, 300, 400, 500 };
        int[] edgesNumbers = { 980, 1960, 2940, 3920, 4900 };
        int numVertices = verticesNumbers[0];
        int numEdges = edgesNumbers[0];
        bool updateVerticesIndex = true;
        bool updateEdgesIndex = false;
        int index = 0;

        Console.WriteLine("Begin of tests\n");

        while (index < verticesNumbers.Length)
        {
            List<long> elapsedTimes = new List<long>();

            if (updateVerticesIndex) 
                numVertices = verticesNumbers[index++];

            if (updateEdgesIndex)
                numEdges = edgesNumbers[index++];

            do
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                var adjacentMatrixGraph = new GraphImplementation(numVertices);

                List<Edge> newEdges = new List<Edge>();
                newEdges = GraphGenerator.GenerateRandomGraph(numVertices, numEdges);

                List<Edge> newMst = adjacentMatrixGraph.MST_Kruskal(newEdges, numEdges);

                stopwatch.Stop();

                elapsedTimes.Add(stopwatch.ElapsedMilliseconds);
                count++;
            } while (count < 10);

            count = 0;

            double average = elapsedTimes.Average(x => (double)x);

            Console.WriteLine($"Number Of Vertices: {numVertices}");
            Console.WriteLine($"Number Of Edges: {numEdges}");
            Console.WriteLine("Average Elapsed Time: {0} ms", average);
            Console.WriteLine();

            elapsedTimes.Clear();

            if (numVertices == 500)
            {
                numVertices = 100;
                updateVerticesIndex = false;
                updateEdgesIndex = true;
                index = 0;
            }
        }

        Console.WriteLine("End of tests");
    }
}