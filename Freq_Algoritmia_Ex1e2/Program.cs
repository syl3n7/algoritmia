using System;

namespace Freq_Algoritmia_Ex1e2
{
    class Program
    {
        static void Main(string[] args)
        {

            ex1();
            Console.WriteLine("Prima uma tecla para continar para o ex2");
            Console.ReadKey();
            Console.Clear();

            ex2();
            Console.WriteLine("Prima uma tecla para terminar..");
            Console.ReadKey();
        }

        static void ex1()
        {
            Console.WriteLine("Introduza uma frase");
            String fraseO = Console.ReadLine();
            int counter = 0;
            String space = " ";
            String[] list = fraseO.Split(space);

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].StartsWith("a") || list[i].StartsWith("A")) counter++;
            }

            Console.WriteLine($"A frase contem {counter}");
        }

        static void ex2()
        {

            Console.WriteLine("Adivinhe o número de 1 a 20");
            Random r = new Random();
            int rand = r.Next(1, 21);
            int n = 0;
            int test;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                test = rand.CompareTo(n);
                if (test == 0)
                {
                    Console.WriteLine("Em cheio! ");
                    break;
                }
                else if (test > 0)
                {
                    Console.WriteLine("Maior! ");
                }
                else if (test < 0)
                {
                    Console.WriteLine("Menor! ");
                }
                else
                {

                }

            } while (test != 0);

        }
    }
}
