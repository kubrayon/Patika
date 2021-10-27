using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
   public class Hayvanlar : Canlilar
    {
        public void Hareket()
        {
            Console.WriteLine("Hayvanlar sürü halinde hareket ederler.");

        }
        public class Kus : Hayvanlar
        {
            public void Ucmak()
            {
                Console.WriteLine("Kuşların uçma yeteneği vardır.");
            }
         public class Balık : Hayvanlar
            {
                public void Yuzmek()
                {
                    Console.WriteLine("Balıkların yüzme yeteneği vardır.");
                }
            }
        }

    }
}
