using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Highland Morning Stacks Lessons");

            Stack<String> highlandPancakes = new Stack<String>();

            highlandPancakes.Push("Key Lime Pancake");
            highlandPancakes.Push("Lemon Lovers Pancake");
            highlandPancakes.Push("Strawberry Lovers Pancake");

            Console.WriteLine("Pancakes I have eatten from Highland Morning");

            foreach (var pancake in highlandPancakes)
            {
                Console.WriteLine(pancake);
            }

            Console.WriteLine("The Last Pancake I ate at Highlandmorning");
            Console.WriteLine(highlandPancakes.Pop());
        }
    }
}
