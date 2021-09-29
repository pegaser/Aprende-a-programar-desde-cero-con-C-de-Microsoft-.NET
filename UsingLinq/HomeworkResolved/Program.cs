using System;
using System.Data.Entity;
using System.Linq;

namespace HomeworkResolved
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliminando productos...");
            RemoveExampleProducts();

            Console.WriteLine("Agregando productos...");
            AddExampleProducts();

            int pageSize, pageIndex, productsTotal = ProductsNumber();
            Console.WriteLine($"¿Cuánto productos por página quieres que se muestren? Existen {productsTotal} productos.");
            if(!int.TryParse(Console.ReadLine(), out pageSize))
            {
                Console.WriteLine("Debe proporcionar una valor entero.");
                Console.ReadKey();
                return;
            }

            using (ProductContext context = new ProductContext())
            {
                for (pageIndex = 1; pageIndex <= (productsTotal / pageSize) + 1; pageIndex++)
                {
                    var pagedProducts = context.Products.ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize);
                    foreach (var item in pagedProducts)
                    {
                        Console.WriteLine($"{item.Id}, {item.Description}, {item.Price}");
                    }
                    Console.ReadKey();
                }
            }
        }

        static void RemoveExampleProducts()
        {
            using (ProductContext context = new ProductContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
                context.SaveChanges();
            }
        }

        static void AddExampleProducts()
        {
            using (ProductContext context = new ProductContext())
            {
                context.Products.Add(new Product() { Id = 1, Description = "Galletas", Price = (decimal)12.5 });
                context.Products.Add(new Product() { Id = 2, Description = "Refresco", Price = (decimal)22 });
                context.Products.Add(new Product() { Id = 3, Description = "Palomitas", Price = (decimal)13.5 });
                context.Products.Add(new Product() { Id = 4, Description = "Chocolate", Price = (decimal)11 });
                context.Products.Add(new Product() { Id = 5, Description = "Chicle", Price = (decimal)3.5});
                context.Products.Add(new Product() { Id = 6, Description = "Dulce", Price = (decimal)29.5 });
                context.Products.Add(new Product() { Id = 7, Description = "Papas", Price = (decimal)50.5 });
                context.SaveChanges();
            }
        }
        static int ProductsNumber()
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Products.Count();
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductContext : DbContext
    {
        public IDbSet<Product> Products { get; set; }
        public ProductContext() : base(@"Server=LAPTOP-3NTIOCKV\SQLEXPRESS;Database=MyLinq;Trusted_Connection=True;")
        {

        }
    }
}
