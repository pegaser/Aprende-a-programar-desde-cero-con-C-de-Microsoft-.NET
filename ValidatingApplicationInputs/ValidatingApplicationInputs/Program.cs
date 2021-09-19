using System;
using System.Text.RegularExpressions;

namespace ValidatingApplicationInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proporciona una fecha en formato US (MM/dd/aaaa)");
            string input = Console.ReadLine();
            string pattern = @"^(([1-9])|(0[1-9])|(1[0-2]))\/(([0-9])|([0-2][0-9])|(3[0-1]))\/(([0-9][0-9])|([1-2][0,9][0-9][0-9]))$";
            if (Regex.IsMatch(input, pattern))
                Console.WriteLine("Correcto");
            else
                Console.WriteLine("Incorrecto");
            Console.ReadKey();
        }
    }
}
