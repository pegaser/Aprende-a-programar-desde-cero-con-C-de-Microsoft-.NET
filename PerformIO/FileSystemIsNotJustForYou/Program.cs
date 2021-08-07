using System;
using System.IO;

namespace FileSystemIsNotJustForYou
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test.txt";
            if (File.Exists(path))
            {
                try
                {
                    Console.WriteLine(File.ReadAllText(path));
                }
                catch (DirectoryNotFoundException)
                {

                }
                catch (FileNotFoundException)
                {

                }
            }
            else
            {
                Console.WriteLine("No se encontró archivo");
            }
            Console.ReadKey();
        }
    }
}
