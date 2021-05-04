using System;

namespace Loop_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YOYO Counter");
            Console.WriteLine("========================");
            Console.WriteLine("Specify Counting Times:");

            string userCountIncrement = Console.ReadLine();
            int countIncrement = Int32.Parse(userCountIncrement);
            int i = 1;
            while (i <= countIncrement)
            {
                Console.WriteLine("This is the {0} time counting:", i);
                Console.WriteLine("==============================");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(j);
                }
                for (int j = 9; j >= 1; j--)
                {
                    Console.WriteLine(j);
                }
                i++;
            }

        }
    }
}
