using System;
using Xunit;

namespace UsingCategoryAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [Fact]
        [Trait("Category", "Unit Test")]
        public void MyUnitTest()
        { }

        [Fact]
        [Trait("Category", "Integration Test")]
        public void MyIntegrationTest()
        { }

    }
}
