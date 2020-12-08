using System;

namespace InheritanceExercise
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.FullName = "Sergio Pérez";
            employee.Age = 40;
            employee.EmployeeId = 123456;
            employee.GetData();
            Console.Read();
        }
    }

    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public virtual void GetData()
        {
            Console.WriteLine($"Full name: {FullName}");
            Console.WriteLine($"Age: {FullName}");
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Employee id: {EmployeeId}");
        }
    }
}
