using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // bubble sort a random array of numbers
            int[] randomArray = new int[10];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(0, 100);
            }
            Console.WriteLine("Unsorted Array: ");
            foreach (int i in randomArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Sorted Array: ");
            
            
            
        }
    }
}