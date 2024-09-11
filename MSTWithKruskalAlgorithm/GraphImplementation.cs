using System;

namespace MSTWithKruskalAlgorithm
{
    public class GraphImplementation : GraphBase
    {
        decimal[,] Matrix;

        public GraphImplementation(int numVertices) : base(numVertices)
        {
            GenerateEmptyMatrix(numVertices);
        }

        public override void AddMatrixEdges(int edgesNumber)
        {
            Random random = new Random();
            int countEdges = CountEdges() / 2;

            for(int i = 0; i < this.NumVertices; i++)
            {
                for (int j = 0; j < this.NumVertices; j++)
                {
                    if (countEdges < edgesNumber)
                    {
                        if (random.NextDouble() > 0.8)
                        {
                            AddEdge(i, j, random.Next(1, 10));
                            countEdges++;
                        }
                    }
                }
            }
        }

        public override void AddEdge(int v1, int v2, decimal weight)
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
                    Console.Write(this.Matrix[i, j].ToString("0.0"));
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

        public override decimal GetEdgeWeight(int v1, int v2)
        {
            if (v1 >= this.NumVertices || v2 >= this.NumVertices || v1 < 0 || v2 < 0)
                throw new ArgumentOutOfRangeException("Vertices are out of bounds");

            return this.Matrix[v1, v2];
        }

        private void GenerateEmptyMatrix(int numVertices)
        {
            this.Matrix = new decimal[numVertices, numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Matrix[i, j] = 0M;
                }
            }
        }

        public override int CountEdges()
        {
            int count = 0;

            for (int i = 0; i < this.NumVertices; i++) {
                for (int j = 0; j < this.NumVertices; j++) {
                    if (this.Matrix[i, j] != 0)
                        count++;
                }
            }

            return count;
        }
    }
}
