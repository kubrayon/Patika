using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    public class Bitkiler : Canlilar
    {
        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yaparlar.");

        }
        public class Tohumlu : Bitkiler
        {
            public void TohumlaCogalma()
            {
                Console.WriteLine("Tohumlu bitkiler tohumla çoğalırlar");
            }
            public class Tohumsuz : Bitkiler
            {
                public void SporlaCogalma()
                {
                    Console.WriteLine("Tohumsuz bitkiler sporla çoğalırlar.");
                }
            }
        }
    }
}
