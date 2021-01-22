using System;

namespace BasicExampleReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            System.Type type = i.GetType();
            Console.Write(type.FullName);
            Console.Read();
        }
    }
}
