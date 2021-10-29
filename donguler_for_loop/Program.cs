using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen sayiya kadar olan tek sayilari yazdiriniz
            Console.Write("sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayi; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine("*****************************************");

            //1 den 1000 e kadar olan tek ve çift sayilarin kendi arasindaki toplamlarini yazdiriniz
            int tekToplam = 0, ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i % 2 == 0)
                    ciftToplam += i;
                if(i % 2 == 1)
                    tekToplam += i;
            }
            Console.WriteLine("cift sayilarin toplami : " + ciftToplam);
            Console.WriteLine("tek sayilarin toplami : " + tekToplam);

            Console.WriteLine("*****************************************");

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************************************");

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
