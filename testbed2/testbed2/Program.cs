using System;

namespace testbed2
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int hour = 0;
            Console.WriteLine("Introduz o dia atual (de 1 a 7)");
            do
            {
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dia invalido, tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while (day < 1 || day > 7) ;
            Console.Clear();
            Console.WriteLine("Introduz a hora atual");
            do
            {
                hour = Convert.ToInt32(Console.ReadLine());
                if (hour < 0 || hour > 24)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hora invalida, tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (hour < 0 || hour > 24);
            Console.Clear();
            switch (day)
            {
                case 6: //saturday
                    if ( hour > 9 && hour < 1 ) 
                        {
                            Console.WriteLine("I'm awake!");
                        }
                        else if ( hour == 9 )
                        {

                            Console.WriteLine("Time to wake - up!");

                        }else if ( hour == 1 )
                        {
                            Console.WriteLine("Time to sleep!");
                        }
                        else
                        {
                            Console.WriteLine("I'm Sleeping!");
                        }
                        break;
                case 7: //sunday
                    if (hour > 9 && hour < 23)
                    {
                        Console.WriteLine("I'm awake!");
                    }
                    else if (hour == 9)
                    {
                        Console.WriteLine("Time to wake - up!");
                    }
                    else if (hour == 23)
                    {
                        Console.WriteLine("Time to sleep!");
                    }
                    else
                    {
                        Console.WriteLine("I'm Sleeping!");
                    }
                    break;
                case 5: //friday
                    if (hour > 7 && hour < 1)
                    {
                        Console.WriteLine("I'm awake!");
                    }
                    else if (hour == 7)
                    {
                        Console.WriteLine("Time to wake - up!");
                    }
                    else if (hour == 1)
                    {
                        Console.WriteLine("Time to sleep!");
                    }
                    else
                    {
                        Console.WriteLine("I'm Sleeping!");
                    }
                    break;
                default: //monday, tuesday, wednesday, thursday
                    if (hour > 7 && hour < 23)
                    {
                        Console.WriteLine("I'm awake!");
                    }
                    else if (hour == 7)
                    {
                        Console.WriteLine("Time to wake - up!");
                    }
                    else if (hour == 23)
                    {
                        Console.WriteLine("Time to sleep!");
                    }
                    else
                    {
                        Console.WriteLine("I'm Sleeping!");
                    }
                    break;                    
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prima uma tecla para terminar");
            Console.ReadKey();
        }
    }
}