using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace HomeworkResolvedClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Stream stream = new FileStream(@"C:\Temp\homework.json", FileMode.Open))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Bicycle), new Type[] { typeof(Vehicle) });
                Bicycle deserializePerson = (Bicycle)jsonSerializer.ReadObject(stream);
                Console.WriteLine($"Se deserializó objeto Bicycle ID={deserializePerson.Id} Make={deserializePerson.Make} Type={deserializePerson.Type}");
                Console.ReadKey();
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
    public class Bicycle : Vehicle
    {
        public string Type { get; set; }
    }
}
