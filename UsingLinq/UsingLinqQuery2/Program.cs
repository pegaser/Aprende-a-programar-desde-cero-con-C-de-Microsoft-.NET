using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingLinqQuery2
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyProductA = new Product
            {
                Description = "A",
                Price = 1
            };

            var orders = new List<Order>
            {
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Product = MyProductA,
                            Amount = 3
                        },
                        new OrderLine
                        {
                            Product = MyProductA,
                            Amount = 7
                        },
                        new OrderLine
                        {
                            Product = new Product
                            {
                                Description = "B",
                                Price = 2
                            },
                            Amount = 3
                        }
                    }
                }
            };

            var averageNumberOfOrderLines = orders.Average(o => o.OrderLines.Count);
            Console.WriteLine($"El promedio de ORDERLINES es: {averageNumberOfOrderLines}");
            Console.ReadKey();

            var result = from o in orders
                         from l in o.OrderLines
                         group l by l.Product into p
                         select new
                         {
                             Product = p.Key,
                             Amount = p.Sum(x => x.Amount)
                         };

            var products = new List<Product>
            {
                new Product
                {
                    Description = "A",
                    Price = 1
                },
                new Product
                {
                    Description = "B",
                    Price = 2
                },
                new Product
                {
                    Description = "C",
                    Price = 3
                }
            };
            string[] popularProductNames = { "A", "B" };
            var popularProducts = from p in products
                                  join n in popularProductNames on p.Description equals n
                                  select p;

            int pageSize = 2;
            int pageIndex = 2;
            var pagedOrders = orders.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }

    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderLine
    {
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
    public class Order
    {
        public List<OrderLine> OrderLines { get; set; }
    }

}
