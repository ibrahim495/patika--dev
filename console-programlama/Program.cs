using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("isminizi giriniz :");
            string ad = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("merhaba " + ad + " " + soyad);

            Console.ReadKey();
        }
    }
}
