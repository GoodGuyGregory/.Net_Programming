using System;
using System.Collections.Generic;

namespace nameOfSample
{
    class Program
    {   
        private static List<string> theCrowd;
        static void Main(string[] args)
        {
            //  Test_NameOf();
            
        }

        ///  <summary>
        ///  nameOf
        ///  </summary>
        ///  <param name=nameof(theCrowd)></param>
        private static void Test_NameOf()
        {
            theCrowd = null;
            
            if (theCrowd == null)
            {
                throw new ArgumentNullException
                    (nameof(theCrowd), "The parameter passed null.");
            };

            foreach (var name in theCrowd)
            {
                // Do Something
            }
        }        

    }
}
