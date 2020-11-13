using System;
using System.Collections.Generic;

namespace ImplementingIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
             new Order { Created = new DateTime(2020, 12, 1 )},
             new Order { Created = new DateTime(2020, 9, 13 )},
             new Order { Created = new DateTime(2020, 7, 19 )},
             new Order { Created = new DateTime(2020, 3, 22 )},
            };
            orders.Sort();
            foreach (Order item in orders)
            {
                Console.WriteLine(item.Created);
            }
            Console.Read();
        }
    }
    class Order : IComparable
    {
        public DateTime Created { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Order o = obj as Order;
            if (o == null)
            {
                throw new ArgumentException("El objeto no es del tipo Order");
            }
            return this.Created.CompareTo(o.Created);
        }
    }
}
