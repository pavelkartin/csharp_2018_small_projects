using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_G
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sloupec = 0; sloupec < 8; sloupec++)
            {
                for (int rada = 0; rada < 8; rada++)
                {
                    if ((rada + sloupec) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((rada + sloupec) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
