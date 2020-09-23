using System;

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MulticastClass multicastClass = new MulticastClass();
            multicastClass.Multicast();
            Console.Read();
        }
    }
    class MulticastClass
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
        public delegate void Del();
        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();
        }
    }
}
