using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kalkulačka BMI";

            Start:

            double m;
            double v;
            double bmi;

            Console.Clear();
            Console.Write("Zadej váhu (v kg): ");

            Vaha:

            if (double.TryParse(Console.ReadLine(), out m) == true)
            {
                Console.Clear();
                Console.Write("Zadejte výšku (v cm): ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej váhu (v kg): ");

                goto Vaha;
            }

            Vyska:

            if (double.TryParse(Console.ReadLine(), out v) == true)
            {
                Console.Clear();

                bmi = m / Math.Pow((v/100),2); // vaha / (vyska / 100)^2
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej výšku (v cm): ");

                goto Vyska;
            }

            bmi = Math.Round(bmi, 2); //zaokrouhleni na 2 des.mista

            Console.WriteLine("BMI = {0}\n", bmi);

            if (bmi < 18)
            {
                Console.WriteLine("PODVÁHA");
            }

            if (bmi >= 18 && bmi <= 28)
            {
                Console.WriteLine("V NORMĚ");  
            }

            if (bmi > 28)
            {
                Console.WriteLine("NADVÁHA");
            }

            Console.WriteLine("\n\nZnovu...Enter");

            Console.ReadLine();

            goto Start;
        }
    }
}
