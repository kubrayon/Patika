using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodlar belirli işlemleri yerine getiren kod bloklarıdır.
            //Aynı kodların tekrar tekrar kullanılması gereken durumlarda kolaylık sağlar

            //Kullanımı;

            Console.WriteLine("<Erişim biçimi> <Geri dönüş tipi> Metot_ismi(parametre)");

            //Klavyeden girilen iki sayıdan hangiisnin büyük olduğunu geriye değer döndüren metot kullanarak yapalım

            Console.WriteLine("Birinci sayıyı giriniz");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int buyuk = kucukbuyuk(n1, n2);
            Console.WriteLine("Girilen büüyk sayı=" + buyuk);
            Console.ReadKey();

        }
        static int kucukbuyuk(int a, int b) //metodu burada tanımladık
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
