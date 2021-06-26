using System;

namespace alqoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a= new int[] { 2, 3, 12, 4, 546547, 123 };
            int[] b = new int[6];
            int d;
            d = a[0];

            for (int i = 0; i < a.Length; i++)
            {

                //if (a[i] > d)
                //{
                //    b[i] = d;


                //}
                for (int j = 0; j < a.Length; j++)
                {

                    if (a[i] > a[j])
                    {
                        

                        a[j] = b[i];
                        continue;
                    }
                   
                }

            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine( b[i]);

            }
        }
    }
}
