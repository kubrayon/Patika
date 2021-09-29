using System;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
              //Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

             //try { Hataya sebebiyet verme ihtimali olan kod }

            // catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

            // finally { Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }
           
            
            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                int n1 = int.Parse(null);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }

        }
    }
}
