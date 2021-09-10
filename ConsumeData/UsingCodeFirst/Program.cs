using System;
using System.Data.Entity;
using System.Linq;

namespace UsingCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (PetsContext ctx = new PetsContext())
            //{
            //    ctx.Pets.Add(new Pet() { Id = 1, Name = "Firulais", Breed = "Chihuahua" });
            //    ctx.SaveChanges();
            //}
            //using (PetsContext ctx = new PetsContext())
            //{
            //    Pet pet = ctx.Pets.SingleOrDefault(p => p.Id == 1);
            //    Console.WriteLine(pet.Name);
            //}

            using (PetsContext ctx = new PetsContext())
            {
                ctx.Pets.Add(new Pet() { Id = 2, Name = "Canelo", Breed = "Sin Raza" });
                ctx.SaveChanges();
            }
            Console.ReadKey();
        }
    }

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Type { get; set; }
    }

    public class PetsContext : DbContext
    {
        public IDbSet<Pet> Pets { get; set; }
        public PetsContext() : base(@"Server=LAPTOP-3NTIOCKV\SQLEXPRESS;Database=MyDataBase;Trusted_Connection=True;")
        {
        }
    }
}
