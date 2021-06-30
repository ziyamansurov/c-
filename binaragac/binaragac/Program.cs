using System;



namespace binar2
{
    public enum BinSide
    {
        Left,
        Right
    }



    public class BinarAgac
    {
        public long? Data { get; private set; }
        public BinarAgac SOL { get; set; }
        public BinarAgac SAG { get; set; }
        public BinarAgac Valideyn { get; set; }



        public void Insert(long data)
        {
            if (Data == null || Data == data)
            {
                Data = data;
                return;
            }
            if (Data > data)
            {
                if (SOL == null) SOL = new BinarAgac();
                Insert(data, SOL, this);
            }
            else
            {
                if (SAG == null) SAG = new BinarAgac();
                Insert(data, SAG, this);
            }
        }



        private void Insert(long data, BinarAgac
        node, BinarAgac parent)
        {



            if (node.Data == null || node.Data == data)
            {
                node.Data = data;
                node.Valideyn = parent;
                return;
            }
            if (node.Data > data)
            {
                if (node.SOL == null)
                    node.SOL = new BinarAgac();
                Insert(data, node.SOL, node);
            }
            else
            {
                if (node.SAG == null)
                    node.SAG = new BinarAgac();
                Insert(data, node.SAG, node);
            }
        }



        private void Insert(BinarAgac data,
        BinarAgac node, BinarAgac parent)
        {



            if (node.Data == null ||
            node.Data == data.Data)
            {
                node.Data = data.Data;
                node.SOL = data.SOL;
                node.SAG = data.SAG;
                node.Valideyn = parent;
                return;
            }
            if (node.Data > data.Data)
            {
                if (node.SOL == null)
                    node.SOL = new BinarAgac();
                Insert(data, node.SOL, node);
            }
            else
            {
                if (node.SAG == null)
                    node.SAG = new BinarAgac();
                Insert(data, node.SAG, node);
            }
        }



        private BinSide? MeForParent(BinarAgac
        node)
        {
            if (node.Valideyn == null) return null;
            if (node.Valideyn.SOL == node)
                return BinSide.Left;
            if (node.Valideyn.SAG == node)
                return BinSide.Right;
            return null;
        }



        public void Remove(BinarAgac node)
        {
            if (node == null) return;
            var me = MeForParent(node);
            // Əgər düyündə törəmə element yoxdursa,
            // onu cəsarətlə pozmaq olar
            if (node.SOL == null && node.SAG == null)
            {
                if (me == BinSide.Left)
                {
                    node.Valideyn.SOL = null;
                }
                else
                {
                    node.Valideyn.SAG = null;
                }
                return;
            }
            //Əgər sol törəmə yoxdursa, onda sağ
            // törəmə silinənin yerinə qoyulur
            if (node.SOL == null)
            {
                if (me == BinSide.Left)
                {
                    node.Valideyn.SOL = node.SAG;
                }
                else
                {
                    node.Valideyn.SAG = node.SAG;
                }



                node.SAG.Valideyn = node.Valideyn;
                return;
            }
            //Əgər sağ törəmə yoxdursa, onda sol
            // törəmə silinənin yerinə qoyulur
            if (node.SAG == null)
            {
                if (me == BinSide.Left)
                {
                    node.Valideyn.SOL = node.SOL;
                }
                else
                {
                    node.Valideyn.SAG = node.SOL;
                }



                node.SOL.Valideyn = node.Valideyn;
                return;
            }



            //Əgər hər iki törəmə düyün olarsa
            //onda sağı silinənin yerinə qoyuruq
            //solu isə sağa qoyuruq



            if (me == BinSide.Left)
            {
                node.Valideyn.SOL = node.SAG;
            }
            if (me == BinSide.Right)
            {
                node.Valideyn.SAG = node.SAG;
            }
            if (me == null)
            {
                var bufLeft = node.SOL;
                var bufRightLeft = node.SAG.SOL;
                var bufRightRight = node.SAG.SAG;
                node.Data = node.SAG.Data;
                node.SAG = bufRightRight;
                node.SOL = bufRightLeft;
                Insert(bufLeft, node, node);
            }
            else
            {
                node.SAG.Valideyn = node.Valideyn;
                Insert(node.SOL, node.SAG, node.SAG);
            }
        }



        public void Remove(long data)
        {
            var removeNode = Find(data);
            if (removeNode != null)
            {
                Remove(removeNode);
            }
        }



        public BinarAgac Find(long data)
        {
            if (Data == data) return this;
            if (Data > data)
            {
                return Find(data, SOL);
            }
            return Find(data, SAG);
        }



        public BinarAgac Find(long data,
        BinarAgac node)
        {
            if (node == null) return null;



            if (node.Data == data) return node;
            if (node.Data > data)
            {
                return Find(data, node.SOL);
            }
            return Find(data, node.SAG);
        }



        public long CountElements()
        {
            return CountElements(this);
        }



        private long CountElements(BinarAgac
        node)
        {
            long count = 1;
            if (node.SAG != null)
            {
                count += CountElements(node.SAG);
            }
            if (node.SOL != null)
            {
                count += CountElements(node.SOL);
            }
            return count;
        }
    }



    public class AgacGoster
    {



        public static void Print(BinarAgac node)
        {



            if (node != null)
            {



                if (node.Valideyn == null)
                {
                    Console.WriteLine("ROOT:{0}",
                    node.Data);
                }
                else
                {



                    if (node.Valideyn.SOL == node)
                    {
                        Console.WriteLine("Sol for {1} --> {0}", node.Data, node.Valideyn.Data);
                    }



                    if (node.Valideyn.SAG == node)
                    {
                        Console.WriteLine("Sag for {1} --> {0}", node.Data, node.Valideyn.Data);
                    }
                }



                if (node.SOL != null)
                {
                    Print(node.SOL);
                }



                if (node.SAG != null)
                {
                    Print(node.SAG);
                }
            }
        }
    }



    class Program
    {



        static void Main(string[] args)
        {
            var tree = new BinarAgac();



            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(80);
            tree.Insert(29);
            tree.Insert(31);
            tree.Insert(32);
            tree.Insert(70);



            Console.WriteLine("Yaradilmis agac\n");



            AgacGoster.Print(tree);



            Console.WriteLine("Agacda elementlerin sayi = " + tree.CountElements());



            Console.WriteLine();
            Console.WriteLine(("").PadRight(35, '-'));



            // Yeni elementin əlavə edilməsi
            tree.Insert(15);
            Console.WriteLine("\nElement elave edildikden sonra agac:\n");
            AgacGoster.Print(tree);



            Console.WriteLine("Agacda elementlerin sayi = " + tree.CountElements());



            // Elementin silinməsi
            tree.Remove(20);



            Console.WriteLine();
            Console.WriteLine(("").PadRight(35, '-'));
            Console.WriteLine("\nElement silindikden sonra agac:\n");



            AgacGoster.Print(tree);



            Console.WriteLine("Agacda elementlerin sayi = " + tree.CountElements());



            Console.Read();
        }
    }
}
