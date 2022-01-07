using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDelegate
{
    public delegate void DelEventHandler();

    class Program
    {
        public static event DelEventHandler add;

        static void Main(string[] args)
        {
            add += new DelEventHandler(USA);
            add += new DelEventHandler(India);
            add += new DelEventHandler(England);
            add.Invoke();

            add -= new DelEventHandler(USA);
            add -= new DelEventHandler(India);
            add -= new DelEventHandler(England);

            Console.ReadLine();
        }
        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }
    }
}
