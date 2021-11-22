using System;

namespace Ex5___Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza uma frase com amis de duas palavras");
            string original, first, last;
            string space = " ";
            original = Console.ReadLine();

            
            for (int i = 0; i < original.Length; i++)
            {

                if (original.Contains(space))
                {
                    
                }
                first = original.Substring(i);

            }
/*
if (sentence.Contains(censoredword))
            {
                for (int i = 0; i < original.Length; i++)
                {
                     += "*";
                }
                finalsentence = sentence.Replace(censoredword, censored);
                Console.WriteLine($"The censored sentence is:\n{finalsentence}");
            }        
*/
        }
    }
}


