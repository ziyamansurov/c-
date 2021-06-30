using System;

namespace dinamikmassiv
{
    class Program
    {
        static void Main(string[] args)
        {
       


                double[,] b = new double[4, 3];

                double[,] c = new double[3, 3];
                double[,] a = new double[3, 4];

                int i, j, k;

                double s;

                Console.Write("* A ve B matrislerinin hasili * **\n\n");


                Console.Write("a matrisinin elementlerini daxil edin:\n\n");



                for (i = 0; i < 3; i++)

                {

                    Console.Write(i + "–ci setir elementlerini daxil edin:\n");

                    for (j = 0; j < 4; j++)

                        a[i, j] = Convert.ToDouble(Console.ReadLine());
                }



                Console.Write("\n\nb matrisinin elementlerinidaxil edin:\n\n");

                for (i = 0; i < 4; i++)

                {

                    Console.Write(i + "–ci setir elementlerini daxil edin:\n");

                    for (j = 0; j < 3; j++)

                        b[i, j] = Convert.ToDouble(Console.ReadLine());

                }

                for (k = 0; k < 3; k++)

                {

                    for (i = 0; i < 3; i++)

                    {

                        s = 0;

                        for (j = 0; j < 4; j++)

                            s = s + a[i, j] * b[j, k];

                        c[i, k] = s;

                    }

                }

                Console.Write("\n\n\n**  C=A*B matrisi * **:\n\n");
                for (i = 0; i < 3; i++)

                {

                    for (j = 0; j < 3; j++)

                        Console.Write(c[i, j] + "\t");

                    Console.WriteLine();

                }
                double min = c[0, 0];
                for (i = 0; i < 3; i++)

                {

                    for (j = 0; j < 3; j++)
                        if (c[i, j] < min) min = c[i, j];



                }
                Console.WriteLine("min=" + min);
            Console.ReadLine();
            }
        }
    }

  