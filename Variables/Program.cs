using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;    //1 byte 0, ..., 255 (tam sayı)
            sbyte b = 2;  //1 byte -128, ..., 127 (tam sayı)

            short c = 3;  //2 byte -32768, ..., 32767 (tam sayı)
            ushort d = 4; // 2 byte 0, ..., 65535 (tam sayı)     

            int e = 5;    // 4 byte -2147483648, ..., 2147483647 (tam sayı)
            uint f = 6;   // 4 byte 0, ..., 4294967295 (tam sayı)

            long g = 7;   // 8 byte -9223372036854775808, ..., 9223372036854775807 (tam sayı)	
            ulong h = 8;  // 8 byte 	0, ..., 18446744073709551615 (tam sayı)

            //Ondalıklı sayılar için;
            float ı =10;  // 4 byte (reel sayı)
            double i = 11; // 8 byte (reel sayı)
            decimal j = 12; // 16 byte (reel sayı)

            //Doğru veya yanlış değer döndürür.
            bool b1 = true;
            bool b2 = false;

            //object değişkenler her türden veriyi içinde saklayabilir.
            object o1 = "string ifade";
            object o2 = 'A';
            object o3 = 19;
            object o4 = 10.5;

            //Tarih ve zaman kullanımı için;
            DateTime dt = DateTime.Now;

            char k = 'Y'; // 2 byte. Tek bir karakter tutar.
            string l = "Kübra Yön"; // Sınırsız. Metin tutar.




        }
}
