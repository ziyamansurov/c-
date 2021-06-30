using System;
using System.Collections.Generic;

namespace lab7_9
{ }
class Program
{
    

    static void Main(string[] args)
    {
        kvtenliy();
        list();
       // lab_8();
        swch();//lab 8 switchli
        lab_9();




    }
    public static void list()
    {
        string[] m = new string[] { "Java", "JavaScript", "python", "c++", "c#" };
        LinkedList<string> SIYAHI2 = new
        LinkedList<string>(m);
        LinkedListNode<string> indeks;



        SIYAHI2.AddAfter(SIYAHI2.First, "PHP");
        Console.WriteLine("AddAfter emeliyyatindan sonra: ");
        for (indeks = SIYAHI2.First; indeks != null; indeks = indeks.Next)
            Console.Write(indeks.Value + "\t");



        SIYAHI2.AddBefore(SIYAHI2.Last, "Scala");
        Console.WriteLine("\n\nAddBefore emeliyyatindan sonra: ");
        for (indeks = SIYAHI2.First; indeks != null; indeks = indeks.Next)
            Console.Write(indeks.Value + "\t");



        SIYAHI2.AddFirst("Go");
        Console.WriteLine("\n\nAddFirst emeliyyatindan sonra: ");
        for (indeks = SIYAHI2.First; indeks != null; indeks = indeks.Next)
            Console.Write(indeks.Value + "\t");



        SIYAHI2.AddLast("c");
        Console.WriteLine("\n\nAddLast emeliyyatindan sonra: ");
        for (indeks = SIYAHI2.First; indeks != null; indeks = indeks.Next)
            Console.Write(indeks.Value + "\t");



        SIYAHI2.RemoveFirst();
        Console.WriteLine("\n\nRemoveFirst emeliyyatindan sonra: ");
        for (indeks = SIYAHI2.First; indeks != null; indeks = indeks.Next)
            Console.Write(indeks.Value + "\t");



        SIYAHI2.RemoveLast();
        Console.WriteLine("\n\nRemoveLast emeliyyatindan sonra: ");
        for (indeks = SIYAHI2.Last; indeks != null; indeks = indeks.Previous)
            Console.Write(indeks.Value + "\t");



    }

    public static void kvtenliy()
    {
        Console.WriteLine("lab_9"); double a , b, c;
        double ilkemsal, q1, q2, ikinciemsal, ucuncuemsal = 10;
        Console.WriteLine("ilkemsali daxil edin");
        a = Convert.ToDouble(Console.ReadLine());
       
        Console.WriteLine("ikinciemsali daxil edin");
      b = Convert.ToDouble(Console.ReadLine());
       
        Console.WriteLine("ucuncuemsal daxil edin");
        c = Convert.ToDouble(Console.ReadLine());

       

        if (b * b - 4 * a * c > 0)
        {

        
        double d = Math.Sqrt((b * b) - (4 * a * c));
            double x1 = (-b - d) / 2 * a, x2 = (-b + d) / 2 * a;
            Console.WriteLine("x1={0}\tx2={1}", x1, x2);
        }

        
        else Console.WriteLine("duzgun daxil edin");
        Console.WriteLine("lab_7\n\n");
        list();


      

    }
    public static void lab_8()
    {
        const int n = 5; int i, yeni, x;
        int[] a = new int[n];
        Console.WriteLine("{0,45}", "XETTI NIZAMLAMA: ");

        // Təsadüfi ədədlərin yaradılması
        Random r = new Random();
        Console.WriteLine("\nTesadufi ededler massivi: ");
        for (i = 0; i < n; i++)
        {
            a[i] = r.Next(1, 10);
            Console.Write(a[i] + "\t");
        }
        Console.Write("\n------------------------\n");

        // Xətti nizamlama
        for (i = 0; i < n; i++)
        {
            for (yeni = i + 1; yeni < n; yeni++)
            {
                if (a[i] < a[yeni])
                {
                    x = a[i];
                    a[i] = a[yeni];
                    a[yeni] = x;
                }
            }
        }
        Console.WriteLine("\nNizamlanmiş massiv:");
        for (i = n - 1; i >= 0; i--)
            Console.Write(a[i] + "\t");
    }
    public static void swch()
    {


        int e;



        const int n = 20; int i, yeni, x;
        int[] a = new int[n];
        Console.WriteLine("{0,45}", "XETTI NIZAMLAMA: ");

        // Təsadüfi ədədlərin yaradılması
        Random r = new Random();
        Console.WriteLine("\nTesadufi ededler massivi: ");
        for (i = 0; i < n; i++)
        {
            a[i] = r.Next(100,3000);
            Console.Write(a[i] + "\t");
        }
         Console.Write("\n------------------------\n");

        // Xətti nizamlama
        for (i = 0; i < n; i++)
        {
            for (yeni = i + 1; yeni < n; yeni++)
            {
                if (a[i] < a[yeni])
                {
                    x = a[i];
                    a[i] = a[yeni];
                    a[yeni] = x;
                }
            }
        }
        Console.WriteLine();

        do
        {
            Console.WriteLine("artan ardiciliq ucun 1");
            Console.WriteLine("azalan ardiciliq ucun 2");
            Console.WriteLine("cixmaq ucun 3");


            e = int.Parse(Console.ReadLine());
            switch (e)
            {
                case 1:


                    Console.WriteLine("\nartma sirasi:");
                    for (i = n - 1; i >= 0; i--)
                        Console.Write(a[i] + "\t");

                    break;
                case 2:
                    Console.WriteLine("\nazalma sirasi:");
                  
                    for (i = 0; i < n; i++)
                        Console.Write(a[i] + "\t");

                    break;
            }
            Console.WriteLine("\n");
           

        }
        while (e != 3);


    }
    static double F, FT;

    static void Func(double x)
    {
        F = x * x * x * x + 7 * x * x + 10; // Funksiya
    }

    static void FuncT(double x)
    {
        FT = 4 * x * x * x + 14 * x; // Funksiyanın törəməsi
    }

    public static void lab_9()
    {
        double x0, x1, b, e, t;
        int i;
        const int max_iter = 100; // iteras.
                                  // maksimal sayı
        Console.Write(" Nyuton usulu:\n");
        Console.Write("\nBashlangic qiymeti daxil edin x = ");

        x0 = Convert.ToDouble(
        Console.ReadLine());
        Console.Write("Deqiqliyi daxil edin eps = ");

        e = Convert.ToDouble(
        Console.ReadLine());

        Console.WriteLine("\n");
        string s = new string('-', 38);

        x1 = x0;
        i = 0;

        do
        {
            b = x1;
            i++;
            Func(b); double F1 = F;
            FuncT(b); double FT1 = FT;
            t = F1 / FT1;
            x1 = b - t;
            Func(x1);
            Console.WriteLine(s);
            Console.WriteLine("Iterasiya {0,3}: x ={1,10:f6}", i, x1);
            Console.Write("\ndeqiqlik={0,10:f6}  ,",
            Math.Abs(t));
            Console.Write(" F(x)={0,10:f6}  ", F);
            Console.WriteLine("\n");
        }
        while ((Math.Abs(t) >= e) && (i < max_iter));
        Console.WriteLine();

        if ((Math.Abs(t) <= e) || (i < max_iter))
            Console.WriteLine("Tenliyin koku:x ={0,10:f6}", x1);
        else Console.WriteLine("CAVAB TAPILMADI!!! {0,3}sayda iterasiyaya proses yigilmadi", max_iter);

        Console.Read();
    }

}



