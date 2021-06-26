using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] a = new double[2, 2] { { 1, 1 }, { 3, 4 } };
            //double[,] b = new double[2, 3] { { 6, 7, 8 }, { 1, 2, 3 } };
            //double[,] c = new double[2, 3];
            //int i, j, k;
            //double s;

            //    for (k = 0; k < 3; k++)
            //    {
            //        for (i = 0; i < 2; i++)
            //        {
            //            s = 0;
            //            for (j = 0; j < 2; j++)
            //                s = s + a[i, j] * b[j, k];
            //            c[i, k] = s;
            //        }
            //    }
            //    Console.Write("\n\n\n*** C=A*B matrisi * ***:\n\n");
            //    for (i = 0; i < 2; i++)
            //    {
            //        for (j = 0; j < 3; j++)
            //            Console.Write(c[i, j] + "\t");
            //        Console.WriteLine();
            //    }
            //Console.WriteLine(("").PadLeft(500,'+'));
            String[] strings = { "This is a string.", "Hello!", "Nothing.",
                           "Yes.", "randomize" };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("'{0}' ends in a period: {1}",
                                  value, endsInPeriod);

            }
        }
    }
}


  
