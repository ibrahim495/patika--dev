using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // list.Add("Ayşe");
            // list.Add(2);
            // list.Add(true);
            // list.Add('A');

            //Elemanlara erişim
            // Console.WriteLine(list[1]);
            // foreach (var l in list)
            // {
            //     Console.WriteLine(l);
            // }

            Console.WriteLine("*****AddRange*****");
            //AddRange
            //string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1, 8, 3, 7, 9, 92, 5};
            //list.AddRange(renkler);
            list.AddRange(sayılar);
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Sort*****");
            //Sort
            list.Sort(); //-> hepsi farklı türden olduğu için hata verecektir 
                        //o yüzden listelerin birini yorum satırı yaptık
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Binary Search*****");
            //Binary Search
            Console.WriteLine(list.BinarySearch(9));

            Console.WriteLine("*****Reverse*****");
            //Reverse
            list.Reverse();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Clear*****");
            //Clear
            list.Clear();
            
            foreach (var item in list)
            {
                Console.WriteLine(list);
            }

            Console.ReadKey();
        }
    }
}
