using System;

namespace testbed
{
    class Program
    {
        static void Main(string[] args)
        {
            int c; //contador 
            int s = 0; //soma dos numeros
            int r; //resto para saber par ou impar
            Console.WriteLine("Introduz um número"); 
            int v = Console.Read(); //ler o numero do user
            c = v; //fazer com que o contador tenha o mesmo valor que o numero do user
            Console.Clear(); // limpar o ecra
            Console.WriteLine("Números ímpares: ");
            for (int i = 1; i <= c; i = i + 2)  // precorrer os numeros de 1 ate ao numero do user 
            {
                Console.WriteLine(i); // escrever cada numero existente 
                s = s + i ;  // somar o numero atual ao soma para dar o total no fim
            }
            Console.WriteLine($"A soma dos números totaliza: {s}"); // escrever a soma no ecra
            r = c % 2; // calcular o resto e guardar em R
            if (r == 0)  // se o resto for = 0
            {
                Console.WriteLine("Par !"); //escrever par
            }else
            {
                Console.WriteLine($"{c} e Impar !"); // escrever impar
            }
            Console.ReadKey(); // input do user para sair do programa
        }
    }
}