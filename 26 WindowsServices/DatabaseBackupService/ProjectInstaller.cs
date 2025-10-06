using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace DatabaseBackupService
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		public ProjectInstaller()
		{
			InitializeComponent();

            // Process installer: defines the account type
            ServiceProcessInstaller processInstaller = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem // Runs under LocalSystem (can access SQL if local)
            };

            // Service installer: defines metadata
            ServiceInstaller serviceInstaller = new ServiceInstaller
            {
                ServiceName = "DatabaseBackupService",
                DisplayName = "My Database Backup Service",
                Description = "Periodically backs up an MS SQL Server database to the configured folder...",
                StartType = ServiceStartMode.Automatic,

                // Dependencies: ensure SQL Server is running first
                
                ServicesDependedOn = new string[] { "MSSQL$AMSSQLSERVER", "RpcSs", "EventLog" }
            };

            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
	}
}
