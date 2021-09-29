using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            byte n1 = 5;
            sbyte n2 = 30;
            short n3 = 10;

            int n4 = n1 + n2 + n3;
            Console.WriteLine("n4:" + n4);

            long n5 = n4;
            Console.WriteLine("n5:" + n5);

            float n6 = n5;
            Console.WriteLine("n6:" + n6);

            string a = "World";
            char b = 'K';
            object c = a + b + n4;
            Console.WriteLine("c:" + c);


            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("*** Explicit Conversion ***");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            //ToString Methodu
            Console.WriteLine("*** ToString Methodu ***");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);


            //System.Convert Sınıfı
           
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            //Parse Methodu
         
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string str1 = "10";
            string str2 = "10.25";
            int number1;
            double double1;

            number1 = Int32.Parse(str1);
            double1 = double.Parse(str2);

            Console.WriteLine("number1:" + number1);
            Console.WriteLine("double1:" + double1);

        }
    }
}
