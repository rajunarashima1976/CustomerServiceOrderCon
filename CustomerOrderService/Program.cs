using System;

namespace CustomerOrderService
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ca1 = new Customer();
            Order or1 = new Order();
            //Console.WriteLine("Hello World!");
            CustomerOrderService c1 = new CustomerOrderService();
            c1.ApplyDiscount(ca1, or1);
        }
    }
}
