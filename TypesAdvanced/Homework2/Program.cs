using System;

namespace Homework2
{
    class Vehicle
    {
        public double Distance { get; set; }
        public double Hour { get; set; }

        public Vehicle(double distance, double hour)
        {
            this.Distance = distance;
            this.Hour = hour;
        }

        public virtual void Speed()
        {
            double speed = 0.0;
            speed = Distance / Hour;
            Console.WriteLine($"La velocidad del vehículo es {speed:0.00} Km/H");
        }
    }
    class Car : Vehicle
    {
        public Car(double distance, double hour) : base(distance, hour)
        {
        }
        public override void Speed()
        {
            double speed = 0.0;
            speed = Distance / Hour;
            Console.WriteLine($"La velocidad del carro es {speed:0.00} Km/H");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 0, hour = 0;
            try
            {
                Console.WriteLine("Proporcione la distancia recorrida (en KM):");
                distance = Double.Parse(Console.ReadLine());

                Console.WriteLine("Proporcione el tiempo transcurrido (en horas):");
                hour = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Datos proporcionados incorrectos.");
                Console.ReadKey();
                return;
            }

            Vehicle vehicle = new Vehicle(distance, hour);
            vehicle.Speed();

            Car objCar = new Car(distance, hour);
            objCar.Speed();

            Console.ReadKey();
        }
    }
}
