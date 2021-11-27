using System;
using System.Collections.Generic;


namespace ListsPog
{
    class Program
    {
        static void Main(string[] args)
        {

            palavrasuser();
            criararray();

        }
        
        static 
        
        static void criararray()
        {
            List<int> numberlist = new List<int>(new int[] { 65, 47, 100, 3, 19 });
        }
        
        static void palavrasuser()
        {
            
            //create an array with 10 words introduced by the user
            Console.WriteLine("Introduza 10 palavras :)\n");
            List<String> words = new List<string>(10);
            for (int i = 0; i < words.Capacity; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < words.Count; i++)
            {
                words.Reverse();
                Console.WriteLine($"Palavra {i}: {words[i]}");
            }
        }

    }
}