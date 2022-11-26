using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace HashMap

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Hashtable ht = new Hashtable();

            ht.Add("EId", 1001);

            ht.Add("Name", "Pandit");

            ht.Add("Job", "Developer");

            ht.Add("Salary", 15000);

            ht.Add("Location", "Chennai");

            ht.Add("Dept", "ECE");

            ht.Add("EmailID", "pp@hmail.com");



            Console.WriteLine(" Printing Using Foreach Loop");

            foreach (object obj in ht.Keys)

            {

                Console.WriteLine(obj + " : " + ht[obj]);

            }

            Console.WriteLine();

            Console.WriteLine("Printing Using Keys");

            Console.WriteLine("Location : " + ht["Location"]);

            Console.WriteLine("EmailID : " + ht["EmailID"]);





            Console.WriteLine("Is EmailId Key Exists : " + ht.ContainsKey("EmaildID"));



            Console.WriteLine("Is Department Key Exists : " + ht.ContainsKey("Department"));





        }

    }

}

