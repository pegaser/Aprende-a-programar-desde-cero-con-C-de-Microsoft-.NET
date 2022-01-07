using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //A.B b = new A.B();
            //Console.WriteLine(b.GetValue());
            //Console.ReadKey();

            //D d = new D();
            //d.value



        }
    }

    //public class F
    //{
    //    internal int value = 10;

    //}

    //public class G : F
    //{
    //    public int GetValue()
    //    {
    //        return this.value;
    //    }
    //}
    //public class D
    //{
    //    protected int value = 10;

    //}

    //public class E : D
    //{
    //    public int GetValue()
    //    {
    //        return this.value;
    //    }
    //}

    //public class A
    //{
    //    private int value = 10;

    //    public class B : A
    //    {
    //        public int GetValue()
    //        {
    //            return this.value;
    //        }
    //    }
    //}

    //public class C : A
    //{
    //    public int GetValue()
    //    {
    //        return this.value;
    //    }
    //}

    public class A
    {
        public void Method1()
        {
            // Method implementation.
        }
    }

    public class B : A
    { }

    public class Example
    {
        public static void Main()
        {
            B b = new B();
            b.Method1();
        }
    }


}
