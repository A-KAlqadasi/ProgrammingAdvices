using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService
{
	public class PaymentService
	{
		IPaymentProcessor _Process;
        public PaymentService(IPaymentProcessor Process)
        {
            _Process = Process;
        }
        public void Process(string account , decimal amount )
		{
			_Process.Process(account, amount);
		}
	}

	public interface IPaymentProcessor
	{
		 void Process(string account , decimal amount );
	}

	public class PayPalProcess : IPaymentProcessor
	{
		public void Process(string account, decimal amount)
		{
            Console.WriteLine($"\nPayPal service: account: {account}, ammount :{amount:C}");
        }
	}
	public class CreditCardProcess : IPaymentProcessor
	{
		public void Process(string account , decimal amount)
		{
			Console.WriteLine($"\nCredit Card service: account: {account}, amount :{amount:C}");

		}
	}
	public class BankTransferProcess : IPaymentProcessor
	{
		public void Process(string account, decimal amount)
		{
			Console.WriteLine($"\nBank Transfer service: account: {account}, amount :{amount:C}");

		}
	}

	public class BitcoinProcess : IPaymentProcessor
	{
		public void Process(string account, decimal amount)
		{
			Console.WriteLine($"\nBitcoin service: account: {account}, amount :{amount:C} in Bitcoin");

		}
	}

	public class MasterCardProcess : IPaymentProcessor
	{
		public void Process(string account, decimal amount)
		{
			Console.WriteLine($"\nMaster card service: account: {account}, amount :{amount:C}");

		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			PaymentService Process = new PaymentService(new PayPalProcess());

			Process.Process("abdulkareem", 200M);

			Process = new PaymentService(new CreditCardProcess());
			Process.Process("abdulkareem", 300M);

			Process = new PaymentService(new BankTransferProcess());
			Process.Process("abdulkareem", 400M);

			Process = new PaymentService(new BitcoinProcess());
			Process.Process("abdulkareem", 0.01M);

			Process = new PaymentService(new MasterCardProcess());
			Process.Process("abdulkareem", 100M);

			Console.ReadKey();
		}
	}
}
