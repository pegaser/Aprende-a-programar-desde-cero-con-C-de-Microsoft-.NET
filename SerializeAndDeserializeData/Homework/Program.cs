using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializa tu objeto con datos de prueba

            using (Stream stream = new FileStream//...
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Bicycle), new Type[] //Recuerda agregar los tipos que se usan
                //Serializa el objeto
            }
        }
    }
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public int WheelsNumber { get; set; }
    }
    public class Car : Vehicle
    {
        public string PlateNumber { get; set; }
    }
    public class Bicycle : Vehicle
    {
        public string Type { get; set; }
    }
}
