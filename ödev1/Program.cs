using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****İLK SORU*****");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının 
            //girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("kaç adet sayi gireceksiniz? ");
            int adet = int.Parse(Console.ReadLine());            
            int[] sayilar = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"sayilar[{i+1}] = ");
                sayilar[i] = int.Parse(Console.ReadLine());                
            }
            
            for (int i = 0; i < adet; i++)
            {
                if(sayilar[i] % 2 == 0)
                    Console.WriteLine(sayilar[i]);
            } 

            Console.WriteLine("*****İKİNCİ SORU*****");
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş 
            //olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın            
            Console.Write("kaç adet sayi gireceksiniz? ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("sayi giriniz: ");
            int m = int.Parse(Console.ReadLine());
            TamBolen(n,m);

            Console.WriteLine("*****ÜÇÜNCÜ SORU*****");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini 
            //yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.Write("kaç adet kelime gireceksiniz? ");
            int n1 = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.Write($"kelimeler[{i+1}] = ");
                kelimeler[i] = Console.ReadLine();
            }

            foreach (string k in kelimeler)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("*****DÖRDÜNCÜ SORU*****");
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("metin giriniz: ");
            string metin = Console.ReadLine();
            metin.KelimeSayisi();

            metin.HarfSayisi();

            Console.ReadKey();
        }
        public static void TamBolen(int n, int m)
        {
            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"sayilar[{i+1}] = ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if(sayilar[i] == m || sayilar[i] % m == 0)
                    Console.WriteLine(sayilar[i]);
            }
        }        
    }
    public static class Extension
    {
        public static void KelimeSayisi(this string param)
        {
            
            string[] kelime = param.Split(" ");
            Console.WriteLine("kelime sayisi: " + kelime.Length);
        }
        public static void HarfSayisi(this string param)
        {        
            string[] kelime = param.Split(" ");  
            string harf = string.Join("", kelime);         
            Console.WriteLine("metindeki harf sayisi: " + harf.Length);       
        }
    }
}
