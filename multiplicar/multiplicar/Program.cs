using System;

namespace multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduz dois numeros");

            int escolha = 1, final = -1;
            int n1, n2;

            n1 = (Convert.ToInt32(Console.ReadLine()));
            
            n2 = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("escolha uma opcao:\n1 - multiplicar\n2 - dividir\n3 - subtrair\n4 - soma");
            escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {

                    case 1:
                        final = Multiplicar(n1, n2);
                        Console.WriteLine(final);
                        break;
                    case 2:
                        final = Dividir(n1, n2);
                        Console.WriteLine(final);
                        break;
                    case 3:
                        final = Subtrair(n1, n2);
                        Console.WriteLine(final);
                        break;
                    case 4:
                        final = Soma(n1, n2);
                        Console.WriteLine(final);
                        break;
                    default:
                        {
                            Console.WriteLine("pressione uma tecla para sair");
                            Console.ReadKey();
                            break;
                        }

                }

                    
            Console.WriteLine(final);
            Console.ReadKey();
        }

        static int Multiplicar(int a, int b)
        {
            int total;

            total = a * b;

            return total;
        }

        static int Dividir(int a, int b)
        {
            int total;

            total = a / b;

            return total;
        }

        static int Subtrair(int a, int b)
        {
            int total;

            total = a - b;

            return total;
        }

        static int Soma(int a, int b)
        {
            int total;

            total = a + b;

            return total;
        }

    }
}
