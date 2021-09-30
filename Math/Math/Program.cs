using System;

namespace Math
{
    class Program
    {
        private static object sayi;

        static void Main(string[] args)
        {
            //Matematiksel işlemler için Math sınıfını kullanırız.

            Console.WriteLine(Math.Abs(-98)); // Girilen sayının mutlak değerini alır.

            Console.WriteLine(Math.Max(27, 8));// Girilen sayılardan en büyüğünü bulur.

            Console.WriteLine(Math.Min(27, 8));// Girilen sayılardan en küçüğünü bulur.

            Console.WriteLine(Math.Round(35.3));//Girilen sayıyı en yakın tamsayıya yuvarlar

            Console.WriteLine(Math.Sin(90));//Girilen sayının sinüsünü alır.

            Console.WriteLine(Math.Cos(-180));//Girilen sayının kosinüsünü alır.

            Console.WriteLine(Math.Tan(-90));//Girilen sayının tanjantını alır.

            Console.WriteLine(Math.Ceiling(14.4)); // Girilen sayıyı yukarı yuvarlar.

            Console.WriteLine(Math.Floor(25.7));//Girilen sayıyı aşağı yuvarlar.

            Console.WriteLine(Math.Pow(2, 5));// a üzeri b yi hesaplar.

            Console.WriteLine(Math.Sqrt(25));//Girilen sayının karekökünü bulur.

            Console.WriteLine(Math.Log(9));//Girilen sayının(a)  b tabanında logaritmasını bulur.

          
        }
    }
}
