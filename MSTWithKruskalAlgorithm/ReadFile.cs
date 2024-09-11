using System.IO;

namespace MSTWithKruskalAlgorithm
{
    public class ReadFile
    {
        public static string Reader(string path)
        {
            string data = string.Empty;
            string result = string.Empty;
            StreamReader streamReader = null;

            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectDir = Directory.GetParent(baseDir).Parent.Parent.Parent.FullName;
                string fullPath = Path.Combine(projectDir, path);

                streamReader = new StreamReader(fullPath);
                data = streamReader.ReadLine();

                while (data != null)
                {
                    result += data + "\n";
                    data = streamReader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
            }

            return result;
        }
    }
}
