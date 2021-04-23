using System;

namespace ConsoleApplication
{
     class Program
     {
          static void Main(string[] args) { 
               
               if (DateTime.Now.Hour < 12) {
                    Console.WriteLine("Good Morning, from a console application");
               }
               else
               {
                    Console.WriteLine("Good Day, from a console application");
               }
               
               Console.WriteLine("The time is currently: {0}", DateTime.Now);
               Console.WriteLine("Plese tell me your name");
               string name = Console.ReadLine();
               Console.WriteLine($"Hello {name}!");
          }
     }
}
