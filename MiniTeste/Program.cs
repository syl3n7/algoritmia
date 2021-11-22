using System;
using System.Linq;

namespace Numeros_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 2){
                int[] a = new int[n];
                int menor = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Number: {i}");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    if (i == 0 || menor > a[i])
                        menor = a[i];
                }
                Console.WriteLine($"The Lowest number is: {menor}");
            } else {
                Console.WriteLine("Introduza numero superior a 2");
            }
       }
    }
}
