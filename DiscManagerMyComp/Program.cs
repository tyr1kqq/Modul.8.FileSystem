using System.IO;
using System.Runtime;

namespace DiscManagerMyComp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GetCatalog();
            
            GetNumber();
        }
        static void GetCatalog()
        {
            
            string dirName = "C:\\";

            if(Directory.Exists(dirName))
            {
                Console.WriteLine("Papka");
                string[] dirs = Directory.GetDirectories(dirName);

                DirectoryInfo dires = new DirectoryInfo(dirName);
                Console.WriteLine($"Название каталога: {dires.Name}");
                Console.WriteLine($"Полное название каталога: {dires.FullName}"); 
                Console.WriteLine($"Время создания каталога: {dires.CreationTime}");
                Console.WriteLine($"Корневой каталог: {dires.Root}");

                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
                Console.WriteLine();
                Console.WriteLine("Files");
                string[] Files = Directory.GetFiles(dirName);
                foreach(string file in Files)
                {
                    Console.WriteLine(file);
                }
            }
        }
        static void GetNumber()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("C:\\");
                if (directoryInfo.Exists)
                {
                    Console.WriteLine(directoryInfo.GetDirectories().Length + directoryInfo.GetFiles().Length);

                    DirectoryInfo newDirectory = new DirectoryInfo(@"/tyr!k_qq");
                    if(!newDirectory.Exists)
                        newDirectory.Create();

                    Console.WriteLine(directoryInfo.GetDirectories().Length + directoryInfo.GetFiles().Length);

                    try
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(@"/tyr!k_qq");
                        dirInfo.Delete(true);
                        Console.WriteLine("Catalog delete");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       

      
    }
   

}