using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace UsingBlockingCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            
            Task read = Task.Run(() =>
            {
                foreach (string item in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) 
                        break;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}
