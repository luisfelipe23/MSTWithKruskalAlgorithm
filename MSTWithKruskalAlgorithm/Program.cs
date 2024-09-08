using MSTWithKruskalAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        string data = ReadFile.Reader("C:\\Users\\userl\\source\\repos\\MSTWithKruskalAlgorithm\\MSTWithKruskalAlgorithm\\EdgesFile.txt");
        string[] graphInformation = data.Split('\n');

        var adjMatrixGraph = new GraphImplementation(int.Parse(graphInformation[0]));

        Random random = new Random();

        for (int i = 0; i < int.Parse(graphInformation[0]); i++)
        {
            for (int j = 0; j < int.Parse(graphInformation[0]); j++)
            {
                if (random.NextDouble() > 0.5)
                {
                    adjMatrixGraph.AddEdge(i, j, random.Next(1, 10));
                }
            }
        }

        adjMatrixGraph.Display();
    }
}