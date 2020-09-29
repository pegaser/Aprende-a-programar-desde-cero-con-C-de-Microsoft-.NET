using System;

namespace CustomEventAccessor
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
    public class Pub
    {
        private event EventHandler<MyArgs> onChange = delegate { };
        public event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }
        public void Raise()
        {
            onChange(this, new MyArgs(42));
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
}
