using System;
using System.Collections.Generic;

namespace AnonymousDelegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);
            }

            List<int> result = list.FindAll(i => i % 2 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        //public static void Main(string[] args)
        //{
        //    List<int> list = new List<int>();

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        list.Add(i);
        //    }

        //    List<int> result = list.FindAll(
        //      delegate (int no)
        //      {
        //          return (no % 2 == 0);
        //      }
        //    );

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.Read();
        //}
    }
}
