using System;

namespace Loop_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOREACH  Foreach döngüsü koleksiyonlar üzerinde kullanılır. Koleksiyon bir dizi veya bir liste olabilir. dizi/liste deki her eleman için çalıştırılır.

            string[] lesson = { "Html", "Css", "JavaScript", "Php" };

            foreach (string str in lesson)
            {
                Console.WriteLine(str);
            }

            //WHILE döngüsü içerisindeki koşul doğru (true) olduğu sürece tekrar eder. Koşul yanlış olduğunda döngüden çıkılır
            // Sayı 0 olana kadar, girilen sayılardan çift sayıları toplayıp,tek sayıları çıkarıp ekrana yazdıralım.
            int toplam = 0;
            int sayi = 0;
            while (true)
            {
                Console.Write("Sayıyı Girin : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }

                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
                else
                {
                    toplam -= sayi;
                }
            }

            Console.WriteLine("========================");
            Console.WriteLine("Sonuç : {0}", toplam);
            Console.ReadKey();
        }

    }
}
