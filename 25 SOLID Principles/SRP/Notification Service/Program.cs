using System;

namespace Notification_Service
{
	public class NotificationSerice
	{
		public enum enNotificationType { EmailService = 1, SMSService = 2, FaxService = 3 }
		public enNotificationType NotificationType;

		public void SendNotificatoin(string to, string message, enNotificationType notificationType)

		{
			if (notificationType == enNotificationType.EmailService)
			{
				SendEmail(to, message);
			}
			else if (notificationType == enNotificationType.SMSService)
			{
				SendSMS(to, message);
			}
			else if (notificationType == enNotificationType.FaxService)
			{
				SendFax(to, message);
			}

		}

		private void SendEmail(string to, string message)
		{
			// here you write the logic for sending Emails
			Console.WriteLine($"Sending Email to: {to} : {message}");
		}

		private void SendSMS(string to, string message)
		{
			// here you write the logic for sending SMS
			Console.WriteLine($"Sending SMS to: {to} : {message}");
		}

		private void SendFax(string to, string message)
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
