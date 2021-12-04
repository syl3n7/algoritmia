using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios___Queue_Stack_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza cinco números!");

            //ex1 e 2
            /*Queue<int> nums = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                nums.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var number in nums)
            {
                Console.WriteLine($"{number}\n");
            }*/
            
            //ex3
            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                nums.Push(Convert.ToInt32(Console.ReadLine()));
            }     
            
            for (int i = 0; i < 5; i++)
            {
                nums.;
            }

            foreach (var number in nums)
            {
                Console.WriteLine($"{number}\n");
            }
            
            
        }
    }
}