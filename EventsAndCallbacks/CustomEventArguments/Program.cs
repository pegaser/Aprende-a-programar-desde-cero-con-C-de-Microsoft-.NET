using System;

namespace CustomEventArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");
            p.Raise();
            Console.Read();
        }
    }
    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
    public class Pub
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
}
