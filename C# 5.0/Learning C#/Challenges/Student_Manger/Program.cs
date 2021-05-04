﻿using System;
using System.Collections;

namespace Student_Manger
{
    class Program
    {
        static string Prompt(string Student)
        {
            Console.WriteLine("Done Added {0} to the Gradebook", Student);

            Console.WriteLine("Would you like to add another student? [y/n] ");
            string option = Console.ReadLine();

            if (option.ToLower() != "n")
            {
                return "y";
            }
            else
            {
                return "n";
            }
        }

        static void Add(string StudentName, string StudentGrade)
        {
            string combinedEntry = StudentName + " " + StudentGrade;
            studentlist.Add(combinedEntry);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Student Manager Program:");
            Console.WriteLine("=========================");
            System.Console.WriteLine();
            ArrayList studentList = new ArrayList();

            string response = "y";
            while (response.ToLower() != "n")
            {
                Console.WriteLine("Enter Student's Name:");
                string studentName = Console.ReadLine();
                Console.WriteLine("Enter Student's Grade:");
                string studentGrade = Console.ReadLine();
                AddStudent(studentName, studentGrade);
                response = Prompt(studentName);
            }

            Console.WriteLine("Displaying the Student Roster");
        }
    }
}
