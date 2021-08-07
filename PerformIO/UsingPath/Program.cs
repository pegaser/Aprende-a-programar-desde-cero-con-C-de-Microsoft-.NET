using System;
using System.IO;

namespace UsingPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\temp";
            string fileName = "test.dat";
            string fullPath = Path.Combine(folder, fileName);
            Console.WriteLine(fullPath);

            string path = @"C:\temp\test.txt";
            Console.WriteLine(Path.GetDirectoryName(path)); // Displays C:\temp\subdir
            Console.WriteLine(Path.GetExtension(path)); // Displays .txt
            Console.WriteLine(Path.GetFileName(path)); // Displays file.txt
            Console.WriteLine(Path.GetPathRoot(path)); // Displays C:\
            Console.ReadKey();
        }
    }
}
