using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            Customer customer2 = customer1;
        }
    }

    public class Customer
    {

    }
}
