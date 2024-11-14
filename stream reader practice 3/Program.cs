namespace stream_reader_practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile(@"C:\TestFiles\test1.txt");
            ReadFile(@"C:\TestFiles\test1.txt");
        }

        private static void ReadFile(string path)
        {
            string line;
            try
            {
                var sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static public void WriteFile(string path) 
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("Firt name: Raheim");
                sw.WriteLine("Age: 22");
                sw.WriteLine("Address: Fort Liberty");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            
        }
    }
}
