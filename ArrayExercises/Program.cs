using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someInts = new int[10];
            int[] someOtherInts = { 1, 1, 2, 3, 5, 8 };
            foreach (int i in someOtherInts)
            {
                Console.WriteLine(i);
            }
        }
    }
}
