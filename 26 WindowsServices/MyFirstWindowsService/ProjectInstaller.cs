using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace MyFirstWindowsService
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : Installer
	{
		private ServiceProcessInstaller serviceProcessInstaller;
		private ServiceInstaller serviceInstaller;

        public ProjectInstaller()
		{
			InitializeComponent();
			serviceProcessInstaller = new ServiceProcessInstaller
			{
				Account = ServiceAccount.LocalService
            };

			serviceInstaller = new ServiceInstaller
			{
				ServiceName = "MyFirstWindowsService",
				DisplayName = "My First Windows Service",
				StartType = ServiceStartMode.Manual
            };

			Installers.Add(serviceProcessInstaller);
			Installers.Add(serviceInstaller);
        }
	}
}
