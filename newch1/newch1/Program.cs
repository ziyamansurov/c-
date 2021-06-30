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


            b[i] = max;

       
            
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<m; j++)
                {
                    Console.Write("\t"+a[i, j]);

                }
    Console.WriteLine();
 } Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0},setirindeki max element={1}",i,b[i]);
            }
            Console.ReadLine();
 }









            /*int[,] a = new int[3, 3] { { 34, -8, 4 }, { 3, 9, -3 }, { 23, -67, 5 } };

            Console.WriteLine("ilkin matris\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(a[i, j] + "\t");

                Console.WriteLine();
            }
            int min;
            int [] b =new int [a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++) {
                min = a[i, 0];
                
                for (int j = 0; j <a.GetLength(1); j++)
                {

                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        
                        
                    }
                    b[i] = min;
                    
                }Console.WriteLine();
             
            
            } int max = b[0];
            for(int i = 0; i < a.GetLength(0); i++)
            {if (b[i] > max) max = b[i];

            }
            Console.WriteLine(max);
            Console.ReadLine();
            /*int d, cem = 0;
           
            for (int i = 0; i < 2; i++)
            {
                d = a[0, i];
                for (int j = 0; j < 2; j++)
                {
                    if (5< d)
                    {
                        cem += d;
                    }

                }

               Console.WriteLine(cem);*/

                //Console.WriteLine("a={0,8:F4}\nb={1,3:F2}",a,b);*/

            
            Console.ReadLine();
        }
    }
}

