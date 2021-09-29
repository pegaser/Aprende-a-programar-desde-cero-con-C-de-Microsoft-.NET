using System;
using System.Data.Entity;
using System.Linq;

namespace Homework
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
            Console.WriteLine($"¿Cuántos productos por página quieres que se muestren? Existen {productsTotal} productos.");
            if (!int.TryParse(Console.ReadLine(), out pageSize))
            {
                Console.WriteLine("Debes proporcionar una valor entero.");
                Console.ReadKey();
                return;
            }

            using (ProductContext context = new ProductContext())
            {
                for (pageIndex = 1; pageIndex <= (productsTotal / pageSize) + 1; pageIndex++)
                {
                    ///var pagedProducts = context.Products.ToList().Skip(...
                    foreach//...
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
                //Agregar funcionalidad faltante
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
