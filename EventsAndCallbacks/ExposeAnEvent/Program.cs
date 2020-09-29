using System;

namespace ExposeAnEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
            Console.Read();
        }
    }
    public class Pub
    {
        public event Action OnChange = delegate { };
        public void Raise()
        {
            OnChange();
        }
    }
}
