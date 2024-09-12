namespace MSTWithKruskalAlgorithm
{
    public class Edge
    {
        public int Source;

        public int Destination;

        public decimal Weight;

        public Edge(int source, int destination, decimal weight)
        {
            this.Source = source; 
            this.Destination = destination;
            this.Weight = weight;
        }
    }
}
