using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    public class Quadratic
    {
        public static void Main()
        {
            int a, b, c;

            double d, x1, x2;

            Console.Write("Enter a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c : ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;

                Console.Write("First  Root= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);

                Console.Write("First  Root= {0}\n", x1);
                Console.Write("Second Root= {0}\n", x2);

            }
            else if (d > 0)
            {
                Console.Write("Both roots are real\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First  Root = {0}\n", x1);
                Console.Write("Second Root = {0}\n", x2);
            }
            else
                Console.Write("Root are imaginary hence No Solution. \n\n");
        }
    }
}
