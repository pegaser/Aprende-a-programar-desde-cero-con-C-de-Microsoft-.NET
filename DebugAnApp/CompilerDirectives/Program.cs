#define MySymbol
using System;

namespace CompilerDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
            //#warning This code is obsolete
            //#if DEBUG
            //#error Debug build is not allowed
            //#endif

#line 200 "OtherFileName"
            int a = 1;
#line default
            int b = 2;
#line hidden
            int c = 3;
#line default
            int d = 4;

#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore
            DebugDirective();
            UseCustomSymbol();
            SomeMethod();

            Person myPerson = new Person();
            myPerson.FirstName = "Sergio";
            myPerson.LastName = "Pérez";
            Console.Read();
        }
        static void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
        Console.WriteLine("Not debug");
#endif
        }
        static void UseCustomSymbol()
        {
#if MySymbol
            Console.WriteLine("Custom symbol is defined");
#endif
        }

        static void SomeMethod()
        {
            Log("Step1");
        }

        [System.Diagnostics.Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    [System.Diagnostics.DebuggerDisplay("Name = {FirstName}{LastName}")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
