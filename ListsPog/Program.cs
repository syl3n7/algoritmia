using System;
using System.Collections.Generic;


namespace ListsPog
{
    class Program
    {
        static void Main(string[] args)
        {

            palavrasuser();

        }
        
        static void palavrasuser()
        {
            
            //create an array with 10 words introduced by the user
            List<String> words = new List<string>(10);
            for (int i = 0; i < words.Capacity; i++)
            {
                words.Add(Console.ReadLine());
            }
        }
        
        
    }
}