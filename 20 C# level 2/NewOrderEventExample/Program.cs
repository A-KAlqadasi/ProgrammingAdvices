using System;


namespace NewOrderEventExample
{

    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public decimal OrderPrice { get; }
        public string Email { get; }
        public string Phone { get; }

        public OrderEventArgs(int orderID, decimal orderPrice, string customerEmail, string phone)
        {
            OrderID = orderID;
            OrderPrice = orderPrice;
            Email = customerEmail;
            Phone = phone;
        }

    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> OnNewOrderCreated;
        public void CreateOrder(int orderID,decimal orderPrice, string email, string phone)
        {
            Console.WriteLine("\nNew order created, now will notify everyone by raising the event!");
            if(OnNewOrderCreated!= null)
                OnNewOrderCreated(this,new OrderEventArgs(orderID, orderPrice, email, phone));
        }

       
    }

    public class EmailService
    {
        public void Subscribe(Order order)
        {
            order.OnNewOrderCreated += HandleNewOrder;
        }
        public void Unsubscribe(Order order)
        {
            order.OnNewOrderCreated -= HandleNewOrder;
        }

        private void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"------------Email Service------------");
            Console.WriteLine($"Email service object recived a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order price: {e.OrderPrice}");
            Console.WriteLine($"Email: {e.Email}");
            Console.WriteLine($"Phone: {e.Email}");
            Console.WriteLine("\nHandle send email");
            Console.WriteLine("--------------------------------------");
            /*
                here you write the code to handle send email service to the client
             */
        }
    }

    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OnNewOrderCreated += HandleNewOrder;
        }
        public void Unsubscribe(Order order)
        {
            order.OnNewOrderCreated -= HandleNewOrder;
        }

        private void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"------------SMS Service------------");
            Console.WriteLine($"SMS service object recived a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order price: {e.OrderPrice}");
            Console.WriteLine($"Email: {e.Email}");
            Console.WriteLine($"Phone: {e.Email}");
            Console.WriteLine("\nHandle send SMS");
            Console.WriteLine("--------------------------------------");
            /*
                here you write the code to handle send SMS service to the client
             */
        }
    }

    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OnNewOrderCreated += HandleNewOrder;
        }
        public void Unsubscribe(Order order)
        {
            order.OnNewOrderCreated -= HandleNewOrder;
        }

        private void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"------------Shipping Service------------");
            Console.WriteLine($"Shipping service object recived a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order price: {e.OrderPrice}");
            Console.WriteLine($"Email: {e.Email}");
            Console.WriteLine($"Phone: {e.Email}");
            Console.WriteLine("\nHandle shipping");
            Console.WriteLine("--------------------------------------");
            /*
                here you write the code to handle shipping service to the client
             */
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            EmailService emailService = new EmailService();
            SMSService sMSService = new SMSService();
            ShippingService shippingService = new ShippingService();

            emailService.Subscribe(order);
            sMSService.Subscribe(order);
            shippingService.Subscribe(order);

            order.CreateOrder(1, 200, "Waleed@gmail.com", "778500511");

            Console.ReadKey();
        }
    }
}
