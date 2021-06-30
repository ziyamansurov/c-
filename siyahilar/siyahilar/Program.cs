using System;
namespace siyahilar
{
    class Program
    {
        class ListElem // Siyahı elementi sinfi
        {
            public int Value; // verilənlər sahəsi
            public ListElem Next; // növbəti
                                  // elementə keçid sahəsi



            // sinfin konstruktoru:
            public ListElem(ListElem next,
            int value)
            {
                Next = next; // sahənin doldurulması
                Value = value; // sahənin doldurulması
            }
        }
        class List // siyahılar sinfi
        {
            int value, count = 0;



            // siyahının başı:
            public ListElem head = null;



            // siyahının cari elementi:
            public ListElem current = null;
            public List() { } // boş konstruktor



            // siyahının başlanğıcına
            // elementin yerləşdirilməsi:
            public void Menu()
            {
                Console.Clear();
                Console.WriteLine("ESAS NENYU:");
                Console.WriteLine(" 1. Siyahini doldurmaq.");

                Console.WriteLine(" 2. Siyahiya baxmaq.");

                Console.WriteLine(" 3. Elementi silmek.");

                Console.WriteLine(" 4. Siyahini temizlemek.");

                Console.WriteLine(" 5. Çixiş.\n");
                Console.WriteLine("LAZİM OLAN MENYU BENDİNİ SEÇİN! \n");
            }



            // Siyahının başlanğıcına elementin
            // yerləşdirilməsi:
            public void FirstElem()
            {
                //Console.Clear();



                int n = 10;
                Console.WriteLine(n + " element daxil edin: ");
                for (int i = 0; i < n; i++)
                {
                    value = int.Parse(
                    Console.ReadLine());



                    //siyahının yeni elementinin yaradılması
                    // və onun qiymətlərlə doldurulması:
                    ListElem temp = new ListElem(null,
                    value);
                    if (head == null) // əgər siyahı
                                      // boşdursa
                        head = temp; // yeni element birinci
                                     // element olur
                    else
                    {
                        // yeni elementə birinci
                        //elementə istinadın əlavə edilməsi
                        temp.Next = head;
                        head = temp; // birinci elementin
                                     // yenidən yazılması
                        head = temp; // birinci elementin
                                     // yenidən yazılması
                    }
                }
                current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = head;
                count += 10;
            }



            // Siyahıya baxış metodu:
            public void Show()
            {
                //Console.Clear();
                Console.Write("Halqa şekilli bir istiqametli siyahi:\n");
                if (count == 0) // əgər siyahı boşdursa
                    Console.WriteLine("Siyahi boşdur!");
                else
                {
                    int counter1 = 0;
                    // yeni elementin yaradılması və
                    //ona birinci elementin yazılması
                    ListElem temp = head;
                    while (counter1 < count) // siyahının
                                             //sonuna kimi dövr
                    {
                        // cari qiymətin ekrana çıxarılması
                        Console.Write(temp.Value + " ");
                        temp = temp.Next; // növbəti
                                          // elementə keçid
                        counter1++;
                    }
                    Console.WriteLine("");
                }
            }



            // cari elementdən sağa yerləşdirmə:
            public void Right_Element()
            {
                // Console.Clear();
                if (head == null)
                {
                    Console.WriteLine("Siyahini doldurun!");
                }
                else
                {
                    int m = count;
                    current = head;
                    for (int i = 1; i < m; i++)
                        current = current.Next; // növbəti
                                                // elementə keçid
                    Console.WriteLine("Ededi daxil edin: ");

                    value = int.Parse(Console.ReadLine());
                    ListElem temp = new ListElem(null,
                    value);
                    temp.Next = current.Next;
                    current.Next = temp;
                    current = temp;
                    count++;
                }
            }



            // elementin silinməsi:
            public void Delete_Elements()
            {
                // Console.Clear();
                if (head != null)
                {
                    Show();
                    ListElem temp = head;
                    ListElem prev = head;
                    int i = 1;
                    Console.WriteLine("Siyahida mövqeni daxil edin:\n ");

                    int pos = int.Parse
                    (Console.ReadLine());
                    while (pos != i)
                    {
                        prev = temp;
                        temp = temp.Next;
                        i++;
                    }
                    if (head == temp)
                        head = head.Next;
                    else
                        prev.Next = temp.Next;
                    count--;
                }
                else
                    Console.WriteLine("Siyahi onsuz da boşdur!Neyi sileceksiniz ? ");
            }



            // siyahını təmizləmə metodu:
            public void Clear_list()
            {
                ListElem temp; int i = 0;
                while (i < count)
                {
                    temp = head.Next;
                    head = temp;
                    count--;
                }
            }
        }



        static void Main(string[] args)
        {
            List List = new List();
            List.Menu();
            int c = int.Parse(Console.ReadLine());
            while (c != 5)
            {
                switch (c)
                {
                    //siyahını doldurmaq:
                    case 1: List.FirstElem(); break;
                    //siyahıya baxmaq:
                    case 2: List.Show(); break;
                    //elementi silmək:
                    case 3: List.Delete_Elements(); break;
                    //siyahını təmizləmək:
                    case 4: List.Clear_list(); break;
                    //çıxış:
                    case 5: break;
                    default:
                        Console.Write("Bele nomreli menyu bendi yoxdur!"); break;
                }
                do Console.Write("\nDavam etmek uçun ENTER klavişini basin...");
                while (Console.ReadKey().Key !=
                ConsoleKey.Enter);
                List.Menu();
                c = int.Parse(Console.ReadLine());
            }
        }
    }
}
