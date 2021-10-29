using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace foreachTEST
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = User();
            Console.WriteLine(username);

            string password = Pass();
            Console.WriteLine(password);
            
            string nomefinal = Nomeproprio();
            Console.WriteLine(nomefinal);

            string password1 = Password1();
            Console.WriteLine(password1);

        }


        static string User()
        {
            String username, usernametemp;
            Console.WriteLine("introduza o nome de utilizador");
            username = Console.ReadLine();
            usernametemp = username;
            usernametemp.ToLower();
            usernametemp.Replace(" ", "_");
            return usernametemp;
        }

        static string Pass()
        {
            Console.WriteLine("Introduza a password");
            String password, passwordtemp;
            password = Console.ReadLine();
            passwordtemp = password;
            passwordtemp.ToLower();
            passwordtemp.Replace(" ", "_");
            return passwordtemp;
        }
        
        static string Nomeproprio()
        {
            String nome, nometemp;
            Console.WriteLine("Introduza um nome");
            nome = Console.ReadLine();
            nometemp = nome;
            nometemp.ToLower();
            String tn = nometemp.Substring(0, 1);
            tn.ToUpper();
            nome = tn + nometemp;
            return nome;
        }

        static string Password1()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] array = {i};
            }

            Console.WriteLine("introduza a password a definir:")};
            string password_do_user = Console.ReadLine();
            string password_do_user_temp;
            bool flag = char.IsDigit(password_do_user, 0);
            password_do_user_temp = Console.ReadLine();
                if (password_do_user.Length > 5 && password_do_user.Length < 8 || flag != true)
            {
               password_do_user_temp = Console.ReadLine();

               if (password_do_user == password_do_user_temp)
                    {
                        Console.WriteLine("password valida!");
                    }
                    else Console.WriteLine("verifique novamente a password");

                }else Console.WriteLine("nao tem o tamanho correto");
            }

    return password_do_user;
        }
        
    }
}

