using System;

namespace Multiple_Choice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Survey:");
            Console.WriteLine("=========================");

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("How Old are you?");

            string age = Console.ReadLine();


            try
            {
                int userAge = int.Parse(age);
            }
            catch (System.FormatException)
            {

                Console.WriteLine("format exception, please enter a number");
            }

            Console.WriteLine("What Month Were you born?");

            string monthBorn = Console.ReadLine();

            Console.WriteLine("Finished, Thanks for taking our survey, {0}", name);

            Console.WriteLine("Our Survey has recorded you are {0}, and were born in the of {1}", age, monthBorn);



        }
    }
}
