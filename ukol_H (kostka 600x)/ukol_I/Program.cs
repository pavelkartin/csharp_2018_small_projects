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
        Start:
            Console.Clear();

            Random genRnd = new Random();
            
            int gen1 = 0;
            int gen2 = 0;
            int gen3 = 0;
            int gen4 = 0;
            int gen5 = 0;
            int gen6 = 0;

            Console.WriteLine("Hodit kostkou 600 krát?...Enter");
            Console.ReadLine();

            for (int i = 1; i <= 600; i++)
            {
                int random = 0;
                random = genRnd.Next(1, 7); //1-6

                ////1
                if (random == 1)
                {
                    gen1 = gen1 + 1; 
                }
                ////2
                if (random == 2)
                {
                    gen2 = gen2 + 1;
                }
                ////3
                if (random == 3)
                {
                    gen3 = gen3 + 1;
                }
                ////4
                if (random == 4)
                {
                    gen4 = gen4 + 1;
                }
                ////5
                if (random == 5)
                {
                    gen5 = gen5 + 1;
                }
                ////6
                if (random == 6)
                {
                    gen6 = gen6 + 1;
                }
            }

            Console.WriteLine(
                "1 padla " + gen1 + " krát\n"+ 
                "2 padla " + gen2 + " krát\n" + 
                "3 padla " + gen3 + " krát\n" + 
                "4 padla " + gen4 + " krát\n" +
                "5 padla " + gen5 + " krát\n" +
                "6 padla " + gen6 + " krát\n");

            ////znovu
            Console.WriteLine("\nZnovu...Enter");
            Console.ReadLine();
            goto Start;
        }
    }
}

