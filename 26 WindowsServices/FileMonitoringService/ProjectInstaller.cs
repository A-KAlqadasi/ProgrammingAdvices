using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace FileMonitoringService
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		public ProjectInstaller()
		{
			InitializeComponent();

            // Define how the service will run
            ServiceProcessInstaller processInstaller = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem // Runs under LocalSystem by default
            };

            // Define service details
            ServiceInstaller serviceInstaller = new ServiceInstaller
            {
                ServiceName = "FileMonitoringService", // must match your ServiceBase.ServiceName
                DisplayName = "File Monitoring Service",
                Description = "Monitors a folder for new files, moves them to destination, and logs events.",
                StartType = ServiceStartMode.Automatic // Starts automatically on boot
            };

            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
	}
}
