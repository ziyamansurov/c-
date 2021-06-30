using System;
using System.Collections.Generic;
//using System.Threading.Tasks;


namespace bekarclq1
{
    class obyektyonlu {
        public string dil;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> diller = new List<string>();
           // element elave etmek
            diller.Add("JavaScript");
            diller.Add("Python");
            diller.Add("Scala");
            diller.Add("Java");
            diller.Add("c#");
            diller.Add(Console.ReadLine());
            //isdenilen yere elave etmek
            diller.Insert(2,"c++");
            int[] a = new int[diller.Count];
            //element silmek
            diller.Remove("c#");
            foreach (string item in diller )
            {
                Console.Write(item + " \n");
            }
            Console.WriteLine("\nmain dil: " + diller.Find(item => item == "JavaScript"));
            var obyektyonlu = new List<obyektyonlu>();
            obyektyonlu.Add(new obyektyonlu() { dil="c#"});
            obyektyonlu.Add(new obyektyonlu() { dil = "scala" });
            obyektyonlu.Add(new obyektyonlu() { dil = "java" });

        }

    }
}
