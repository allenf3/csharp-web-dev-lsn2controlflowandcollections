using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string input;
            do
            {
                Console.WriteLine("Enter a student ID or <Enter> when finished:");
                input = Console.ReadLine();
                if (input != "")
                {
                    int studentId = int.Parse(input);
                    Console.WriteLine($"Student name for ID of {studentId}:");
                    string studentName = Console.ReadLine();
                    if (!students.ContainsKey(studentId))
                    {
                        students.Add(studentId, studentName);
                    }
                }
            } while (input != "");


            Console.WriteLine("Students:");
            foreach(KeyValuePair<int, string> student in students)
            {
                Console.Write($"{student.Key}   ");
                Console.WriteLine(student.Value);
            }
        }
    }
}
