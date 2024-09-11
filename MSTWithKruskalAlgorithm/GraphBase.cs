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

        public abstract void AddMatrixEdges(int edgesNumber);

        public abstract IEnumerable<int> GetAdjacentVertices(int v);

        public abstract decimal GetEdgeWeight(int v1, int v2);

        public abstract void Display();

        public abstract int CountEdges();
    }
}
