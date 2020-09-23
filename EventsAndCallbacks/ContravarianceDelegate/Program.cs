using System.IO;

namespace ContravarianceDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Contravariance
    {
        void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);
        public void UsingContravariance()
        {
            ContravarianceDel del = DoSomething;
        }
    }
}
