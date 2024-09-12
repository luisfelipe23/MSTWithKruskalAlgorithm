namespace MSTWithKruskalAlgorithm
{
    public abstract class GraphBase
    {
        public int NumVertices { get; private set; }

        public GraphBase(int numVertices)
        {
            this.NumVertices = numVertices;
        }

        public abstract void AddEdge(int v1, int v2, decimal weight);

        public abstract void Display(List<Edge> edges);
    }
}
