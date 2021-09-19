using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor introduce un número para dividir 100: ");
            Divide(Console.ReadLine());
            Console.ReadKey();
        }

        static void Divide(string stringNum)
        {
            try
            {
                int num = int.Parse(stringNum);
                int result = 100 / num;
                Console.WriteLine($"100 / {num} = {result}");
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Se ha generado una excepción del tipo {ex.GetType().Name}");
            }
        }
    }
}
