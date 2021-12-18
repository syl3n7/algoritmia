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

            Console.WriteLine("Introduza a palavra proibida: ");
            censoredword = Console.ReadLine();

            Console.WriteLine("Introduza a frase completa: ");
            sentence = Console.ReadLine();

            if (sentence.Contains(censoredword))
            {
                for (int i = 0; i < censoredword.Length; i++)
                {
                    censored += "*";
                }

                finalsentence = sentence.Replace(censoredword, censored);
                Console.WriteLine($"A palavra censurada e:\n{finalsentence}");
            }
            else
            {
                Console.WriteLine("A frase esta limpa!");
            } 
        }
    }
}