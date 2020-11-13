using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesAndBaseClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { Id = 1, Amount = 7 });
            orders.Add(new Order() { Id = 2, Amount = 7 });
            orders.Add(new Order() { Id = 3, Amount = 3 });
            orders.Add(new Order() { Id = 4, Amount = 4 });

            OrderRepository orderRepository = new OrderRepository(orders);
            foreach(Order item in orderRepository.FilterOrdersOnAmount(7))
            {
                Console.WriteLine($"La orden {item.Id} tiene un monto de {item.Amount}");
            }
            Console.Read();
        }
    }
}
