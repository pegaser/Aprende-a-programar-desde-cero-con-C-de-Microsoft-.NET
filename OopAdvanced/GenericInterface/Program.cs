using System;
using System.Collections.Generic;

namespace GenericInterface
{
    interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }
    
    class Product
    {

    }
    class Order
    {

    }

    class Products : IRepository<Product>
    {
        public IEnumerable<Product> All()
        {
            throw new NotImplementedException();
        }

        public Product FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
    class Orders : IRepository<Order>
    {
        public IEnumerable<Order> All()
        {
            throw new NotImplementedException();
        }

        public Order FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
