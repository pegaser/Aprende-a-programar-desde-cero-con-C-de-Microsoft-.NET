using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace HomeworkResolved
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle
            {
                Id = 1,
                Make = "México",
                Year = 2020,
                WheelsNumber = 2,
                Type = "Eléctrica"
            };
            using (Stream stream = new FileStream(@"C:\Temp\homework.json", FileMode.Create))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Bicycle), new Type[] { typeof(Vehicle)});
                jsonSerializer.WriteObject(stream, bicycle);
            }
            Console.WriteLine("Se serializó objeto en el archivo homework.json");
            Console.ReadKey();
        }
    }

    [DataContract]
    public class Vehicle
    {
        [DataMember]
        public int Id { get; set; }
        public string Make { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int WheelsNumber { get; set; }
    }
    public class Car : Vehicle
    {
        public string PlateNumber { get; set; }
    }
    [DataContract]
    public class Bicycle : Vehicle
    {
        [DataMember]
        public string Type { get; set; }
    }
}
