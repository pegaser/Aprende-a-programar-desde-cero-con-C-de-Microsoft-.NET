using System;
using System.Threading;

namespace ThreadClassExample
{
    public class ThreadStaticAttributeExample
    {
      
        public static int _field;
        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine($"Hilo A: {_field}");
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine($"Hilo B: {_field}");
                }
            }).Start();
            Console.ReadKey();
        }
    }
}
