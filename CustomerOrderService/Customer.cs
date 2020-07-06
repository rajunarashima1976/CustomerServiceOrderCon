using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderService
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustAdd1 { get; set; }
        public string custadd2 { get; set; }
        public string custadd3 { get; set; }
        public string custadd4 { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
