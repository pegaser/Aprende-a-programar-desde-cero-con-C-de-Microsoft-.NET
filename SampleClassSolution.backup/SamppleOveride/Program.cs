using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamppleOveride
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class A
    {
        public virtual void VirtualMethod()
        {
            //Código del método
        }

        public void NotVirtualMethod()
        {
            //Código del método
        }
    }

    public class B : A
    {
        public override void VirtualMethod()
        {
            //Código que sustituye al código base
        }

        public override void NotVirtualMethod()
        {
            //Código que sustituye al código base
        }

    }
}
