using System;
using System.IO;


namespace FileWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"/Users/tyr1k_qq/Students.txt";
            if (!File.Exists(FilePath))
            {
                using (StreamWriter sw = File.CreateText(FilePath))
                {
                    sw.WriteLine("Igor");
                    sw.WriteLine("Turkin");
                    sw.WriteLine("tyr1k_qq");
                }
            }
            using (StreamReader sr = File.OpenText(FilePath))
            {
                string str = " ";
                while ((str = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(str);
                }
            }
            string FilePr = @"/Users/tyr1k_qq/source/repos/Modul.8.FileSystem/FileWriter/Program.cs";

            using (StreamReader sr = File.OpenText(FilePr))
            {
                string str = " ";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }

            }
           
        }
    }
}