using System;

namespace HomeworkSection3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData;
            double side;
            double squareArea;
            Console.WriteLine("Hola, te proporcionaré el área de un cuadrado.");
            Console.WriteLine("_______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
            Console.WriteLine("¿Cuánto mide un lado del cuadrado?");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out side))
            {
                squareArea = side * side;
                Console.WriteLine($"El área de tú cuadrado es: {squareArea}");
            }
            else
            {
                Console.WriteLine("Los datos proporcionados son incorrectos.");
            }
            Console.ReadKey();
        }
    }
}
