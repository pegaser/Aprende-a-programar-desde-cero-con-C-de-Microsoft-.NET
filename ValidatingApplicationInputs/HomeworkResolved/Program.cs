using System;
using System.Text.RegularExpressions;

namespace HomeworkResolved
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Proporciona una teléfono válido (%##-###-####) - Donde % debe ser mayor a 2");
                string input = Console.ReadLine();
                string pattern = @"^[2-9]\d{2}-\d{3}-\d{4}$";
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("Correcto");
                    flag = true;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    flag = false;
                }
            } while (flag == false);
        }
    }
}
