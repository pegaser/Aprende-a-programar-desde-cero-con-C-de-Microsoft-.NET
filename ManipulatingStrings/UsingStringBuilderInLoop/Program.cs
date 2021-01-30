using System;
using System.Text;

namespace UsingStringBuilderInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder(string.Empty);
            //for (int i = 0; i < 10000; i++)
            //{
            //    sb.Append('x');
            //}
            //Console.WriteLine($"Terminé con sb = {sb}");
            //Console.ReadLine();

            var s = new String('X', 10000);
            Console.WriteLine($"s = {s}");
            Console.Read();
        }
    }
}
