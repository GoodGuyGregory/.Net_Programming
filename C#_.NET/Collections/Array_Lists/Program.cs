using System;
using System.Collections;

namespace Array_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arraylists use boxing because it is just a collection type that 
            //  can hold all type defs
            ArrayList list = new ArrayList();

            list.Add("udefined string type");

            //  this is BOXING: it uses a generic object to store a value
            int i = 123;

            object o = i;

            // boxing :
            //  now it is recast to its original data type
            i = (int)o;

            // ACCESSING ELEMENTS:
            String s = (String)list[0];

            Console.WriteLine($"{s} is inside of the Arraylist");


        }
    }
}
