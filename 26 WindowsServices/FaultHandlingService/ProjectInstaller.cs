using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace FaultHandlingService
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		private ServiceProcessInstaller processInstaller;
		private ServiceInstaller serviceInstaller;

		public ProjectInstaller()
		{
			InitializeComponent();

            // Instantiate installers for process and service.
            processInstaller = new ServiceProcessInstaller();
            serviceInstaller = new ServiceInstaller();

            // The service runs under the system account.
            processInstaller.Account = ServiceAccount.LocalSystem;

            // The name of the service.
            serviceInstaller.ServiceName = "MyCustomService";

            // Set the display name and description (optional)
            serviceInstaller.DisplayName = "My Custom Service";
            serviceInstaller.Description = "This is a fault handling sample Windows Service.";

            // Set the service start type.
            serviceInstaller.StartType = ServiceStartMode.Manual;

            // Add installers to collection. Order is not important.
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }

	}
}
