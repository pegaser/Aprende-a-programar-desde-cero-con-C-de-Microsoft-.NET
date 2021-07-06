using System;
using System.Diagnostics;

namespace ReadingDataFromEventLog_
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog log = new EventLog("WritingDataToEventLog_Log");
            Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            Console.WriteLine("Index:   " + last.Index);
            Console.WriteLine("Source:  " + last.Source);
            Console.WriteLine("Type:    " + last.EntryType);
            Console.WriteLine("Time:    " + last.TimeWritten);
            Console.WriteLine("Message: " + last.Message);
            Console.Read();
        }
    }
}
