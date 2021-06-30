using System;

namespace alqoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            const int t = 3, z = 3;
            int[,] d = new int[t, z] { { 4, 6, 3 }, 
                                       { 65, 7, 8 }, 
                                       { 9, 8, 9 } };
            int cem = d[0, 0];
            for (int i = 0; i < t; i++)
            {

                for (int j = 0; j < z; j++)
                {
                    cem += d[i, j];
                }

            }
            Console.WriteLine(cem);
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    Console.Write("\t" + d[i, j]);
                }
                Console.WriteLine();
            }
        
            Console.WriteLine((" ").PadRight(79,'#'));
            const int n = 3, m = 3;
            int[,] a = new int[n, m] { { 4, 0, 6 }, { 8, -6, 0 }, { 23, -22, 67 } };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();


            }
            Console.Write(a[1, 2]);
            //0 dan kicik olanlari kvadrata yukseldir
            //0 dan boyuk olanlari 2 ye vurur
            //0 olanlarada 5 elave edir
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < 0) a[i, j] = a[i, j] * a[i, j];
                    else if (a[i, j] > 0) a[i, j] = a[i, j] * 2;
                    else a[i, j] = a[i, j] + 5;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }
          


        }

    }
}
