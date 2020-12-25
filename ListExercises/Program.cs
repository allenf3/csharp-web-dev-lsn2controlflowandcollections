using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 83.7, 91.87, 72.3, 99, 81.3, 94.8, 84.9, 79.2, 97.3, 100 };
            Console.WriteLine(FindSum(grades));

            static double FindSum(List<double> numbers)
            {
                double total = 0;

                foreach(double num in numbers)
                {
                    total += num;
                }

                return total;
            }

            List<string> names = new List<string>() { "Jeff", "Stewart", "Peggy", "Wilma", "Walter", "James", "Joe", "Teddy" };
            Console.WriteLine("Names of which length?");
            int length = int.Parse(Console.ReadLine());
            
            PrintWords(names, length);



            static void PrintWords(List<string> words, int numLetters)
            {
                foreach(string word in words)
                {
                    if(word.Length == numLetters)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
