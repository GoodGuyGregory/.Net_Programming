using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIFO not LIFO as a stack is
            Queue<string> myplaylistQueue = new Queue<string>();

            myplaylistQueue.Enqueue("Mildlife - Phase");
            myplaylistQueue.Enqueue("Washed Out - Paracosm");
            myplaylistQueue.Enqueue("Khurangbin - Con Todo El Mundo");

            // Display the items
            Console.WriteLine("Records I'm listening to today:");
            foreach (var record in myplaylistQueue)
            {
                Console.WriteLine(record);
            }

            //  Dequeue() removes last item from the queue
            //  Peek() works just as the stack and allows viewing of the next item in the queue

        }
    }
}
