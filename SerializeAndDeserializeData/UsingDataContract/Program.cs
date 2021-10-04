using System;
using System.IO;
using System.Runtime.Serialization;

namespace UsingDataContract
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDataContract person = new PersonDataContract
            {
                Id = 1,
                Name = "Sergio Pérez"
            };

            using (Stream stream = new FileStream(@"C:\Temp\data.xml", FileMode.Create))
            {
                DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(PersonDataContract));
                dataContractSerializer.WriteObject(stream, person);
            }
            Console.WriteLine("Se serializó objeto en el archivo data.xml");
            Console.ReadKey();

            using (Stream stream = new FileStream(@"C:\Temp\data.xml", FileMode.Open))
            {
                DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(PersonDataContract));
                PersonDataContract deserializePerson = (PersonDataContract)dataContractSerializer.ReadObject(stream);
                Console.WriteLine($"Se deserializó objeto Person ID={deserializePerson.Id} Name={deserializePerson.Name}");
                Console.ReadKey();
            }
        }
    }
    [DataContract]
    public class PersonDataContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        private bool isDirty = false;
    }

}
