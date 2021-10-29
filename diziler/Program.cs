using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

            int[] dizi;
            dizi = new int[5];

            // dizilere değer atama ve erişme
            renkler[0] = "mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // döngülerle dizi
            // klavyeden girilen n tane sayinin ortalamasını hesaplayan program
            Console.Write("lütfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write($"dizi[{i+1}] = ");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var s in sayiDizisi)
            {
                toplam += s;
            }
            Console.WriteLine($"ortalama = {toplam/diziUzunlugu}");

            Console.ReadKey();
        }
    }
}
