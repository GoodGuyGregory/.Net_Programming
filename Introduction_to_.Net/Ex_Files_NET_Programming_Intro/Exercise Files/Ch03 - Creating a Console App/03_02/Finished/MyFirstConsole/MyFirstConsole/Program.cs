using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my First Console App! \n\n What's your name?");
            string response = Console.ReadLine();
            Console.WriteLine($"Hello, {response}!");
        }
    }
}
