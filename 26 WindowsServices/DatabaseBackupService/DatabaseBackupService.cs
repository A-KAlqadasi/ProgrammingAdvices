using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DatabaseBackupService
{
	public partial class DatabaseBackupService : ServiceBase
	{
        private Timer backupTimer;
        private string connectionString;
        private string backupFolder;
        private string logFolder;
        private int backupIntervalMinutes;
     
        public DatabaseBackupService()
		{
			InitializeComponent();

            // Read folder paths from App.config
            backupFolder = ConfigurationManager.AppSettings["BackupFolder"];
            logFolder = ConfigurationManager.AppSettings["LogFolder"];
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            if (string.IsNullOrWhiteSpace(logFolder))
            {
                logFolder = @"C:\DatabaseBackups\Logs"; // Default log folder
                Log("LogFolder is missing in App.config. Using default: " + logFolder);
            }

            backupIntervalMinutes = int.TryParse(ConfigurationManager.AppSettings["BackupIntervalMinutes"], out int interval) ? interval : 60;
            
            // Handle missing or empty configuration values
            if (string.IsNullOrWhiteSpace(backupFolder))
            {
                backupFolder = @"C:\DatabaseBackups"; // Default source folder
                Log("Backup folder is missing in App.config. Using default: " + backupFolder);
            }

            
            // Ensure directories exist
            Directory.CreateDirectory(backupFolder);
            Directory.CreateDirectory(logFolder);
        }

        protected override void OnStart(string[] args)
		{
            try
            {
                Log("Service Started");

                backupTimer = new Timer(backupIntervalMinutes * 60 * 1000); // interval in ms
                backupTimer.Elapsed += OnBackupTimerElapsed;
                backupTimer.AutoReset = true;
                backupTimer.Start();

                // run first backup immediately
                BackupDatabase();
            }
            catch (Exception ex)
            {
                Log("Error in OnStart: " + ex.Message);
            }
        }

		private void OnBackupTimerElapsed(object sender, ElapsedEventArgs e)
		{
            BackupDatabase();
		}

		protected override void OnStop()
		{
            Log("Service Stopped");
            if (backupTimer != null)
            {
                backupTimer.Stop();
                backupTimer.Dispose();
            }

        }

        private void BackupDatabase()
        {
            try
            {
                string databaseName;
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    databaseName = conn.Database; // take DB name from connection string
                }

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string backupFileName = $"{databaseName}_{timestamp}.bak";
                string backupPath = Path.Combine(backupFolder, backupFileName);

                string sql = $"BACKUP DATABASE [{databaseName}] TO DISK='{backupPath}' WITH INIT";

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandTimeout = 0; // allow long backups
                        cmd.ExecuteNonQuery();
                    }
                }

                Log($"Backup completed for database '{databaseName}' at {backupPath}");
            }
            catch (Exception ex)
            {
                Log("Error during backup: " + ex.Message);
            }
        }


        private void Log(string message)
        {
            string logFile = Path.Combine(logFolder, "BackupLog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt");
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n";

            File.AppendAllText(logFile, logMessage);

            // Output to console if running in debug mode
            if (Environment.UserInteractive)
            {
                Console.WriteLine(logMessage);
            }
        }

        public void StartInConsole()
        {
            OnStart(null);
            Console.WriteLine("Press Enter to stop the service...");
            Console.ReadLine();

            OnStop();

        }
    }
}
