﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba" + name + " " + surname);

        }
    }
}
