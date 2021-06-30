using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace siyahilar2
{
    class Program
    {
        static void Main(string[] args)
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
            for (indeks = SIYAHI2.First; indeks != null; indeks = indeks.Next)
                Console.Write(indeks.Value + "\t");
            Console.ReadLine();

        }
        //{ int a = int.Parse(Console.ReadLine());
        //    string yeniden= "yox";
        //    while (yeniden!= "yox") { 
        //        switch (a)
        //        {
        //            case 1:Console.WriteLine("sa");
        //                break;
        //            case 2:Console.WriteLine("saaa");
        //                break;


        //        }
        //    } 
        //int b = int.Parse(Console.ReadLine());
        //vod myObj = new vod();
        //Console.WriteLine(myObj.b);

    }
}
