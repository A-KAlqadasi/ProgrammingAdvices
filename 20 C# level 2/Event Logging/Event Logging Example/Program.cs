using System;
using System.Diagnostics;

namespace Event_Logging_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the source name for the event log
            string sourceName = "KokoApp";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }

            

            // Log an information event
            EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);

            EventLog.WriteEntry(sourceName, "This is a warning event:-)", EventLogEntryType.Warning);

            EventLog.WriteEntry(sourceName, "This is an erorr event:-)", EventLogEntryType.Error);


            Console.WriteLine("Event written to the log.");


            Console.Read();
        }
    }
}
