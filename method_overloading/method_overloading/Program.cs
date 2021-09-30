using System;

namespace method_overloading
{
    class Program
    {
        static int ort(int n1, int n2)
        {
            int sonuc = (n1 + n2) / 2;
            return sonuc;
        }

        static int ort(int n1, int n2, int n3)
        {
            int sonuc = (n1 + n2 + n3) / 2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ort(13, 5));
            Console.WriteLine(ort(13, 8, 7));
            Console.ReadKey();
        }
    }
}
