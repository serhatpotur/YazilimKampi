﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int Topla = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı : " + Topla);
        }
        public void Cıkar(int sayi1, int sayi2)
        {
            int Fark = sayi1 - sayi2;
            Console.WriteLine("Sayıların Farkı : " + Fark);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int Carp = sayi1 * sayi2;
            Console.WriteLine("Sayıların Çarpımı : " + Carp);
        }
        public void Böl(int sayi1, int sayi2)
        {
            int Böl = sayi1 / sayi2;
            Console.WriteLine("Sayıların Bölümü : " + Böl);
        }
    }
}
