using System;
using System.Reflection;

namespace ExecutingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 42 });
            if (result > 0)
            {
                Console.WriteLine($"{i} es mayor que 42");
            }
            else if (result < 0)
            {
                Console.WriteLine($"{i} es menor que 42");
            }
            else
            {
                Console.WriteLine($"{i} es igual que 42");
            }
            Console.Read();
        }
    }
}