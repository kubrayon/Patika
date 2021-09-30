using System;

namespace constructors
{


    //Class Constructors denilen kurucu metotlar bir  sınıf veya yapı oluşturulduğunda, kurucusu çağrılır
    //Kurucular, sınıf veya yapı ile aynı ada sahiptir. Diğer metotlardan bazı farklılıkları vardır.
    //Kurucu metod sınıf ismi ile aynı olmalıdır
    //Public olarak tanımlanmalıdır.
    //Geriye değer döndürmez.
    class Urun
    {
        public string ad;
        public double fiyat;

        public Urun()   // metodumuzu oluşturduk
        {
            ad = "";
            fiyat = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Urun u = new Urun();

            Console.WriteLine(u.ad);
            Console.WriteLine(u.fiyat);
        }
    }
}