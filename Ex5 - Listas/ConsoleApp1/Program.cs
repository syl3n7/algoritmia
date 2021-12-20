using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate array of random numbers
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            
            //print array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Clear();
            Console.WriteLine("im going to sort the array now");
            Console.ReadKey();
            
            //bubble sort the array
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.ReadKey();
            //print the sorted array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}