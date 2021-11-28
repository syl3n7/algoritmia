using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = "";
            List <int> numero = new List <int>();
            List <string> listastring = new List <string>();
            Console.WriteLine("Por favor introduzir numero:");
            do
            {
                listastring.Add(Console.ReadLine());
                //check if empty
                foreach (var spac in listastring)
                {
                    
                }
                if (listastring[i].Contains(space))
                {
                    break;
                }else
                {
                    //add to list, sort and finnish
                    numero = listastring.Select(x => int.Parse(x)).ToList();
                    
                    for (int i = 0; i < numero.Count; i++)
                    {
                        numero.Sort();
                    }

                    for (int i = 0; i < numero.Count; i++)
                    {
                        Console.WriteLine(numero[i]);
                    }
                }

            } while (listastring.Contains(space));
            Console.WriteLine("Programa Terminado");
        }
    }
}
