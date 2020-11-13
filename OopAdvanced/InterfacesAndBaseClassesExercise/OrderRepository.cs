using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndBaseClassesExercise
{
    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders) : base(orders) 
        { 
        }
        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            List<Order> result = base._elements.Where(e => e.Amount == amount).ToList(); ;
            return result;
        }
    }
}
