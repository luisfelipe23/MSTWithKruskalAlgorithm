namespace MSTWithKruskalAlgorithm
{
    public class GraphImplementation : GraphBase
    {
        int[,] Matrix;

        public GraphImplementation(int numVertices) : base(numVertices)
        {
            GenerateEmptyMatrix(numVertices);
        }

        public override void AddEdge(int v1, int v2, int weight)
        {
            if (v1 >= this.NumVertices || v2 >= this.NumVertices || v1 < 0 || v2 < 0)
                throw new ArgumentOutOfRangeException("Vertices are out of bounds");

            if (v1 != v2 && weight != this.Matrix[v1, v2])
            {
                this.Matrix[v1, v2] = weight;
                this.Matrix[v2, v1] = weight;
            }
        }

        public override void Display()
        {
            for (int i = 0; i < this.NumVertices; i++)
            {
                for (int j = 0; j < this.NumVertices; j++)
                {
                    Console.Write(this.Matrix[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public override IEnumerable<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v >= this.NumVertices) throw new ArgumentOutOfRangeException("Cannot access vertex");

            List<int> adjacentVertices = new List<int>();
            for (int i = 0; i < this.NumVertices; i++)
            {
                if (this.Matrix[v, i] > 0)
                    adjacentVertices.Add(i);
            }
            return adjacentVertices;

        }

        public override int GetEdgeWeight(int v1, int v2)
        {
            if (v1 >= this.NumVertices || v2 >= this.NumVertices || v1 < 0 || v2 < 0)
                throw new ArgumentOutOfRangeException("Vertices are out of bounds");

            return this.Matrix[v1, v2];
        }

        private void GenerateEmptyMatrix(int numVertices)
        {
            this.Matrix = new int[numVertices, numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Matrix[i, j] = 0;
                }
            }
        }
    }
}
