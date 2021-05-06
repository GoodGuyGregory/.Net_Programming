using System;
using System.Collections.Generic;

namespace student_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing import options for spread sheet 

            // Import();
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                //  adds the new student name as the name from user
                newStudent.Name = Util.Console.Ask("Student Name: ");


                Console.Write("Student Grade: ");
                int.TryParse(int.Parse(Console.ReadLine()), out newStudent.Grade);

                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                newStudent.Phone = Console.ReadLine();

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "Birthday", "Address", "12344554");
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected string Phone;

        public string Phone
        {
            set
            {
                phone = value;
            }
        }
    }

    class Student : Member
    {
        // Static Field for Counting all instances of this object
        static public int Count;

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private string phone;

        public Student()
        {
            //  no args constructor
        }
        public Student(string name, int grade, string birthday, string address, string phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
        public string Phone
        {
            set
            {
                phone = value;
            }
        }

        public void SetPhone(string number)
        {
            phone = number;
        }
    }

    class Teacher : Member
    {
        public string Name;
        public string Address;
        public string Phone;
        public string Subject;

        public string Phone
        {
            set
            {
                phone = value;
            }
        }
    }
}
