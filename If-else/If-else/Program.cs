using System;

namespace If_else
{
    class Program
    {
        static void Main(string[] args)
        {

            //İf -Else karar yapıları belirli bir şarta bağlı olarak yerine getirilmesi istenen komutların çalıştırılması için kullanılmaktadır.
            //Bu şart kimi zaman iki farklı ihtimal olabileceği gibi, üç yada daha fazla koşulda olabilmektedir.

            int number;
            Console.Write("Lütfen bir sayı girin:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)

                Console.WriteLine("{0} sayısı pozitif bir sayıdır.", number);

            else if (number < 0)

                Console.WriteLine("{0} sayısı negatif bir sayıdır.", number);

            else

                Console.WriteLine("Girilen sayı 0'a eşittir.");

            Console.ReadKey();
        }
    }
}
