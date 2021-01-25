using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değer Tip : İnt,double,float,decimal,bool
            //Referans Tip : Array,class,interface
            int sayi1 = 30;
            int sayi2 = 60;
            sayi1 = sayi2;
            sayi2 = 90;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); 
            Console.WriteLine("Hello World!");
        }
    }
}
