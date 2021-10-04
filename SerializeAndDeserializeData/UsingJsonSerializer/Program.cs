using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace UsingJsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Id = 1,
                Name = "Sergio Pérez"
            };
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person));
                jsonSerializer.WriteObject(stream, person);
                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd());
                Console.ReadKey();

                stream.Position = 0;
                Person personDeserialized = (Person)jsonSerializer.ReadObject(stream);
                Console.WriteLine($"Person deserialized Id='{personDeserialized.Id}' Name='{personDeserialized.Name}'");
                Console.ReadKey();
            }

        }
    }
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

}
