using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler (Array) aynı veri tipinde belirtilen miktardaki elemanı içerisinde barındıran bir veri yapısıdır.
            // Dizi Tanımlama

            int[] numbers = new int[10]; //10 elemanlı int tipinde değerler tutabilecek bir dizi  
            string[] colors = new string[4]; //4 elamanlı renkleri tutabilecek string tipinde bir dizi 

            //Klavyeden girilen değerleri diziye atama
            int[] n1 = new int[3];
            Console.Write("1. sınav notunu gir : ");
            n1[0] = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sınav notunu gir : ");
            n1[1] = Convert.ToInt16(Console.ReadLine());
            Console.Write("3. sınav notunu gir : ");
            n1[2] = Convert.ToInt16(Console.ReadLine());

            //Döngüler ile dizi kullanımı

            int[] notlar = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + " . sınav notunu gir : ");
                notlar[i] = Convert.ToInt16(Console.ReadLine());
            }

        }
    }
}
