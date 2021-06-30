using System;
using System.IO;
namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter mf = File.CreateText("E:\\lab5\\lab5.txt");
            mf.WriteLine("Şəhərin kodu    Şəhərin adı     Əhalinin sayı    Ərazisi   ");
            for(int i=1;i<=5;i++)
            { switch (i)
                {
                    case 1:mf.WriteLine("      {0}              Bakı            4mln           500 ",i);
                        break;
                    case 2:
                        mf.WriteLine("      {0}           Sumqayıt          1mln           200 ",i);
                        break;
                    case 3:
                        mf.WriteLine("      {0}              Ağsdafa           2mln           700 ",i);
                        break;
                    case 4:
                        mf.WriteLine("      {0}              Qazax           1mln           300 ",i);
                        break;
                    case 5:
                        mf.WriteLine("      {0}             Tovuz           1.5mln           600 ",i);
                        break;

                }
                    
                    }
            mf.Close();
            StreamReader mr=File.OpenText("E:\\lab5\\lab5.txt");
            while (true)
            {
                string sl = mr.ReadLine();
                if (sl == null) break;
                Console.WriteLine(sl);
            }
            Console.ReadLine();
            mr.Close();
        }
    }
}
