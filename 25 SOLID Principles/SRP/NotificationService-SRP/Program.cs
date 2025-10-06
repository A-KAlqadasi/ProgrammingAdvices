using System;

namespace NotificationService_SRP
{
	public class NotificationSerice
	{
		public enum enNotificationType { EmailService = 1, SMSService = 2, FaxService = 3 }
		public enNotificationType NotificationType;

		public void SendNotificatoin(string to, string message, enNotificationType notificationType)

		{
			if (notificationType == enNotificationType.EmailService)
			{
				EmailService.SendEmail(to, message);
			}
			else if (notificationType == enNotificationType.SMSService)
			{
				SMSService.SendSMS(to, message);
			}
			else if (notificationType == enNotificationType.FaxService)
			{
				FaxService.SendFax(to, message);
			}

		}

	}

	public class EmailService
	{
		public static void SendEmail(string to, string message)
		{
			// here you write the logic for sending Emails
			Console.WriteLine($"Sending Email to: {to} : {message}");
		}
	}

	public class SMSService
	{
		public static void SendSMS(string to, string message)
		{
			// here you write the logic for sending SMS
			Console.WriteLine($"Sending SMS to: {to} : {message}");
		}
	}

	public class FaxService
	{
		public static void SendFax(string to, string message)
		{
			// here you write the logic for sending SMS
			Console.WriteLine($"Sending Fax to: {to} : {message}");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			NotificationSerice notificationSerice = new NotificationSerice();
			notificationSerice.SendNotificatoin("abdulkareemalqa@gmail.com", "Thank you for your subscription", NotificationSerice.enNotificationType.EmailService);
			notificationSerice.SendNotificatoin("736687527", " Your OTP is 1234", NotificationSerice.enNotificationType.SMSService);

			notificationSerice.SendNotificatoin("2131-123-1234", "Sending important docoment", NotificationSerice.enNotificationType.FaxService);


			Console.ReadKey();
		}
	}
}
