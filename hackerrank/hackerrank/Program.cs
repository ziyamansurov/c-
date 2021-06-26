using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hackerrank
{
    class Program
    {
        
        public static void arrayssum()
        {
            int n;
            int sum = 0;
            Random r = new Random();
            n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = r.Next(0, 1000);
            }
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine(("*").PadRight(100, '-'));

            Console.WriteLine(sum);
        }static void Main(string[] args)
        {
            arrayssum();
        }
    }
}
