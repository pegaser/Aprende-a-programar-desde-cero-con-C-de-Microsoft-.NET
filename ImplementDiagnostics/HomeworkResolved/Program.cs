using System;
using System.Diagnostics;

namespace HomeworkResolved
{
    class Program
    {
        static void Main(string[] args)
        {
            if (EventLog.SourceExists("HomeworkEventLogSource"))
            {
                Console.WriteLine("Ya existe EventSource...");
            }
            else
            {
                EventLog.CreateEventSource("HomeworkEventLogSource", "HomeworkEventLog");
                Console.WriteLine("Creando EventSource...");
            }

            EventLog myLog = new EventLog();
            myLog.Source = "HomeworkEventLogSource";

            Console.WriteLine("Proporciona un texto para un WARNING");
            myLog.WriteEntry(Console.ReadLine(), EventLogEntryType.Warning);

            Console.WriteLine("Proporciona un texto para un ERROR");
            myLog.WriteEntry(Console.ReadLine(), EventLogEntryType.Error);

            Console.WriteLine("Proporciona un texto para un INFORMATION");
            myLog.WriteEntry(Console.ReadLine(), EventLogEntryType.Information);

            Console.WriteLine("Revisa tu Event Viewer.");
            Console.ReadKey();
        }
    }
}
