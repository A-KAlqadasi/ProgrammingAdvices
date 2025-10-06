using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileMonitoringService
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
            if (Environment.UserInteractive)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("File Monitoring Service-Run in Console Mode ");
                Console.WriteLine("=============================================");

                FileMonitoringService service = new FileMonitoringService();
                service.StartInConsolse();
            }
            else
			{
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new FileMonitoringService()
                };
                ServiceBase.Run(ServicesToRun);
            }
			
		}
	}
}
