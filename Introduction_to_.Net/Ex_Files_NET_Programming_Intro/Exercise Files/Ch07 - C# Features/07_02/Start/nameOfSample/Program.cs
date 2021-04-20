using System;
using System.Collections.Generic;

namespace nameOfSample
{
    class Program
    {
        private static List<string> thePeople;
        static void Main(string[] args)
        {
            //  Test_NameOf();
        }

        ///  <summary>
        ///  nameOf
        ///  </summary>
        ///  <param name="thePeople"></param>
        private static void Test_NameOf()
        {
            thePeople = null;

            if (thePeople == null)
            {
                throw new ArgumentNullException
                    ("thePeople", "The parameter passed null.");
            };

            foreach (var name in thePeople)
            {
                // Do Something
            }
        }

    }
}
