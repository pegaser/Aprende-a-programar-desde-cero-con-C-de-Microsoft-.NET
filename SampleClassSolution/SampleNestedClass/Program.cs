using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Container.Nested nestedInstance = new Container.Nested();
        }
    }
    class Container
    {
        public class Nested
        {
            // Add code here.
        }
    }

}
