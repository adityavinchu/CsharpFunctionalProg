using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetTwoPoints
{
    class Distance
    {
        public static void Main()
        {
            double x1, x2, y1, y2;
            x1 = 50d;
            x2 = 45d;
            y1 = 20d;
            y2 = 15d;
            var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance);
        }
    }
 
}
