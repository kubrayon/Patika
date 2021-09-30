using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive (özyinelemeli) fonksiyon, bir fonksiyonun kendini çağırması olarak ifade edilebilir. Diğer bir deyişle kendi kendini çağıran fonksiyonlarda denilebilir.

            Console.Write("Bir sayı giriniz : ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + "! faktöriyel : " + Faktoriyel(input));

            Console.ReadKey();
            static int Faktoriyel(int sayi)
            {
                if (sayi <= 1)
                {
                    return 1;
                }
                return sayi * Faktoriyel(sayi - 1);
            }
        }
    }
}
