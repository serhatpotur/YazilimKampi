using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(10, 5);
            dortIslem.Cıkar(10, 5);
            dortIslem.Carp(10, 5);
            dortIslem.Böl(10, 5);
        }
    }
}
