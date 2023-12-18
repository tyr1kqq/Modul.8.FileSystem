namespace Modul._8.FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Drive
    {
       public Drive(string name , long totalspace , long freespace)
        {
            Name = name;
            TotalSpace = totalspace;
            Freespace = freespace;
        }
        public string Name { get; }
        public long TotalSpace { get; }
        public long Freespace { get; }

    }
    public class Folder
    {
        public List<string> Files = new List<string>();

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}