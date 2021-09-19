using System;
using System.Collections.Generic;

namespace HomeworkResolved
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proporciona varias palabras, seaparadas por espacios, las ordenaré por ti y escribiré en mayuscula.");
            string words = Console.ReadLine();
            string[] wordArray = words.Split(" ");
            List<string> wordList = new List<string>(wordArray);
            wordList.Sort();
            foreach (string item in wordList)
            {
                Console.WriteLine(item.ToUpper());
            }
            Console.ReadKey();
        }
    }
}
