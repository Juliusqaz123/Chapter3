using System;
using System.Diagnostics;

namespace Chapter3
{
    class EventLogSample
    {
        public static void Main()
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
            {
                Console.WriteLine(e.Entry.Message);
            };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
