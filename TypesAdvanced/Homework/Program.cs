using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static List<T> GetInitializedList<T>(T value, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }

        static void Main()
        {
            List<bool> list1 = GetInitializedList<bool>(true, 7);
            List<string> list2 = GetInitializedList<string>("C#", 3);
            foreach (bool value in list1)
            {
                Console.WriteLine(value);
            }
            foreach (string value in list2)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
