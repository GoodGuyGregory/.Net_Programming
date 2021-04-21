using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterp
{
    class Program
    {
        private static List<string> thePeople;
        static void Main(string[] args)
        {            
            Test_StringInterpolation();
        }

        /// <summary>
        /// String interpolation
        /// </summary>
        private static void Test_StringInterpolation()
        {
            var city = "Burbank";
            var state = "CA";
            var zip = 91505;
            decimal money = 15;

            //var address_oldSchool = 
            //    string.Format("\n334 S. Main St., {0}, {1}, {2}\n", city, state, zip);

            var address_newSchool = $"\n334 S. Main St., {city}, {state}, {zip}\n";
            var moneyOwed = 
                $"Today: {DateTime.Now.ToShortDateString()}, Dollars owed: {money:C}";

            Console.WriteLine(address_newSchool);
            Console.WriteLine(moneyOwed);

        }        
    }
}
