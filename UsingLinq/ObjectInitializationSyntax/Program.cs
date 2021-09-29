using System;
using System.Collections.Generic;

namespace ObjectInitializationSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstName = "Sergio",
                LastName = "Pérez"
            };

            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "Sergio",
                    LastName = "Pérez"
                },
                new Person
                {
                    FirstName = "Alejandro",
                    LastName = "Pérez"
                }
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
