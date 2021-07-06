using System.Diagnostics;
using System.IO;

namespace ConfiguringTraceListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);
            traceSource.TraceInformation("Trace output");
            traceSource.Flush();
            traceSource.Close();
        }
    }
}
