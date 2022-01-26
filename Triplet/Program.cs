using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triplet
{
    public static class Triplet
    {
        static void Triplets(int[] array, int num)
        {
            bool found = false;

            for (int i = 0; i < num - 2; i++)
            {
                for (int j = i + 1; j < num - 1; j++)
                {
                    for (int k = j + 1; k < num; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine(array[i]);
                            
                            Console.WriteLine(array[j]);
                            
                            Console.WriteLine(array[k]);
                            Console.WriteLine("\n");
                            found = true;
                        }
                    }
                }
            }

            if (found == false)
            {
                Console.WriteLine("There is No triplet");
            }
        }
        public static void Main()
        {
            int[] arr = { 0, -1, 2, -3, 1 };
            int number = arr.Length;
            Triplets(arr, number);
        }
    }
}
