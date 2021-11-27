using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> listanumeros = new List <int>();

            if (e.KeyCode != Keys.Enter)
            {
                for (int i = 0; i < listanumeros.Count; i++){
                    listanumeros.Add(Convert.ToInt32(Console.ReadLine()));
                }
                for (int i = 0; i < listanumeros.Count; i++){
                    listanumeros.Sort();
                }
                for (int i = 0; i < listanumeros.Count; i++){
                    Console.WriteLine(listanumeros[i]);
                }
            }
        }
    }
}
