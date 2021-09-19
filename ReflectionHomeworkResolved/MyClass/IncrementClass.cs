using System;

namespace MyClass
{
    public class IncrementClass
    {
        public int Index { get; set; }
        public void Increment()
        {
            Index++;
        }
        public void Decrement(int value)
        {
            Index= Index-value;
        }
    }
}
