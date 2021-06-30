using System;



namespace ConsoleApp1
{
    class Program
    {



        static void H(int n1, int n2, int n3, int n4, char[] s)
        {
            Random r = new Random();
            for (int i = 0; i < (n4 - n3) + (n2 - n1); i++)
            {
                int a = r.Next(0, (n4 - n3) + (n2 - n1));
                if (a <= (n2 - n1)) s[i] = (char)(a + n1);
                else s[i] = (char)(a + n1 + n3 - n2);
            }
        }



        static void Main(string[] args)
        {
            char[] s = new char[20];
            int n1 = 50, n2 = 60, n3 = 100, n4 = 110;
            H(n1, n2, n3, n4, s);
            Console.WriteLine();
            for (int i = 0; i < (n4 - n3) + (n2 - n1); i++)
                Console.Write(s[i] + " ");
            Console.Read();
        }
    }




}


