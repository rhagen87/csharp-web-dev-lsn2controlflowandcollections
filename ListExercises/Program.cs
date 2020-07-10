using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);

            List<string> foods = new List<string> { "Apple", "Orange", "Banana", "Fruit", "Hotdog", "Pear", "Grape" };
            Console.WriteLine("Enter the number of characters: ");
            string input = Console.ReadLine();
            int inputNum = Int32.Parse(input);
            for (int i = 0; i < foods.Count; i++)
            {
                if (foods[i].Length == inputNum)
                {
                    Console.WriteLine(foods[i]);
                }
            }
        }
    }
}
