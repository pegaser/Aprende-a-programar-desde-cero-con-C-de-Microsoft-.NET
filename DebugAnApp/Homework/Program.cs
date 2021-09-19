using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
#if MySymbol
            Console.WriteLine("MySymbol mode");
#else
            Console.WriteLine("Not MySymbol");
#endif
            Console.ReadKey();
        }
    }
}
