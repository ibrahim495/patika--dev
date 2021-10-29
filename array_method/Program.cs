using System;

namespace array_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 7};
            
            Console.WriteLine("*****sirasiz dizi*****");
            foreach (var s in sayiDizisi)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("*****sirali dizi*****");
            Array.Sort(sayiDizisi);
            foreach (var s in sayiDizisi)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("*****array clear*****");
            //clear
            Array.Clear(sayiDizisi,2,2); //2. indeksten itibare 2 tane elemanı 0 lar.
            foreach (var s in sayiDizisi)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("*****reverse*****");
            //reverse
            int[] sayiDizisi2 = {23, 12, 4, 86, 72, 3, 11, 7};
            Array.Reverse(sayiDizisi2);
            foreach (var s2 in sayiDizisi2)
            {
                Console.WriteLine(s2);
            }

            Console.WriteLine("*****indexOf*****");
            //indexOf
            Console.WriteLine(Array.IndexOf(sayiDizisi2, 23));

            Console.WriteLine("*****Resize*****");
            //Resize
            Array.Resize(ref sayiDizisi2, 9); // yeniden boyutlandırdı, 9 elemanlı oldu
            sayiDizisi2[8] = 99;
            foreach (var s2 in sayiDizisi2)
            {
                Console.WriteLine(s2);
            }

            Console.ReadKey();
        }
    }
}
