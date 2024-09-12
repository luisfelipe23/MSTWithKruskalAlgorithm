namespace MSTWithKruskalAlgorithm
{
    public class GraphGenerator
    {
        public static List<Edge> GenerateRandomGraph(int numVertices, int numEdges)
        {
            List<Edge> edges = new List<Edge>();
            int count = 0;
            Random random = new Random();

            while (count < numEdges)
            {
                int v1 = random.Next(0, numVertices);
                int v2 = random.Next(0, numVertices);
                decimal weight = (decimal)(random.NextDouble() * 20.0 - 10.0);
                weight = Math.Round(weight, 1);

                if (v1 != v2 && weight != 0 && (!(edges.Any(e => e.Source == v1 && e.Destination == v2)) && !(edges.Any(e => e.Source == v2 && e.Destination == v1))))
                {
                    edges.Add(new Edge(v1, v2, weight));
                    count++;
                }
            }

            return edges;
        }
    }
}
