using System.Collections.Generic;
using System.Linq;

namespace CreatingBaseClass
{
    interface IEntity
    {
        int Id { get; }
    }
    class Repository<T> where T : IEntity
    {
        protected IEnumerable<T> _elements;
        public Repository(IEnumerable<T> elements)
        {
            _elements = elements;
        }
        public T FindById(int id)
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }

    class Order : IEntity
    {
        public int Id { get; }
    }
    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders)
        : base(orders) { }
        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            List<Order> result = null;
            return result;
         }
    }
}
