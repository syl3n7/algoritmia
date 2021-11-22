using System;
using System.Diagnostics.Tracing;

namespace Ex5___Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string original, first, last;
            string space = " ";
            int wordcount = 0;
            Console.WriteLine("Introduza uma frase com + de 2 palavras");
            original = Console.ReadLine();

            for (int i = 0; i < original.Length; i++)
            {
            //nao sei precorrer a string ate encontrar um espaco
                if (original.Contains(space))
                {
                    wordcount++;
                }
                first = original.Substring(i);
                //estou apenas a mostrar o numero de chars que a frase contem.
                
            }
            Console.WriteLine($"A frase tem {wordcount} palavras.");
            
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


