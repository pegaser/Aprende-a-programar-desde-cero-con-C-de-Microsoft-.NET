using System;

namespace DefiningTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class MyMethodAndParameterAttribute : Attribute { }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class MyMultipleUsageAttribute : Attribute { }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class CompleteCustomAttribute : Attribute
    {
        public CompleteCustomAttribute(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
    }
}
