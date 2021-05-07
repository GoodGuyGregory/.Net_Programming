using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create and istantiate a list
            List<String> customers = new List<string>();

            customers.Add("Kim");
            customers.Add("John");
            customers.Add("Tim");

            //  Output the size of the list
            System.Console.WriteLine($"Customers contains: {customers.Count} items");

            foreach (var customer in customers)
            {
                System.Console.WriteLine(customer);
            }

            Console.WriteLine($"{customers[1]} is a great customer");
        }
    }
}
