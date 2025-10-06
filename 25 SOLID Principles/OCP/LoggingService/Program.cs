using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingService
{
	public class LoggingService
	{
		ILogging _Logger;

        public LoggingService(ILogging logger)
        {
            _Logger = logger;
        }

        public void Log(string message)
		{
			_Logger.Log(message);
		}

	}

    public interface ILogging
    {
		 void Log(string message);
    }
    public class FileLoggingService:ILogging
	{
		// Method to log to file
		public void Log(string message)
		{
			Console.WriteLine($"\nLog to file: {message}");
		}
	}

	public class EventLoggingService:ILogging
	{
		// Method to log to EventLog
		public void Log(string message)
		{
			Console.WriteLine($"\nLog to Event Log: {message}");
		}
	}

	public class DatabaseLoggingService:ILogging
	{
		// Method to log to file
		public void Log(string message)
		{
			Console.WriteLine($"\nLog to Database: {message}");
		}

	}

	public class ExcelLoggingService : ILogging
	{
		// Method to log to file
		public void Log(string message)
		{
			Console.WriteLine($"\nLog to Excel: {message}");
		}

	}

	class Program
	{
		static void Main()
		{
			// Create an instance of the LoggingService
			LoggingService LoggingService = new LoggingService(new FileLoggingService());

			// Log to File
			LoggingService.Log("Error Occured line xxx.");
			// Log to Event Log

			LoggingService = new LoggingService(new EventLoggingService());
			LoggingService.Log("Error Occured line xxx.");
			// Log to Database
			LoggingService = new LoggingService(new DatabaseLoggingService());
			LoggingService.Log("Error Occured line xxx.");

			LoggingService = new LoggingService(new ExcelLoggingService());
			// Log to Database
			LoggingService.Log("Error Occured line xxx.");

			Console.ReadKey();

		}
	}
}
