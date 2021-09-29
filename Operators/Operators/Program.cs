using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama operatörleri
            //=(atama) operatörü bir değişkene herhangi bir değer atamak için kullanılır.
            //*=, /=, +=, -=, &=, ^=, |= gibi operatörlere işlemli atama operatörü denir.Kullanımı şu şekildedir;


            int a = 10;
            int b = 20;

            b +=3; // yada b = b+2; şeklinde de yazılabilir.
            Console.WriteLine(b);

            b /= 3;
            Console.WriteLine(b);

            a *= 2;
            Console.WriteLine(a);

            //Mantıksal Operatörler
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) // &&(ve) operatörü iki değerin ikisi de doğru ise doğru, en az birisi yanlış ise yanlış değerini döndürür.

            {
                Console.WriteLine("Perfect");
            }
            if (isSuccess || isCompleted) // ||(veya) operatörü iki değerden birisi doğru ise doğru, ikisi de yanlış ise yanlış değerini döndürür ayrıca önceliği en az olan mantıksal operatördür.
            {
                Console.WriteLine("Great");
            }
            if (isSuccess && !isCompleted) // !(değil) operatörü aritmetik operatörlerden (++)arttırma ve (--)eksiltme operatörleri ile eşit önceliklidir.
            {
                Console.WriteLine("Fine");
            }

            //Karşılaştırma operatörleri
            //<(küçüktür), >(büyüktür), <=(küçük veya eşittir), >=(büyük veya eşittir), ==(eşittir), !=(eşit değildir)

            int c = 3;
            int d = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = c > d;
            Console.WriteLine(sonuc);
            sonuc = c >= d;
            Console.WriteLine(sonuc);
            sonuc = c <= d;
            Console.WriteLine(sonuc);
            sonuc = c == d;
            Console.WriteLine(sonuc);
            sonuc = c != d;

            //Aritmetik operatörler
            //+ , ‐ , * , /, ++ , -- ve % aritmetik  operatörlerdir.

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
