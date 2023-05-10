using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Násobilka";

            Console.WriteLine("Násobilka až po požadované číslo");
            Console.WriteLine("\nPokračovat...Enter");
            Console.ReadLine();
        Start:
            Console.Clear();
            Console.Write("Zadej číslo od 1 do 10: ");
        A:
            int limit;

            if (int.TryParse(Console.ReadLine(), out limit) == false) //jen cislo
            {
                Console.Clear();
                Console.Write("Chyba, zkus znovu: ");
                goto A;
            }

            if (!(limit < 1 || limit > 10))
            {
                Console.Clear();
                Console.WriteLine("Násobilka {0} x {0}\n", limit);

                for (int i = 1; i <= limit; i++)
                {
                    for (int j = 1; j <= limit; j++)
                        Console.Write("{0}\t", j * i); //\t horizontalni
                    Console.WriteLine();
                }

                Console.WriteLine("\nZnovu...Enter");
                Console.ReadLine();
                goto Start;
            }
            else
            {
                Console.Clear();
                Console.Write("Chyba. Zadej číslo od 1 do 10: ");
                goto A;
            }
        }
    }
}
