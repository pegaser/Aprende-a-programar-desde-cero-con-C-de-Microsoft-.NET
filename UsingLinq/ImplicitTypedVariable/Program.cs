using System;
using System.Collections.Generic;
using System.IO;

namespace ImplicitTypedVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 42;
            var m = new MemoryStream();
            string s = i + m; // Esta línea da un error de compilación

            Dictionary<string, IEnumerable<int>> data = new Dictionary<string, IEnumerable<int>>();
            var implicitData = new Dictionary<string, IEnumerable<int>>();

            var whatsMyType = GetData();
        }
    }
}
