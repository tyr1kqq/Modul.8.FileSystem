using System.Globalization;

namespace NextMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempFile = Path.GetTempFileName();
            var FileInfo = new FileInfo(tempFile);

            using (StreamWriter sw = FileInfo.CreateText())
            {
                sw.WriteLine("Igor");
                sw.WriteLine("Turkin");
                sw.WriteLine("tyr1k_qq");

            }

            using (StreamReader sr = FileInfo.OpenText())
            {
            string str = " ";
                while ((str = sr.ReadLine())!= null) 
                {
                    Console.WriteLine(str);
                }
            }
            try
            {
                string tempFile2 = Path.GetTempFileName();
                var FileInfo2 = new FileInfo(tempFile2);

                FileInfo2.Delete();

                FileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile} copy to {tempFile2}");
                FileInfo.Delete();
                Console.WriteLine($"{tempFile} has Deleted");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}