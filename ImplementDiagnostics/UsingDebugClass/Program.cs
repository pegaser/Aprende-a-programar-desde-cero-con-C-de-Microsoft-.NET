using System;
using System.Diagnostics;

namespace UsingDebugClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 4);
            Debug.WriteLineIf(i > 0, "i is greater than 0");
            Console.ReadKey();
        }
    }
}
