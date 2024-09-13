namespace MSTWithKruskalAlgorithm
{
    public class GraphImplementation : GraphBase
    {
        decimal[,] Matrix;

        public GraphImplementation(int numVertices) : base(numVertices)
        {
            this.Matrix = GenerateEmptyMatrix(this.Matrix, numVertices);
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

        public override void Display(List<Edge> edges)
        {
            foreach (Edge edge in edges)
            {
                AddEdge(edge.Source, edge.Destination, edge.Weight);
            }

            for (int i = 0; i < this.NumVertices; i++)
            {
                for (int j = 0; j < this.NumVertices; j++)
                {
                    if (this.Matrix[i, j] >= 0)
                        Console.Write(" " + this.Matrix[i, j].ToString("0.0"));
                    else
                        Console.Write(this.Matrix[i, j].ToString("0.0"));

                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        private decimal[,] GenerateEmptyMatrix(decimal[,] matriz, int numVertices)
        {
            matriz = new decimal[numVertices, numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    matriz[i, j] = 0M;
                }
            }

            return matriz;
        }

        public override List<Edge> MST_Kruskal(List<Edge> edges, int numEdges)
        {
            List<Edge> mst = new List<Edge>();
            edges = edges.OrderBy(edge => edge.Weight).ToList();

            int[] parent = new int[this.NumVertices];

            for (int i = 0; i < this.NumVertices; i++)
                parent[i] = -1;

            int edgeCount = 0;
            int index = 0;

            while (edgeCount < this.NumVertices - 1)
            {
                index += 1;

                if (index < numEdges)
                {
                    Edge nextEdge = edges[index];

                    int x = FindParent(parent, nextEdge.Source);
                    int y = FindParent(parent, nextEdge.Destination);

                    if (x != y)
                    {
                        mst.Add(nextEdge);
                        Union(parent, x, y);
                        edgeCount++;
                    }
                }
                else
                    break;
            }

            return mst;
        }

        private int FindParent(int[] parent, int vertex)
        {
            if (parent[vertex] == -1)
                return vertex;

            return FindParent(parent, parent[vertex]);
        }

        private void Union(int[] parent, int x, int y)
        {
            int xSet = FindParent(parent, x);
            int ySet = FindParent(parent, y);

            parent[xSet] = ySet;
        }
    }
}
