using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine("*****Eleman sayısı*****");
            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            Console.WriteLine("*****Foreach ile elemanlara erişim*****");
            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            Console.WriteLine("*****List.ForEach ile elemanlara erişim*****");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("*****Listeden eleman çıkarma*****");
            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("*****indeks ile listeden eleman çıkarma*****");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("*****Liste içerisinde arama*****");
            //Liste içerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu.");
            
            Console.WriteLine("*****Eleman ile indekse erişme*****");
            //Eleman ile indekse erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            Console.WriteLine("*****Diziyi List e çevirme*****");
            //Diziyi List e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            Console.WriteLine("*****Listeyi temizleme*****");
            //Listeyi temizleme
            List<string> hayvanListesi = new List<string>(hayvanlar);
            hayvanListesi.Clear();

            Console.WriteLine("*****List içerisinde nesne tutmak (Class ile)*****");
            //List içerisinde nesne tutmak (Class ile)
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Console.WriteLine("*****1. YÖNTEM*****");
            //1. YÖNTEM
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılaz";
            kullanıcı1.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("kullanıcı adı = " + kullanıcı.Isim);
                Console.WriteLine("kullanıcı soyadı = " + kullanıcı.Soyisim);
                Console.WriteLine("kullanıcı yaşı = " + kullanıcı.Yas);
            }

            Console.WriteLine("*****2. YÖNTEM*****");
            //2. YÖNTEM
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var yeni in yeniListe)
            {
                Console.WriteLine("kullanıcı adı = " + yeni.Isim);
                Console.WriteLine("kullanıcı soyadı = " + yeni.Soyisim);
                Console.WriteLine("kullanıcı yaşı = " + yeni.Yas);
            }
                

            Console.ReadKey();
        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
