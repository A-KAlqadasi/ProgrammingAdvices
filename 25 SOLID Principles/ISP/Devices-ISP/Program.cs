using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_ISP
{

	public interface ICallDevice
	{
		void MakeCall();

	}

	public interface IPhotoDevice
	{
		void TakePhoto();
	}

	public interface IEmailDevice
	{
		void SendEmail();
	}

	public interface IGPSDevice
	{
		void UseGPS();
	}

	public interface ISmartPhone: ICallDevice, IPhotoDevice, IEmailDevice, IGPSDevice
	{

	}

	public class Smartphone : ISmartPhone
	{
		public void MakeCall()
		{
			Console.WriteLine("Making a call.");
		}

		public void TakePhoto()
		{
			Console.WriteLine("Taking Photo.");
		}

		public void SendEmail()
		{
			Console.WriteLine("Sending an email.");
		}

		
		public void UseGPS()
		{
			Console.WriteLine("Using GPS.");
		}
	}

	public class Computer : IEmailDevice
	{
		

		public void SendEmail()
		{
			Console.WriteLine("Sending an email.");
		}
	}

	public class NormalCamera:IPhotoDevice
	{
		public void TakePhoto()
		{
            Console.WriteLine("Take photo");
        }
	}

	public interface IAdvancedCamera:IPhotoDevice,IEmailDevice
	{

	}
	public class AdvancedCamera:IAdvancedCamera
	{
		public void TakePhoto()
		{
			Console.WriteLine("Take photo");
		}

		public void SendEmail()
		{
			Console.WriteLine("Sending an email.");
		}

	}


	public class Program
	{
		public static void Main()
		{
			Smartphone smartphone = new Smartphone();
			Console.WriteLine("SmartPhone:");
			smartphone.MakeCall();
			smartphone.TakePhoto();
			smartphone.SendEmail();
			smartphone.UseGPS();

			Computer computer = new Computer();
			Console.WriteLine("\nComputer:");
			computer.SendEmail();

            Console.WriteLine("\nNormal camera");
            NormalCamera normalCamera = new NormalCamera();
			normalCamera.TakePhoto();

			Console.WriteLine("\nAdvanced camera");
			AdvancedCamera advancedCamera = new AdvancedCamera();
			advancedCamera.TakePhoto();
			advancedCamera.SendEmail();

			Console.ReadKey();


		}
	}

}
