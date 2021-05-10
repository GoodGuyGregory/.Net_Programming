using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuples: collection that allow for items ");
            Console.WriteLine("different types in one collection");

            // Declare a Tuple:
            Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "Hello", true);

            // Accesses the second item in the tuple "Hello"
            Console.WriteLine(myTuple.Item2);

            //  Alternative way to create a tuple without specifying the element types
            var newTuple = Tuple.Create(1, "hello", true);

            Console.WriteLine($"{newTuple.Item2}: is the second item of the newTuple");
        }
    }
}
