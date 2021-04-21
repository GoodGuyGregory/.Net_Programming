using System;

namespace UsingSample
{
    class Program
    {
        static void Main(string[] args)
        {            
            Test_UsingSimplified();
        }
        
        /// <summary>
        /// Using static clause
        /// </summary>
        static private void Test_UsingSimplified()
        {
            Console.WriteLine
                ($"The comedy club cost me {Math.Round(59.87):C}");

        }         
    }
}
