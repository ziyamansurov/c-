using System;

namespace alqoritm2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = 10, m = 10;
            //int r = 0, k = 0;
            //int[,] a = new int[n, m];
            //int[] b = new int[n];
            //int max=0;
            //Random t = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = t.Next(0, 500000);
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("\t" + a[i, j]);


                   
            //    } Console.WriteLine();
            //    max = a[0, 0];

            //    for (int o = 0; o < n; o++)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            if (a[o, j] > max)
            //            {
            //                max = a[o, j];
            //                r = o;
            //                k = j;

            //            }

            //        }
            //    }
            //}
              
            //    Console.WriteLine("{0} setrle {1} sutunun kesismesi max={2}",r,k,max);
                 

                 

              
      //           int[] a = new int[]  { 4, 5, 6,8,12,23,14 } ;
      //           int sum = 0;
      //           for (int i = 0; i < a.Length ; i++) 


      //              // for (int j = 0; j < 3; j++)
      //                   if (5 < a[i] && a[i] < 15)

      //                       sum += a[i];



      //Console.Write(sum);
                //  "{0}\t","\n",
                //for(int i=0;i) 
                 int[,] a = new int[3, 3]
                   { {5,9,7}, {67,7,45}, {89,45,5} };
                 int max; int c;
                 for (int i = 0; i < 3; i++)
                 {
                   
                     for (int j = 0; j < 3; j++)
                         Console.Write("\t"+ a[i, j]); 
                Console.WriteLine();
                 }

                 for (int i = 0; i < 3; i++)
                 {
                     max = a[i,0];

                Console.WriteLine(max);
                a[i, i] = max;
                     c = 0;
                     for (int j = 0; j < 3; j++)
                     {

                         if (a[j, i] > max)
                         {
                             max = a[j, i];
                             c = i;
                         } 
                     }
                    a[i, c] = a[i, i];
                 }
                 Console.WriteLine("Netice\n\n\n");
                 for (int i = 0; i < 3; i++)
                 {
                     Console.WriteLine();
                     for (int j = 0; j < 3; j++)
                         Console.Write("{0}\t", a[i, j]);
                 }


             }
            
        
    }
}
