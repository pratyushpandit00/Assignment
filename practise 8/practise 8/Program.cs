using System;

using System.Collections.Generic;

using System.Linq;

using System.Security.Cryptography;

using System.Text;

using System.Threading.Tasks;

using System.Collections;



namespace arraydemo

{

    class Program

    {

        static void Main(string[] args)

        {

            ArrayList a1 = new ArrayList();

            Console.WriteLine("Initial Capacity: " + a1.Capacity);

            a1.Add(10);

            Console.WriteLine("Total element in a1 is " + a1.Count);

            Console.WriteLine("Capacity after adding first item: " + a1.Capacity);

            a1.Add("Hello");

            a1.Add(true);

            a1.Add(3.14f);

            Console.WriteLine("Capacity after adding fourth item: " + a1.Capacity);

            a1.Add('A');

            Console.WriteLine("Capacity after adding fifth item: " + a1.Capacity);



            for (int i = 0; i < a1.Count; i++)

            {

                Console.Write(a1[1] + " ");

            }

            Console.WriteLine();

        }

    }

}

