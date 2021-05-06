using System;

namespace Survey_OOP
{
    class Program
    {
        static public event Action Posted;
        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();
            Console.WriteLine("Simple Survey:");
            Console.WriteLine("=========================");
            var userSubmission = new Survey_Submission();

            Console.WriteLine("What is your name?");

            userSubmission.Name = Console.ReadLine();

            Console.WriteLine("How Old are you?");

            try
            {
                userSubmission.Age = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {

                Console.WriteLine("format exception, please enter a number");
            }

            Console.WriteLine("What Month Were you born?");

            userSubmission.MonthOfBirth = Console.ReadLine();
            if (Posted != null)
            {

                Posted();
            }

            Console.WriteLine("Finished, Thanks for taking our survey, {0}", userSubmission.Name);

            Console.WriteLine("Our Survey has recorded you are {0}, and were born in the of {1}", userSubmission.Age, userSubmission.MonthOfBirth);



        }
    }

    class Survey_Submission
    {
        public string Name;
        public int Age;
        public string MonthOfBirth;

        public Survey_Submission()
        {
            Console.WriteLine("Created a Survey Submission");
        }
    }
}
