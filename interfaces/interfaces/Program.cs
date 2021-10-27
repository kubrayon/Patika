using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AudiQ7 Q7 = new AudiQ7();

            Console.WriteLine(Q7.marka().ToString());
            Console.WriteLine(Q7.renk().ToString());
            Console.WriteLine(Q7.Tekerlek());

            Console.WriteLine("************");
            

            ToyotaAuris auris = new ToyotaAuris();

            Console.WriteLine(auris.marka().ToString());
            Console.WriteLine(auris.renk().ToString());
            Console.WriteLine(auris.Tekerlek());

            Console.WriteLine("************");
           

            SkodaKodiaq kodiaq = new SkodaKodiaq();

            Console.WriteLine(kodiaq.marka().ToString());
            Console.WriteLine(kodiaq.renk().ToString());
            Console.WriteLine(kodiaq.Tekerlek());

            //Abstract class kullanarak her classta tekrar yazdığımız tekerlek sayısını tek bir abstracta belirleyerek kod satırını minimuma indirdik.

            Console.WriteLine("****ABSTRACT****");
            

            NewAuris auris1 = new NewAuris();

            Console.WriteLine(auris1.Tekerlek());

            NewKodiaq kodiaq1 = new NewKodiaq();

            Console.WriteLine(kodiaq1.Tekerlek());

            NewQ7 Q71 = new NewQ7();

            Console.WriteLine(Q71.Tekerlek());

           








        }
      
    }
}
