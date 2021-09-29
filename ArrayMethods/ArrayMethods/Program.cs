using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort Metodu kullanılarak dizi içerisinde sıralama yapabiliriz.

            int[] sayiDizisi = { 23, 12, 86, 72, 3, 11, 17 };

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse Metodu diziyi ters çevirmek için kullanılır.Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Array.Reverse(numbers);

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
            //IndexOf dizi içinde istenilen ifadeyi aramak için kullanılır.

               string[] names = new string[6]
{
                 "Mehmet", "Ahmet", "Hüseyin", "Fatma", "Ayşe", "Emine"
                  // 0        1          2         3       4        5
};

                 string str = "Ayşe";

                 int a = Array.IndexOf(names, str);

                Console.WriteLine(str + " isminin listedeki konumu : " + a);

}
                 /*
                    Ayşe değerinin listedeki konumu : 4
                */

                //Resize dizileri yeniden boyutlandırmak için kullanılır.

                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                 for (int i = 0; i < numbers.Length; i++)
                   {
                   Console.Write(numbers[i]);
                   }
                   Console.WriteLine();

                   Array.Resize(ref numbers, 5);

                   for (int i = 0; i < numbers.Length; i++)
                   {
                   Console.Write(numbers[i]);
                   }

                 Console.ReadLine();

              //Clear yöntemi dizini boşaltmak için kullanılır. 

                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                 Array.Clear(numbers, 3, 2);
                 foreach (var number in numbers)
                   {
                      Console.WriteLine(number);
                   }
                      Console.ReadLine();
        }
    }
}

