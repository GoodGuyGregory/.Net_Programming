using System;

namespace null_ing_around
{
    class Program
    {
        static void Main(string[] args)
        {
            // with int? it allows the value to  be null
            int? s = null; //"hello"

            //  if the value is infact null coalese it into being 2
            int s2 = s ?? 2;

            Console.WriteLine(s2);
        }
    }
}
