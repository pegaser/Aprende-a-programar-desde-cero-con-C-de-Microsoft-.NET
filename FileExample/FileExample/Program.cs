using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\FileExample\MyTest.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

            File.WriteAllText(path, "Contenido desde WriteTextAll.");
            string allText = File.ReadAllText(path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(allText);
            Console.ReadKey();

            File.AppendAllText(path, " Conteido agregado.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            allText = File.ReadAllText(path);
            Console.WriteLine(allText);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] contentLines = { "Líneas", "desde", "un array" };
            File.WriteAllLines(path, contentLines);
            foreach (string line in File.ReadLines(path))
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

        }
    }
}
