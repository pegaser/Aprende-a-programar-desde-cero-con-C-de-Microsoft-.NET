using System;
using System.Linq;

namespace UsingLinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };
            //var result = from d in data
            //             where d % 2 == 0
            //             select d;

            var result = data.Where(d => d % 2 == 0);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            result = from d in data
                     where d > 5
                     orderby d descending
                     select d;
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();

            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };
            result = from d1 in data1
                         from d2 in data2
                         select d1 * d2;
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();
        }
    }
}
