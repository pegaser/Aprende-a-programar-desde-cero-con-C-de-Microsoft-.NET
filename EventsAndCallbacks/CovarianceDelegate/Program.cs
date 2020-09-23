using System.IO;

namespace CovarianceDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Covariance covariance = new Covariance();
            covariance.UsingCovariance();
        }
    }
    class Covariance
    {
        public delegate TextWriter CovarianceDel();
        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }
        public void UsingCovariance()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
