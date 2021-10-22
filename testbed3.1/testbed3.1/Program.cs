﻿using System;

namespace testbed3
{
    class Program
    {
        public static int close = 1;
        public static int em = -1;
        static void Main(string[] args) // Main Function
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opcao:\n1> Roll Dice\n2> DND\n0>Sair");
                em = Convert.ToInt32(Console.ReadLine());
                switch (em)
                {
                    case 1:
                        {
                            Console.Clear();
                            Main2();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            BasicAttack(0);
                            break;
                        }

                    case 0:
                        {

                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Escolha uma opcao valida!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                }
            }
            while (em != 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prima uma tecla para terminar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        //funcao para user input dados apenas
        public static int Main2()
        {
            int dados, qdados;
            do
            {
                Console.WriteLine("Introduza um numero: "); // 4, 6, 8, 10, 12, 20 ou 100
                dados = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (dados == 4 || dados == 6 || dados == 8 || dados == 10 || dados == 12 || dados == 20 || dados == 100)
                {
                    do
                    {
                        Console.WriteLine("Introduza o numero de dados a rolar"); // qq numero positivo
                        qdados = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (qdados == 0)
                        {
                            close = 0;
                        }
                        else if (qdados < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Por favor introduza um numero valido (pressionar entre para continuar)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            qdados = Rolldice(dados, qdados);
                        }
                    }
                    while (close != 0);
                }
                else if (dados == 0)
                {
                    close = 0;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor introduza um numero valido (pressionar entre para continuar)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (close != 0);
            return 0;
        }

        //funcao para rodar e calcular (parte da main2)
        public static int Rolldice(int x, int w)
        {
            int soma = 0;
            int random = 0;
            Random r = new Random();

            for (int i = 1; i <= w; i++)
            {
                random = r.Next(1, x + 1);

                if (em == 1)
                {
                    soma += random;
                    Console.WriteLine($"O valor da face {i} é: {random}");
                }
            }

            if(em == 1)
            {
                Console.WriteLine($"A soma das faces e: {soma}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("pressione enter para continuar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                close = 0;
                return w;
            }
            return random;
        }

        //usar enum para criar a lista das armas para usar no switch abaixo 
        public enum weapon
        {
            Dagger,
            Shortsword,
            Battleaxe
        }

        //funcao para o roll + basic atk + damage
        public static int  BasicAttack(int y)
        {


        int valorcustom = 0;
            Console.Clear();
            Console.WriteLine("Escolhe a tua arma: Dagger: 1, Shortsword: 2, Battleaxe: 3");
            //int arma = Convert.ToInt32(Console.ReadLine());
            string compare = Console.ReadLine();
            if (compare == "Dagger") {

            } else if (compare == "Shortsword") {

            } else if (compare == "Battlesword") {

            }
            else
            {
               Console.WriteLine("por favor introduza um valor correto");
               
            }
                
            //perguntar ao user quantas faces quer no dado e rolar apenas 1x.
            Console.WriteLine("Introduza o numero de dots que quer no dado");
            valorcustom = Convert.ToInt32(Console.ReadLine());
            int attk = Rolldice(valorcustom, 1) ;
            int dmg = 0;
            //adicionar AC | modificador de damage perguntando ao user
            Console.WriteLine("Escolhe um valor para o dmg.multiplicador");
            int AC = Convert.ToInt32(Console.ReadLine());

            if (attk >= AC)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result {attk}: Attack succeeded, rolling for damage…\n");
                Console.ForegroundColor = ConsoleColor.White; 
                switch (weapon)
                {

                    case weapon.Dagger:
                        {
                            dmg = AC + Rolldice(4, 1);
                            Console.WriteLine($"Attack resulted in {dmg} points of damage.\nPrima uma tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case weapon.Shortsword:
                        {
                            dmg = AC + Rolldice(6, 1);
                            Console.WriteLine($"Attack resulted in {dmg} points of damage.\nPrima uma tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case weapon.Battleaxe:
                        {
                            dmg = AC + Rolldice(8, 1);
                            Console.WriteLine($"Attack resulted in {dmg} points of damage.\nPrima uma tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                }
            }
            else if (attk <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Result {attk}: Attack failed !\nPrima uma tecla para continuar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
            return 0;
        }

    }
}