using MyClassLibrary;
using System;
using System.Reflection;

namespace ReflectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            IncrementClass incrementClass = new IncrementClass();
            MethodInfo incrementMethod = incrementClass.GetType().GetMethod("Increment");
            incrementMethod.Invoke(incrementClass, null);
            Console.WriteLine(incrementClass.Index);
            Console.ReadKey();

            incrementMethod.Invoke(incrementClass, null);
            Console.WriteLine(incrementClass.Index);
            Console.ReadKey();
        }
    }
}
