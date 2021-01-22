using System;
using System.Diagnostics;

namespace AttributesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            [Obsolete]
            [Conditional("DEBUG")]
            static void ShowDebugMessage()
            {
                Console.WriteLine("Estamos en modo DEBUG...");
            }

            Console.WriteLine("Hola mundo!");
            ShowDebugMessage();
            Console.WriteLine("Presiona una tecla para terminar.");
            Console.Read();
        }
        
    }
}
