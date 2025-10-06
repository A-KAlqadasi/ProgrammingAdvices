using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
	public class NotificationSerice
	{
		INotification _Notification;
        public NotificationSerice(INotification notification)
        {
            _Notification = notification;
        }

        public void SendNotificatoin(string to, string message)=> _Notification.Send(to, message);

	}

	public interface INotification
	{
		 void Send(string to, string message);

	}

	public class EmailService:INotification
	{
		public void Send(string to, string message)
		{
			// here you write the logic for sending Emails
			Console.WriteLine($"Sending Email to: {to} : {message}");
		}
	}

	public class SMSService:INotification
	{
		public void Send(string to, string message)
		{
			// here you write the logic for sending SMS
			Console.WriteLine($"Sending SMS to: {to} : {message}");
		}
	}
	public class FaxService:INotification
	{
		public void Send(string to, string message)
		{
			// here you write the logic for sending Fax
			Console.WriteLine($"Sending Fax to: {to} : {message}");
		}
	}

	public class TelegramService:INotification
	{
		public void Send(string to, string message)
		{
			// here you write the logic for sending Telegram
			Console.WriteLine($"Sending Telegram to: {to} : {message}");
		}
	}

	public class WhatsappService:INotification
	{
		public void Send(string to, string message)
		{
			// here you write the logic for sending Whatsapp
			Console.WriteLine($"Sending Whatsapp to: {to} : {message}");
		}
	}

	public class SnappChatService : INotification
	{
		public void Send(string to, string message)
		{
			// here you write the logic for sending SnappChat
			Console.WriteLine($"Sending SnappChat to: {to} : {message}");
		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			NotificationSerice notificationSerice = new NotificationSerice(new EmailService());
			notificationSerice.SendNotificatoin("abdulkareemalqa@gmail.com", "Thank you for your subscription");

			notificationSerice = new NotificationSerice(new SMSService());

			notificationSerice.SendNotificatoin("736687527", " Your OTP is 1234");
			notificationSerice = new NotificationSerice(new FaxService());
			notificationSerice.SendNotificatoin("2131-123-1234", "Sending important message");

			notificationSerice = new NotificationSerice(new TelegramService());

			notificationSerice.SendNotificatoin("2131-123-1234", "Sending important message");
			notificationSerice = new NotificationSerice(new WhatsappService());

			notificationSerice.SendNotificatoin("2131-123-1234", "Sending important message");
			notificationSerice = new NotificationSerice(new SnappChatService());

			notificationSerice.SendNotificatoin("2131-123-1234", "Sending important message");


			Console.ReadKey();
		}
	}
}
