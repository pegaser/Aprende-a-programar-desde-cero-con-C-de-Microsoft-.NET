using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usamos la clase base para el tipo de nuestra colección LIST
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };
            
            //Invocamos el método sobreestito de cada objeto.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.Read();
        }
    }
}
