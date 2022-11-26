using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderLibrary
{
    public class customer
    {
        public int CustID { get; set; }
        public string CustName { get; set; }

        public void GetCustomerInfo()
        {
            Console.WriteLine("Enter the customerId and Name");
            CustID = Convert.ToInt32(Console.ReadLine());
            CustName = Console.ReadLine();
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer Id : {CustID}");
            Console.WriteLine($"Customer Name : {CustName}");
        }

    }
}
