using System;
using System.Linq;

namespace UsingDelegatesEasy
{
    class Program
    {
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            Func<string, string> rev = ReverseString;

            Console.WriteLine(rev("Una Cadena cualquiera."));

            Console.Read();
        }

        //public delegate string Reverse(string s);

        //static string ReverseString(string s)
        //{
        //    return new string(s.Reverse().ToArray());
        //}

        //static void Main(string[] args)
        //{
        //    Reverse rev = ReverseString;
        //    Console.WriteLine(rev("Una Cadena cualquiera."));
        //    Console.Read();
        //}
    }
}
