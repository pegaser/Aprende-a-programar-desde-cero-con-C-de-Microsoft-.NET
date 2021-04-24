using System;

namespace UsingComments
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new(7, 11);
            Console.WriteLine(myPoint.GetCoordinates());
            Console.WriteLine(myPoint.GetSimpleCoordinates());
            Console.Read();
        }
    }
    /// <summary>
    /// Representa un punto.
    /// </summary>
    public class Point
    {
        /// <value>Propiedad X correspondientre a la coordenada X</value>
        public int X { get; set; }
        /// <value>Propiedad Y correspondientre a la coordenada Y</value>
        public int Y { get; set; }

        /// <summary>
        /// Constructor de la clase <c>Point</c> que inicializa un nuevo punto a (<paramref name="x"/>,<paramref name="y"/>).
        /// </summary>
        /// <param name="x">Corresponde a la coordenada X del punto.</param>
        /// <param name="y">Corresponde a la coordenada Y del punto.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Obtiene las coordenadas del punto
        /// <example>Por ejemplo:
        /// <code>
        /// Point p = new Point(3,5);
        /// p.GetCoordinates();
        /// </code>
        /// </example>
        /// </summary>
        /// <returns>Una cadena con las coordenadas del punto</returns>
        public string GetCoordinates()
        {
            return $"({X},{Y})";
        }

        /// <summary>
        /// Obtiene las coordenadas del punto.
        /// </summary>
        /// <returns>Una cadena con las coordenadas del punto</returns>
        /// <see cref="GetCoordinates"/>
        public string GetSimpleCoordinates()
        {
            return $"{X},{Y}";
        }
    }
}
