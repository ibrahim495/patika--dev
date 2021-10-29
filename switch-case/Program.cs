using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak");
                    break;
                case 2:
                    Console.WriteLine("şubat");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 4:
                    Console.WriteLine("nisan");
                    break;
                case 5:
                    Console.WriteLine("mayıs");
                    break;
                case 6:
                    Console.WriteLine("haziran");
                    break;
                case 7:
                    Console.WriteLine("temmuz");
                    break;
                case 8:
                    Console.WriteLine("ağustos");
                    break;
                case 9:
                    Console.WriteLine("eylül");
                    break;
                case 10:
                    Console.WriteLine("ekim");
                    break;
                case 11:
                    Console.WriteLine("kasım");
                    break;
                case 12:
                    Console.WriteLine("aralık");
                    break;
                default:
                    Console.WriteLine("yanlış veri girişi");
                    break;
            }

            switch (month)
            {
                 case 12:
                 case 1:
                 case 2:
                    Console.WriteLine("kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar mevsimi");
                    break;              
                default:
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
