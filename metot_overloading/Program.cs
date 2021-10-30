using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplam);
            Console.WriteLine(toplam);

            //Metot Aşırı Yükleme
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade); // artık buna hata vermiyor

            //Metot imzası
            //Metot adi + parametre sayisi + parametre

            instance.EkranaYazdir("İbrahim", "Reyhani");

            Console.ReadKey();
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + " " + veri2);
        }
    }
}
