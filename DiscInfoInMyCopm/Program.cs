using System;
using System.IO;

namespace DiscInfoInMyCopm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] dreivers = DriveInfo.GetDrives();

            foreach (DriveInfo drive in dreivers)
            {
                Console.WriteLine($"Name {drive.Name}");
                Console.WriteLine($"Type {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Size {drive.TotalSize}");
                    Console.WriteLine($"Free {drive.TotalFreeSpace}");
                    Console.WriteLine($"Metka {drive.VolumeLabel}");
                }
            }
        }
    }
}