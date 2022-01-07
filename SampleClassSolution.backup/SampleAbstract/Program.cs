using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
    public abstract class A
    {
        public abstract void Method1()
        {
            //Código del método
        }
    }

    public class B : A
    {
        public void Method3()
        {
            //Código del método
        }
    }

    public class C : A
    {
        public override void Method1()
        {
            throw new NotImplementedException();
        }
    }
}
