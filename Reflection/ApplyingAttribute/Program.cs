using System;

namespace ApplyingAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
            {
                Console.WriteLine("Person tiene definido el atributo 'Serializable'.");
                Console.Read();
            }
        }
    }
    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
