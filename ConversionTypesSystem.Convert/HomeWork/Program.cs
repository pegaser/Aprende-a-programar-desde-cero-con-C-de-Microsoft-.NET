using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al generador de números aleatorios");
            Console.WriteLine("Deberás proporcionar un rango entre el cual estará el valor aleatorio");
            Console.WriteLine("¿Cuál es el valor mínimo del rango? Debe ser entero");
            string minRange = Console.ReadLine();
            Console.WriteLine("¿Cuál es el valor máximo del rango? Debe ser entero");
            string maxRange = Console.ReadLine();

            Random random = new Random();
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Tu número aleatorio es: {random.Next(Convert.ToInt32(minRange), Convert.ToInt32(maxRange))}");
            }
            catch(FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Los datos proporcionados no tienen el formato correcto, deben ser números enteros.");
            }
            catch(OverflowException ofEx)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Algún dato proporcionado es muy grande.");
            }
            Console.Read();
        }
    }
}
