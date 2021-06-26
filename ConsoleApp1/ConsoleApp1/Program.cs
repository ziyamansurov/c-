using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, -6, -5, 4, 5, 13, 4 };

            int k = 0;int[] d = new int[a.GetLength(0)];
            for (int i = 0; i < 6; i++)
            {
                if (a[i] < 0)
                {
                    d[k] = a[i];
                    
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
                Console.WriteLine(d[i]);
                Console.ReadLine();
           /* int[,] a = new int[3, 3]
             { {5,9,7}, {67,7,45}, {89,45,5} };
            int max; int c;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", a[i, j]);
            }

            for (int i = 0; i < 3; i++)
            {
                max = a[0, i];
                c = 0;
                for (int j = 0; j < 3; j++)
                {

                    if (a[j, i] > max)
                    {
                        max = a[j, i];
                        c = j;
                        Console.WriteLine(max);
                    }
                }
                a[c, i] = a[i, i];
            }
            Console.WriteLine("Netice\n\n\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", a[i, j]);
            }
           
            Console.ReadLine();
            */

        }
    }
}
    
