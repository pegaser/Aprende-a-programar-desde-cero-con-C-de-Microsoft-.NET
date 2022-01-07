using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleImplicitHeritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleClass = new SimpleClass();
            Console.WriteLine(simpleClass.ToString());
            Console.Read();
        }
    }
    public class SimpleClass
    {

    }
}
