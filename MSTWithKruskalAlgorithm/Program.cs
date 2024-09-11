using MSTWithKruskalAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        string data = ReadFile.Reader("EdgesFile.txt");
        string[] graphInformation = data.Split('\n');

        var adjMatrixGraph = new GraphImplementation(int.Parse(graphInformation[0]));

        for (int i = 2; i < graphInformation.Length - 1; i++)
        {
            string[] graphEdge = graphInformation[i].Split(' ');

            adjMatrixGraph.AddEdge(int.Parse(graphEdge[0]), int.Parse(graphEdge[1]), decimal.Parse(graphEdge[2], System.Globalization.CultureInfo.InvariantCulture));
        }

        adjMatrixGraph.Display();
    }
}