using System;

using System.Collections.Generic;

using System.Linq;

namespace ShoppingAssignment

{

    class Category

    {

        public int id { get; set; }

        public string category { get; set; }

        public string product { get; set; }

        public double price { get; set; }

    }

    class Program

    {

        static void Main(string[] args)

        {

            int choice;

            /*Category category = new Category();*/

            List<Category> list = new List<Category>();



            list.Add(new Category { id = 1, category = "Stationary", product = "Books", price = 20.0 });

            list.Add(new Category { id = 2, category = "Stationary", product = "Pen", price = 10.0 });

            list.Add(new Category { id = 3, category = "Stationary", product = "Pencil", price = 5.0 });

            list.Add(new Category { id = 1, category = "LAPTOPS", product = "Apple", price = 125000.0 });

            list.Add(new Category { id = 2, category = "LAPTOPS", product = "Lenovo", price = 50000.0 });

            list.Add(new Category { id = 3, category = "LAPTOPS", product = "Dell", price = 40000.0 });

            list.Add(new Category { id = 1, category = "Grocery", product = "Rice", price = 400.0 });

            list.Add(new Category { id = 2, category = "Grocery", product = "Wheat", price = 800.0 });

            list.Add(new Category { id = 3, category = "Grocery", product = "Pulses", price = 250.0 });

            Console.WriteLine("WELCOME \n please enter your choice");

            Console.WriteLine("1.STATIONARY");

            Console.WriteLine("2.LAPTOPS");

            Console.WriteLine("3.GROCERY");



            choice = Convert.ToInt32(Console.ReadLine());

            int prod = 0;



            switch (choice)

            {

                case 1:

                    Console.WriteLine("1.BOOKS");

                    Console.WriteLine("2.PEN");

                    Console.WriteLine("3.PENCIL \n");

                    Console.WriteLine("Select Product");

                    string product = Console.ReadLine();

                    Console.WriteLine("Enter Quantity");

                    int qty = Convert.ToInt32(Console.ReadLine());

                    List<Category> li = list.FindAll(cat => cat.product == product);



                    foreach (var item in li)

                    {

                        Console.WriteLine($"{item.id} \t {item.category} \t {item.product} \t {item.price} \n");

                        Console.WriteLine("TOTAL Amount is:" + item.price * qty);

                    }
                    break;

                case 2:

                    Console.WriteLine("1.Apple");
                    Console.WriteLine("2.Lenovo");
                    Console.WriteLine("3.Dell \n");
                    Console.WriteLine("Select Product");

                    product = Console.ReadLine();

                    Console.WriteLine("Enter Quantity");

                    qty = Convert.ToInt32(Console.ReadLine());

                    List<Category> li2 = list.FindAll(cat => cat.product == product);



                    foreach (var item in li2)

                    {

                        Console.WriteLine($"{item.id} \t {item.category} \t {item.product} \t {item.price} \n");

                        Console.WriteLine("TOTAL Amount is:" + item.price * qty);

                    }



                    break;

                case 3:



                    Console.WriteLine("1.Rice");

                    Console.WriteLine("2.Wheat");

                    Console.WriteLine("3.Pulses \n");

                    Console.WriteLine("Select Product");

                    product = Console.ReadLine();

                    Console.WriteLine("Enter Quantity");

                    qty = Convert.ToInt32(Console.ReadLine());

                    List<Category> li3 = list.FindAll(cat => cat.product == product);



                    foreach (var item in li3)

                    {

                        Console.WriteLine($"{item.id} \t {item.category} \t {item.product} \t {item.price} \n");

                        Console.WriteLine("TOTAL Amount is:" + item.price * qty);

                    }



                    break;

                default:

                    Console.WriteLine("Enter Your Choice");

                    break;

            }



        }

    }

}