using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch case yapısı, çok durumlu dallanma ifadelerinde if-else blokları yerine tercihen kullanılırlar. Switch-case ile yapılabilecek tüm işlemler if-else merdiveni ile de yapılabilmektedir. 

            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                    Console.Write("Bugün Pazartesi");
                    break;
                case 2:
                    Console.Write("Bugün Salı");
                    break;
                case 3:
                    Console.Write("Bugün Çarşamba");
                    break;
                case 4:
                    Console.Write("Bugün Perşembe");
                    break;
                case 5:
                    Console.Write("Bugün Cuma");
                    break;
                case 6:
                    Console.Write("Bugün Cumartesi");
                    break;
                case 7:
                    Console.Write("Bugün Pazar");
                    break;
            }
        }
    }
}
