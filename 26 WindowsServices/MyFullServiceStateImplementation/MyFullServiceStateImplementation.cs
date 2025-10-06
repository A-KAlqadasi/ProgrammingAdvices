using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFullServiceStateImplementation
{
	public partial class MyFullServiceStateImplementation : ServiceBase
	{
		private string logDirectory = string.Empty;
		private string logFileName = string.Empty;
		private string logPath = string.Empty;
		public MyFullServiceStateImplementation()
		{
			InitializeComponent();

            // Set the CanPauseAndContinue property to true
            CanPauseAndContinue = true; //The service supports pausing and resuming operations.

            // Enable support for OnShutdown
            CanShutdown = true; // The service is notified when the system shuts down.


            // Read log directory path from App.config
            //The service reads the log directory path from an external configuration file (App.config) for flexibility.
            logDirectory = ConfigurationManager.AppSettings["LogDirectory"];
            logFileName = ConfigurationManager.AppSettings["LogFile"];

            // Validate and create directory if it doesn't exist
            if (string.IsNullOrWhiteSpace(logDirectory))
            {
                throw new ConfigurationErrorsException("LogDirectory is not specified in the configuration file.");
            }

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            logPath = Path.Combine(logDirectory, logFileName);

        }
        // Log a message to a file with a timestamp
        //The service logs all its state transitions (Start, Stop, Pause, Continue, Shutdown) to a file named ServiceStateLog.txt in the configured directory.
        // Each log entry includes a timestamp for tracking purposes.
        private void LogServiceEvent(string message)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n";
            File.AppendAllText(logPath, logMessage);

            // Print in conosole if running interactively
            if (Environment.UserInteractive)
            {
				Console.WriteLine(logMessage);
            }
        }
        private void LogEvent(string message)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n";
            File.AppendAllText(logPath, logMessage);
        }



        // OnStart Event
        protected override void OnStart(string[] args)
        {
            LogServiceEvent("Service Started");
            // Add initialization logic here


            // Set the current process priority to High
            //Process process = Process.GetCurrentProcess();
            //process.PriorityClass = ProcessPriorityClass.High;

            //LogEvent($"Service Priority Set to: {process.PriorityClass}");


        }


       

        // OnStop Event
        protected override void OnStop()
        {
            LogServiceEvent("Service Stopped");
            // Add cleanup logic here
        }

        // OnPause Event
        protected override void OnPause()
        {
            LogServiceEvent("Service Paused");
            // Add pause logic here
        }

        // OnContinue Event
        protected override void OnContinue()
        {
            LogServiceEvent("Service Resumed");
            // Add resume logic here
        }

        // OnShutdown Event
        protected override void OnShutdown()
        {
            LogServiceEvent("Service Shutdown due to system shutdown");
            // Add shutdown cleanup logic here
        }
        
       
        // this is added, simulate in console 
        public void StartInConsolse()
        {
            
            OnStart(null);
            Console.WriteLine("Press Enter to stop the service:");
            Console.ReadLine();
            OnStop();
            Console.ReadKey();

        }

    }
    
}
