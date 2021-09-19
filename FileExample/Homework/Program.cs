using System;
using System.IO;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proporciona texto para agregar al archivo (Presiona 'Q' para terminar)");
            string line;
            do
            {
                line = Console.ReadLine();
                File.AppendAllText(@"C:\temp\MyFile.txt", line);
                File.AppendAllText(@"C:\temp\MyFile.txt", Environment.NewLine);

            } while (line.ToLower() != "q");

            Console.WriteLine(@"Puedes ver tu archivo en C:\temp\MyFile.txt");
            Console.ReadKey();
        }
    }
}