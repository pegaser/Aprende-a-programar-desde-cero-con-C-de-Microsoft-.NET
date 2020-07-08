using InheritanceExercise;
using NUnit.Framework;
using System;
using System.IO;

namespace InheritanceExerciseTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.That(sw.ToString(), Is.EqualTo("Full name: Sergio Pérez\r\nAge: Sergio Pérez\r\nEmployee id: 123456\r\n"));
            }
        }
    }
}