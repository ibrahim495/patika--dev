using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            Console.WriteLine("*****Dizinin elemanlarına erişim*****");
            //Dizinin elemanlarına erişim
            Console.WriteLine(kullanıcılar[12]);

            foreach (var k in kullanıcılar)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("*****Count*****");
            //Count
            Console.WriteLine(kullanıcılar.Count);

            Console.WriteLine("*****Contains*****");
            //Contains
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("İbrahim Reyhani"));

            Console.WriteLine("*****Eleman çıkarma*****");
            //Remove
            kullanıcılar.Remove(12);

            foreach (var k in kullanıcılar)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("*****Keys*****");
            //Keys
            foreach (var k in kullanıcılar.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("*****Values*****");
            //Values
            foreach (var k in kullanıcılar.Values)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
