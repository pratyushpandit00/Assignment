using System;
using CustomerOrderLibrary;

namespace CustomerOrderServiceTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            customer c = new customer();
            c.GetCustomerInfo();
            c.DisplayCustomerInfo();
            Console.WriteLine("Hello World!");
        }
    }
}
