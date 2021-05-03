using System;

namespace basic_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);

        }
    }
}
