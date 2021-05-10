using System;

namespace LearningNullConditional
{

    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Tim" }; // what if this was NULL?
            Console.WriteLine(person.Name);

            //  Basic Checking for NULL without the NULL operator
            Person nullPerson = null;
            if (nullPerson != null)
            {
                Console.WriteLine(nullPerson.Name);
            }
            else
            {
                Console.WriteLine("Person's name is N/A");
            }

            // Using the NULL OPERATOR:
            //  This can be configured on properties of any element 
            Console.WriteLine(nullPerson?.Name);

            Person personWithoutName = new Person();
            //  This will use the coalesce elements to allow for the default to be replaced with "Not Set yet"
            Console.WriteLine(personWithoutName?.Name ?? "Not Set yet");


        }
    }
}
