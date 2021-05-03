using System;

namespace Passcode_Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Back!");
            Console.WriteLine("====================");
            Console.WriteLine("Please Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your authetication token");
            Boolean authenticated = false;
            while (authenticated == false)
            {
                string passcode = Console.ReadLine();
                if (passcode == "secret")
                {
                    authenticated = true;
                    Console.WriteLine("Welcome, {0}", username);
                }
                else
                {
                    authenticated = false;
                    Console.WriteLine("Please try again {0}", username);
                }
            }
        }
    }
}
