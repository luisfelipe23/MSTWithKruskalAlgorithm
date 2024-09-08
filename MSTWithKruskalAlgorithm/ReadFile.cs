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
                streamReader = new StreamReader(path);
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
