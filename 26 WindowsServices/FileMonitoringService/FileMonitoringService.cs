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

namespace FileMonitoringService
{
	public partial class FileMonitoringService : ServiceBase
	{
        private FileSystemWatcher watcher;
        private string sourceFolder;
        private string destinationFolder;
        private string logFolder;
        private string logFile;


        public FileMonitoringService()
		{
			InitializeComponent();

            sourceFolder = ConfigurationManager.AppSettings["SourceFolder"];
            destinationFolder = ConfigurationManager.AppSettings["DestinationFolder"];
            logFolder = ConfigurationManager.AppSettings["LogFolder"];


            if (!Directory.Exists(sourceFolder))
            {
                Directory.CreateDirectory(sourceFolder);
            }

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }


            if (!Directory.Exists(logFolder))
                Directory.CreateDirectory(logFolder);

            logFile = Path.Combine(logFolder, "ServiceLog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt");

        }

        protected override void OnStart(string[] args)
		{
            
            Log("Service Started");

            try
            {
                watcher = new FileSystemWatcher
                {
                    Path = sourceFolder,
                    Filter = "*.*",
                    NotifyFilter = NotifyFilters.FileName | NotifyFilters.CreationTime,
                    EnableRaisingEvents = true
                };

                watcher.Created += OnFileCreated;
            }
            catch (Exception ex)
            {
                Log("Error in OnStart: " + ex.Message);
            }

        }



		protected override void OnStop()
		{
            Log("Service Stopped");
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
        }

        public void StartInConsolse()
        {

            OnStart(null);
            Console.WriteLine("\n\nPress Enter to stop the service:");
            Console.ReadLine();
            OnStop();
            Console.ReadKey();

        }

        private void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            try
            {
                Log($"File detected: [{e.FullPath}]");

                // Wait 2 seconds before processing
                Thread.Sleep(2000);

                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.Name);
                string destinationPath = Path.Combine(destinationFolder, newFileName);


                File.Move(e.FullPath, destinationPath);

                Log($"File moved from [{e.FullPath}] to [{destinationPath}] .");
            }
            catch (Exception ex)
            {
                Log("Error processing file: " + ex.Message);
            }
        }

        private void Log(string message)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - {message}";
                File.AppendAllText(logFile, logEntry + Environment.NewLine);

               
                // Print in conosole if running interactively
                if (Environment.UserInteractive)
                {
                    Console.WriteLine(logEntry);
                }
                
            }
            catch
            {
                // In case logging fails, silently ignore (avoid crashing the service)
            }
        }
    }
}
