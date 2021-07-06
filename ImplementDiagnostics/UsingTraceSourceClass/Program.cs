using System.Diagnostics;

namespace UsingTraceSourceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
            traceSource.TraceInformation("Tracing application..");
            traceSource.TraceEvent(TraceEventType.Information, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });
            traceSource.Flush();
            traceSource.Close();
        }
    }
}
