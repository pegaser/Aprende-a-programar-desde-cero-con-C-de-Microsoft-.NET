using System;
using System.IO;
using System.Xml.Serialization;

namespace UsingXmlSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Person p = new Person
                {
                    FirstName = "Sergio",
                    LastName = "Pérez",
                    Age = 42
                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }
            Console.WriteLine(xml);
            Console.ReadKey();

            using (StringReader stringReader = new StringReader(xml))
            {
                Person p = (Person)serializer.Deserialize(stringReader);
                Console.WriteLine($"{p.FirstName} {p.LastName} tiene {p.Age} años");
            }
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

}
