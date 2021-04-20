using System;
using static System.Math;
using static System.Console;

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
            WriteLine
                ($"The comedy club cost me {Round(59.87):C}");
            
        }         
    }
}
