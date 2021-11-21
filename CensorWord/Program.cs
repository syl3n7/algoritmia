using System;

namespace CensorWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalsentence;
            string censoredword;
            string censored = "";
            string sentence;
            
            
            Console.WriteLine("Please introduze the forbidden word: ");
            censoredword = Console.ReadLine();
            
            Console.WriteLine("Please enter the sentence: ");
            sentence = Console.ReadLine();
                
            if (sentence.Contains(censoredword))
            {
                for (int i = 0; i < censoredword.Length; i++)
                {
                    censored += "*";
                }
                finalsentence = sentence.Replace(censoredword, censored);
                Console.WriteLine($"The censored sentence is:\n{finalsentence}");
            }
            else
            {
                Console.WriteLine("The sentence is clear!");
            }
        }
    }
}