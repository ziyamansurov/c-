using System;
using System.Collections.Generic;
namespace coxluqlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // A və B çoxluqlarının yaradılması
            SortedSet<char> A = new SortedSet<char>();
            SortedSet<char> B = new SortedSet<char>();



            A.Add('A');
            A.Add('B');
            A.Add('C');
            A.Add('Z');
            Chox_GOSTER(A, "A choxlugu: ");



            B.Add('X');
            B.Add('Y');
            B.Add('Z');
            Chox_GOSTER(B, "B choxlugu:");



            A.SymmetricExceptWith(B);
            Chox_GOSTER(A, "Her iki choxluga daxil olmayan elementler: ");



            A.UnionWith(B);
            Chox_GOSTER(A, "Choxluqlarin birleshdirilmesi: ");



            A.ExceptWith(B);
            Chox_GOSTER(A, "Choxluqlarin chixilmasi: ");



            A.Add('G');
            Chox_GOSTER(A, "Choxluga G elementinin elave edilmesi: ");



            A.Remove('A');
            Chox_GOSTER(A, "Choxluqdan A elementinin ilinmesi: ");



        }



         static void Chox_GOSTER(SortedSet<char> ss, string s)
         {
             Console.WriteLine(s);
             foreach (char ch in ss)
                 Console.Write(ch + " ");
             Console.WriteLine("\n");







         }
     }
    }

