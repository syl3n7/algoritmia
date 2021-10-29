using System;

namespace foreachTEST
{
    class Program
    {
        public static int em;
        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opcao:\n1-User\n2-Pass\n3-Nome\n4-Password\n0-Sair\n");
                em = Console.Read();

                switch (em)
                {
                    case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(User());
                        break;
                    }

                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(Pass());
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine(Nomeproprio());
                        break;
                    }

                    case 4:
                    {
                        Console.Write(Password1());
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
            } while (em != 0);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prima uma tecla para terminar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); 
        }


        static string User() {
            string username, usernametemp;
            Console.WriteLine("introduza o nome de utilizador");
            username = Console.ReadLine();
            usernametemp = username;
            usernametemp.ToLower();
            usernametemp.Replace(" ", "_");
            return usernametemp;
        }

        static string Pass() {
            Console.WriteLine("Introduza a password");
            string password, passwordtemp;
            password = Console.ReadLine();
            passwordtemp = password;
            passwordtemp.ToLower();
            passwordtemp.Replace(" ", "_");
        return passwordtemp;
        }

        static string Nomeproprio() {
            string nome, nometemp;
            Console.WriteLine("Introduza um nome");
            nome = Console.ReadLine();
            nometemp = nome;
            nometemp.ToLower();
            var tn = nometemp.Substring(0, 1);
            tn.ToUpper();
            nome = tn + nometemp;
            return nome;
        }

        static string Password1() {
            Console.WriteLine("introduza a password a definir:");
            var password_user = Console.ReadLine();
            string password_user_temp = "0";

            var flag = char.IsDigit(password_user, 0);
            if (password_user.Length is > 5 and < 8 || flag != true){
            password_user_temp = Console.ReadLine();

            }else if (password_user_temp != password_user){
            Console.WriteLine("password invalida!");
            }
            else{
            Console.WriteLine("password valida!");
            }

            return password_user;
        }

    }
}
