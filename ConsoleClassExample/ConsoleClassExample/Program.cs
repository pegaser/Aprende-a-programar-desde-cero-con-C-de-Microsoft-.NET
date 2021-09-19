using System;

namespace ConsoleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int porcentaje;

            double valor_prod;

            double resultado;

            Console.WriteLine("Proporciona el valor del porcentaje (debe ser entero entre 1 y 100): ");
            if (int.TryParse(Console.ReadLine(), out porcentaje))
            {
                if(porcentaje > 100 || porcentaje < 1)
                {
                    Console.WriteLine("Dato incorrecto, debe ser entero entre 1 y 100.");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Dato incorrecto, debe ser entero.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Proporciona el valor del producto (puede ser con decimales): ");
            if (!double.TryParse(Console.ReadLine(), out valor_prod))
            {
                Console.WriteLine("Dato incorrecto, debe ser un número.");
                Console.ReadKey();
                return;
            }

            resultado = valor_prod - valor_prod * (double)porcentaje / 100;

            Console.WriteLine($"El producto te queda en: {resultado} ");
            Console.ReadKey();
        }
    }
}
