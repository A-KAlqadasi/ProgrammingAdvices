using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

namespace LoggerExample
{
    public class Logger
    {
        // define a delegate for log actions
        public delegate void LogAction(string message);
        
        // the log function that will be invoked!
        LogAction _logAction;

        public Logger(LogAction logAction)
        {
            _logAction = logAction;
        }

        public void Log(string message) 
        {
            _logAction(message);   
        }

    }


    internal class Program
    {

        public static void LogToScreen(string message) 
        {
            Console.WriteLine(message);
        }

        public static void LogToDatabase(string message)
        {
            Console.WriteLine(message);
            // write the code that add the log message to database
        }

        public static void LogToFile(string message)
        {
            string fileName = "log.txt";
            using (StreamWriter writer = new StreamWriter(fileName,true))
            {
                writer.WriteLine(message);
            }
        }

        static void Main(string[] args)
        {
            Logger screenLogger = new Logger(LogToScreen);
            Logger DBLogger = new Logger(LogToDatabase);
            Logger fileLogger = new Logger(LogToFile);

            screenLogger.Log("This log will be printed on the screen");
            DBLogger.Log("This log will be added into the database");
            fileLogger.Log("This log will be logged into the file");


            Console.ReadKey();

        }
    }
}
