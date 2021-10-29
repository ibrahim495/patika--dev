using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den girilen sayiya kadar olan sayilarin ortalaması
            Console.Write("sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            float toplam = 0;
            while (sayac <= sayi)
            {
                 toplam += sayac;
                 sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar olan tüm harfleri ekrana yazdırın
            char character = 'a';
            while (character <= 'z')
            {
                 Console.Write($"{character,3}");
                 character++;
            }

            Console.WriteLine();

            //foreach
            string[] arabalar = {"Ford", "Mazda", "Toyota"};

            foreach (var a in arabalar)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
