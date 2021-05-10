using System;
using System.Threading;

namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File...");
            Download();
            //  because of Task.Run this allows for us to complete the Readline command
            Console.ReadLine();
        }

        static void Download()
        {
            //  allows for the skipping of this method if it takes a longer amount of time
            Task.Run(() =>
            {

                //  Simulate downloading the file
                Thread.Sleep(5000);
                Console.WriteLine("Download Complete");

            });

        }

    }
}
