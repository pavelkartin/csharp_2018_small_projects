using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_K
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            double celek = 0;
            double procent = 0;
            double vysledek;

            Console.Clear();
            Console.Write("Zadej celek: ");

        Celek:
            if (double.TryParse(Console.ReadLine(), out celek) == true && celek > -99999999 && celek < 99999999)
            {
                Console.Clear();
                Console.Write("Zadej procent: ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej celek: ");

                goto Celek;
            }
            
        Procent:
            if (double.TryParse(Console.ReadLine(), out procent) == true && celek >= 0 && celek <= 100)
            {
                Console.Clear();
                vysledek = (celek/100) * procent;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej procent: ");

                goto Procent;
            }

            vysledek = Math.Round(vysledek, 3);    

            Console.WriteLine(procent + " % z " + celek + " je " + vysledek + "\n");

            Console.WriteLine("\n\nZnovu...Enter");
            Console.ReadLine();

            goto Start;
        }
    }
}
