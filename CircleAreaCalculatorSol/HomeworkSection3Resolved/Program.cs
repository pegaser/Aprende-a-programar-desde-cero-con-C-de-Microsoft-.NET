using System;

namespace HomeworkSection3Resolved
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData;
            double triangleBase;
            double triangleHeight;
            double triangleArea;
            Console.WriteLine("Hola, te proporcionaré el área de un triangulo.");
            Console.WriteLine(@" /\ ");
            Console.WriteLine(@"/__\");
            Console.WriteLine("¿Cuánto mide la base del triángulo?");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out triangleBase))
            {
                Console.WriteLine("¿Cuánto mide la altura del triángulo?");
                userData = Console.ReadLine();
                if (double.TryParse(userData, out triangleHeight))
                {
                    triangleArea = triangleBase * triangleHeight;
                    Console.WriteLine($"El área de tú triángulo es: {triangleArea}");
                }
                else
                {
                    Console.WriteLine("Los datos proporcionados son incorrectos.");
                }
            }
            else
            {
                Console.WriteLine("Los datos proporcionados son incorrectos.");
            }
            Console.ReadKey();
        }
    }
}
