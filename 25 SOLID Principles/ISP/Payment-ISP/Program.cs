using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_ISP
{

	
	public interface IPayPal
	{
		void PayWithPayPal();
	}

	public interface ICreditCard
	{
		void PayWithCreditCard();
	}

	public interface IBitcoin
	{
		void PayWithBitcoin();
	}
	
	public class CreditCardPayment : ICreditCard
	{
		public void PayWithCreditCard()
		{
			Console.WriteLine("Payment with credit card.");
		}
	}

	public class PayPalPayment : IPayPal
	{
		public void PayWithPayPal()
		{
			Console.WriteLine("Payment with PayPal.");
		}
	}

	public class AllPayments :IPayPal,ICreditCard,IBitcoin
	{
		public void PayWithPayPal()
		{
			Console.WriteLine("Payment with PayPal.");
		}
		public void PayWithCreditCard()
		{
			Console.WriteLine("Payment with credit card.");
		}
		public void PayWithBitcoin()
		{
            Console.WriteLine("Payment with Bitcoin");
        }
	}
	public class Program
	{
		public static void Main()
		{
			CreditCardPayment creditCardPayment = new CreditCardPayment();
			creditCardPayment.PayWithCreditCard();
			
			PayPalPayment payPalPayment = new PayPalPayment();
			payPalPayment.PayWithPayPal();


			AllPayments allPayments = new AllPayments();
			allPayments.PayWithPayPal();
			allPayments.PayWithBitcoin();
			allPayments.PayWithCreditCard();

			Console.ReadKey();
		}
	}

}
