using MSTWithKruskalAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        string data = ReadFile.Reader("C:\\Users\\userl\\source\\repos\\MSTWithKruskalAlgorithm\\MSTWithKruskalAlgorithm\\EdgesFile.txt");
        string[] graphInformation = data.Split('\n');

        var adjMatrixGraph = new GraphImplementation(int.Parse(graphInformation[0]));

        do
        {
            adjMatrixGraph.AddMatrixEdges(int.Parse(graphInformation[1]));
        } while ((adjMatrixGraph.CountEdges() / 2) < int.Parse(graphInformation[1]));

        adjMatrixGraph.Display();
    }
}