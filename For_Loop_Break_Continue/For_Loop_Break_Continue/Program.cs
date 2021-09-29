using System;

namespace For_Loop_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR Döngüsü tekrarlanması istenilen kod satırının ya da kod bloğunun, belirtilen sayı kadar, belirlenen şart sağlanana kadar ve istenen artış ya da azalış sayısı kadar tekrarlanmasını sağlayan döngü yapısıdır.

            //1'den 100'e kadar olan tam sayıları ekrana yazdıralım.

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }


            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdıralım.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;  //tekToplam = tekToplam + i
                else
                    ciftToplam += i;  //ciftToplam = ciftToplam + i

            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);


            //BREAK-CONTINUE Döngülerin belirli bir yerinde döngüyü sonlandırmak (kırmak/çıkmak) veya belirli bir yerin altında ki komutların o seferlik atlanması istenebilir.

            for (int a = 1; 1 <= 10; a++)
            {
                if (a == 5)
                {
                    break; //a = 5 olduğunda döngüden çıkılacak.
                }
                Console.WriteLine(a);
            }
            for (int a = 1; 1 <= 10; a++)
            {
                if (a == 5)
                {
                    continue; // a = 5 olduğunda continue komutu çalışacak ve Console.WriteLine(a) komutu atlanacak böylece çıktıda 5 rakamı olmayacak.
                }
                Console.WriteLine(a);
            }

        }
    }
}
