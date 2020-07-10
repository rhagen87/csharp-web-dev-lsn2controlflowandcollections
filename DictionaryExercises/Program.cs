using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Student ID: ");
                    input = Console.ReadLine();
                    int studentID = int.Parse(input);
                    students.Add(newStudent, studentID);
                }
            } while (!Equals(newStudent, ""));

            Console.WriteLine("\nClass Roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + " with an ID of " + student.Value);
            }
        }
    }
}
