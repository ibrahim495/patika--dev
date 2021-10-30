using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Özyinelemeli
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new();

            int sonuc = instance.Expo(3,4);
            Console.WriteLine(sonuc);

            //Extension Metotlar
            string ifade = "İbrahim Reyhani";
            bool sonuc2 = ifade.CheckSpaces();
            Console.WriteLine(sonuc2);

            if (sonuc2)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {2, 15, 65, 4, 84, 6};
            //sıralama
            Console.WriteLine("*****sıralama*****");
            dizi.ArraySort();
            dizi.EkranaYazdir();
            
            //çift sayıları yazdırma
            Console.WriteLine("*****çift sayıları yazdırma*****");
            dizi.IsEvenNumber();

            //ilk karakteri almak
            Console.WriteLine("*****ifadenin ilk karakterini al*****");
            Console.WriteLine(ifade.GetFirstCharacter());
            
            Console.ReadKey();
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs < 2)
                return sayi;
            return sayi * Expo(sayi, üs - 1);
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] ArraySort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int p in param)
                Console.WriteLine(p);
        }
        public static void IsEvenNumber(this int[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                if(param[i] % 2 == 0)
                    Console.WriteLine(param[i]);
            }
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
