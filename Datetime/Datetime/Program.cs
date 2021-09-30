using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DateTime suan = DateTime.Now; //İşlemin gerçekleştiği andaki zamanı gün.ay.yıl saat:dakika:saniye şeklinde tutar.

           
            DateTime tarih = DateTime.Now.Date; //Seçili günün sadece tarih değerini döndürür. Zaman bilgisini göstermez.

            
            int gun = DateTime.Now.Day; // Seçili tarih bilgisinin sadece gün değerini döndürür

           
            int ay = DateTime.Now.Month; // Seçili tarih bilgisinin sadece ay değerini döndürür. 

            
            int yil = DateTime.Now.Year;// Seçili tarih bilgisinin sadece yıl değerini döndürür.

            
            int saat = DateTime.Now.Hour;// Seçili tarih bilgisinin sadece saat değerini döndürür. 

            
            int dakika = DateTime.Now.Minute;// Seçili tarih bilgisinin sadece dakika değerini döndürür.

           
            int saniye = DateTime.Now.Second; // Seçili tarih bilgisinin sadece saniye değerini döndürür.

            int a= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);    //Bulunduğumuz aydaki gün sayısını bulmak için.

           
            string uzun_tarih = DateTime.Now.ToLongDateString(); //String tipinde full tarihi döndürür. 

           
            int yilin_kacinci_gunu = DateTime.Now.DayOfYear; //Yılın kaçıncı günü olduğunu döndürür.
        }
    }
}
