using System;

namespace SamplePolymorphism
{
    public class Shape
    {
        // Unos poco miembros de ejemplo
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Método Virtual 
        public virtual void Draw()
        {
            Console.WriteLine("Ejecuntando el método DRAW de la clase base.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // Código para dibujar un círculo...
            Console.WriteLine("Dibujando un círculo.");
            base.Draw();
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Código para dibujar un rectángulo...
            Console.WriteLine("Dibujando un rectángulo.");
            base.Draw();
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            // Código para dibujar un triángulo...
            Console.WriteLine("Dibujando un triángulo.");
            base.Draw();
        }
    }
}
