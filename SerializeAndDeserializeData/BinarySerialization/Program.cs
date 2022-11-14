using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
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
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(@"C:\Temp\data.bin", FileMode.Create))
            {
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                formatter.Serialize(stream, person);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            Console.WriteLine("Se serializó objeto en el archivo data.bin");
            Console.ReadKey();

            using (Stream stream = new FileStream(@"C:\Temp\data.bin", FileMode.Open))
            {
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                Person deserializePerson = (Person)formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                Console.WriteLine($"Se deserializó objeto Person ID={deserializePerson.Id} Name={deserializePerson.Name}");
                Console.ReadKey();
            }

            PersonComplex personcomplex = new PersonComplex
            {
                Id = 1,
                Name = "Sergio Pérez"
            };
            formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(@"C:\Temp\data.bin", FileMode.Create))
            {
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                formatter.Serialize(stream, personcomplex);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            Console.WriteLine("Se serializó objeto en el archivo data.bin");
            Console.ReadKey();

            using (Stream stream = new FileStream(@"C:\Temp\data.bin", FileMode.Open))
            {
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                PersonComplex deserializePersonComplex = (PersonComplex)formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                Console.WriteLine($"Se deserializó objeto Person ID={deserializePersonComplex.Id} Name={deserializePersonComplex.Name}");
                Console.ReadKey();
            }
        }
    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NonSerialized]
        private bool isDirty = false;
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            Console.WriteLine("Serializando objeto.");
        }
        [OnSerialized()]
        internal void OnSerializedMethod(StreamingContext context)
        {
            Console.WriteLine("Objeto serializado.");
        }
        [OnDeserializing()]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            Console.WriteLine("Deserializando objeto.");
        }
        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            Console.WriteLine("Objeto deserializado.");
        }
    }

    [Serializable]
    public class PersonComplex : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private bool isDirty = false;
        public PersonComplex() { }
        protected PersonComplex(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Value1");
            Name = info.GetString("Value2");
            isDirty = info.GetBoolean("Value3");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Value1", Id);
            info.AddValue("Value2", Name);
            info.AddValue("Value3", isDirty);
        }
    }
}
