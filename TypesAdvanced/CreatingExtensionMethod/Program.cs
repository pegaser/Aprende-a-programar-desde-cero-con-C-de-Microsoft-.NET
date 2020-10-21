using System;

namespace CreatingExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Price = 100;

            Calculator calc = new Calculator();
            Console.WriteLine($"Precio original: {product.Price}");
            Console.WriteLine($"Precio con descuento: {calc.CalculateDiscount(product)}");
            Console.Read();
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }
    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }
    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
