using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Serhat","Volkan","Batıkan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler = new string[3];
            isimler[3] = "Semih";
            Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "Serhat", "Volkan", "Batıkan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Can");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
        }
    }
}
