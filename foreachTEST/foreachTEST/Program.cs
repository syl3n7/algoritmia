using System;

namespace foreachTEST
{
    class Program
    {
        public static string em;
        public static void Main(string[] args)
        {
           

            do
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opcao:\n1-User\n2-Pass\n3-Nome\n4-Password\n0-Sair\n");
                em = Console.ReadLine();

                switch (em)
                {
                    case "1":
                    {
                        Console.Clear();
                        var user = User() ;
                        Console.WriteLine(user);
                        Console.ReadKey();
                        break;
                    }

                    case "2":
                    {
                        Console.Clear();
                        var nome = Nomeproprio();
                        Console.WriteLine(nome);
                        Console.ReadKey();
                        break;
                    }

                    case "3":
                    {
                        Console.Clear();
                        var password = Password1();
                        Console.Write(password);
                        Console.ReadKey();
                        break;
                    }

                    case "0":
                    {
                        break;
                    }

                    default:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Escolha uma opcao valida!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    }
                }
            } while (em != "0");

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

        static string Nomeproprio() {
            string nome, nometemp;
            Console.WriteLine("Introduza um nome");
            nome = Console.ReadLine();
            nometemp = nome;
            nometemp.ToLower();
            string tn = nometemp.Substring(0, 1);
            tn.ToUpper();
            nome = tn + nometemp;
            return nome;
        }

        static string Password1() {
            Console.WriteLine("introduza a password a definir:");
            var password_user = Console.ReadLine();
            var password_user_temp = "0";

            var flag = char.IsDigit(password_user, 0);
            if (password_user.Length is > 5 and < 8 || flag != true){
                Console.WriteLine("Introduza novamente a password para validar");
                password_user_temp = Console.ReadLine();
            }
            if (password_user_temp != password_user){
                Console.WriteLine("password invalida!");
            }
            else{
                Console.WriteLine("password valida!");
            }
            
            return password_user;
        }

    }
}
