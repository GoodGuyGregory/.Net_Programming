using System;

namespace Survey_OOP
{
    class Stats
    {
        public void Start()
        {
            //  access the posted Event
            Program.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey posted, Run stats");
        }
    }
}
