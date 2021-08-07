using System;
using System.IO;

namespace ListingAllFilesInDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string file in Directory.GetFiles(@"C:\Windows"))
            {
                Console.WriteLine(file);
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows");
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                Console.WriteLine(fileInfo.FullName);
            }
            Console.ReadKey();
        }
    }
}
