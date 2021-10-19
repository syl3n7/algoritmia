using System;

namespace testbed
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int s = 0;
            int r;
            Console.WriteLine("Introduz um número");
            int v = Convert.ToInt32(Console.ReadLine());
            c = v;
            Console.Clear();
            Console.WriteLine("Números ímpares: ");
            for (int i = 1; i <= c; i = i + 2)
            {
                Console.WriteLine(i);
                s = s + i ;
            }

            Console.WriteLine($"A soma dos números totaliza: {s}");
            
            r = c % 2;
            if (r == 0)
            {
                Console.WriteLine("Par !");
  
            }else
            {
                Console.WriteLine($"{c} e Impar !");
            }
            Console.ReadKey();
        }
    }
}