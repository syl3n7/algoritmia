using System;

namespace foreachTEST
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*int escolha;
            
            do
            {
                Console.WriteLine("selecione uma opcao:\n1-User\n2-Pass\n3-Nome\n4-Password\n0-Sair\n");
                escolha = Console.Read();
                switch (escolha)
                {
                    case '1':
                        Console.WriteLine(User());
                        break;
                    case '2':
                        Console.WriteLine(Pass());
                        break;
                    case '3':
                        Console.WriteLine(Nomeproprio());
                        break;
                    case '4':
                        
                        break;
                    default:
                        Console.WriteLine("Introduza uma opcao valida\n");
                        break;
                }
            } while (escolha!=0);
            */
            Console.WriteLine(Password1());
        }


        private static string User()
        {
            string username, usernametemp;
            Console.WriteLine("introduza o nome de utilizador");
            username = Console.ReadLine();
            usernametemp = username;
            usernametemp.ToLower();
            usernametemp.Replace(" ", "_");
            return usernametemp;
        }

        private static string Pass()
        {
            Console.WriteLine("Introduza a password");
            string password, passwordtemp;
            password = Console.ReadLine();
            passwordtemp = password;
            passwordtemp.ToLower();
            passwordtemp.Replace(" ", "_");
            return passwordtemp;
        }

        private static string Nomeproprio()
        {
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

        private static string Password1()
        {
            Console.WriteLine("introduza a password a definir:");
            var password_user = Console.ReadLine();
            
            string password_user_temp = "0";
            
            var flag = char.IsDigit(password_user, 0);
            if (password_user.Length is > 5 and < 8 || flag != true)
            {
                password_user_temp = Console.ReadLine();
                
            }else if (password_user_temp != password_user)
            {
                Console.WriteLine("password invalida!");
            }
            else
            {
                Console.WriteLine("password valida!");
            }
            
            return password_user;
        }
    }
}
