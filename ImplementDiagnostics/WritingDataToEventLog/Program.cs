using System;
using System.Diagnostics;

namespace WritingDataToEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!EventLog.SourceExists("WritingDataToEventLog_Source"))
            {
                EventLog.CreateEventSource("WritingDataToEventLog_Source", "WritingDataToEventLog_Log");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }
            EventLog myLog = new EventLog();
            myLog.Source = "WritingDataToEventLog_Source";
            myLog.WriteEntry("Log event!", EventLogEntryType.);
        }
    }
}
