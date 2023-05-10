using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kvadraticka rovnice";
        Start:
            double x1, x2;

            double a;
            double b;
            double c;

            Console.Clear();
            Console.WriteLine("Kvadratická rovnice a * x^2 + b * x + c = 0\n");
            Console.Write("Zadej a: ");

        A:
            if (double.TryParse(Console.ReadLine(), out a) == true)
            {
                Console.Clear();
                Console.Write("Zadej b: ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej a: ");

                goto A;
            }

        B:
            if (double.TryParse(Console.ReadLine(), out b) == true)
            {
                Console.Clear();
                Console.Write("Zadej c: ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej b: ");

                goto B;
            }

        C:
            if (double.TryParse(Console.ReadLine(), out c) == true)
            {
                Console.Clear();
                goto solve;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba, zkus znovu...\n");
                Console.Write("Zadej c: ");

                goto C;
            }

        solve:
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + (double)Math.Sqrt(d)) / (2 * a);
                x2 = (-b - (double)Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Kvadratická rovnice {0} * x^2 + ({1}) * x + ({2}) = 0 má dvě řešení: x1 = {3} a x2 = {4}", a, b, c, x1, x2);
            }
            if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Kvadratická rovnice {0} * x^2 + ({1}) * x + ({2}) = 0 má jedno řešení: x1 = {3}", a, b, c, x1);
            }
            if (d < 0)
            {
                Console.WriteLine("Kvadratická rovnice {0} * x^2 + ({1}) * x + ({2}) = 0 nemá řešení v oboru R", a, b, c);
            }

            Console.WriteLine("Znovu...Enter");
            Console.ReadLine();
            goto Start;
        }
    }
}
