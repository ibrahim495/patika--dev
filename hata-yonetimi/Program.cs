using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayi: " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı.");
            }

            Console.WriteLine("**********************************************************");

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("bos deger girdiniz.");
                Console.WriteLine(ex);
            }

            Console.WriteLine("**********************************************************");

            try
            {
                int b = int.Parse("test");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi uygun degil.");
                Console.WriteLine(ex);
            }

            Console.WriteLine("**********************************************************");

            try
            {
                int c = int.Parse("-20000000000");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çok büyük ya da çok küçük deger girdiniz.");
                Console.WriteLine(ex);
            }


            Console.ReadKey();
        }
    }
}
