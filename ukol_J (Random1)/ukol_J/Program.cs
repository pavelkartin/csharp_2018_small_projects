using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_J
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            Console.WriteLine("Vygenerovat náhodné číslo...Enter");
            Console.ReadLine();
            Random rnd = new Random();
            int vysledek = rnd.Next(0, 11);
            //Console.Clear();
            Console.WriteLine("..."+vysledek+"\n");
            Console.WriteLine("Znovu...Enter");
            Console.ReadLine();
            goto Start;
        }
    }
}
