using System;
using System.Collections.Generic;

namespace mirtav1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int e = 0;
                int pos;
                int[] arr = new int[5] { 35, 50, 55, 77, 98 };

                Console.WriteLine("silinmezden evvel:");
                for (e = 0; e < 5; e++)
                {
                    Console.WriteLine("Element[" + (e) + "]: " + arr[e]);
                }

                // silinecek element
                pos = 3;
                // elementlerin kocurulmesi
                for (e = pos - 1; e < 4; e++)
                {
                    arr[e] = arr[e + 1];
                }
                Console.WriteLine("silindikden sonra: ");
                for (e = 0; e < 4; e++)
                {
                    Console.WriteLine("Element[" + (e + 1) + "]: " + arr[e]);
                }
                Console.WriteLine();
              

                const int n = 4, m = 5;
                int[,] a = new int[n, m];
                List<int> b = new List<int>();
                Random t = new Random();
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        a[i, j] = t.Next(0, 20);



                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < m; j++)
                        Console.Write("{0}\t", a[i, j]);
                }



                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (a[i, j] > 5 && a[i, j] < 10)
                            b.Add(a[i, j]);



                Console.WriteLine("\n\n");




                for (int i = 0; i < b.Count; i++)
                {
                    Console.Write("{0}\t", b[i]);
                }




                Console.WriteLine("\n\n");
                foreach (int d in b)
                    Console.Write("{0}\t", d);




                Console.Read();
            }


            }
        }
    }

