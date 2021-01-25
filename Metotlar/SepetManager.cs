using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler ! " + urun.Adi + " Sepete Eklendi ve fiyatı : "+urun.Fiyati);
        }
        public void EkleAlternatif(string ürünAdi,string Aciklama,int fiyat,int stokAdet)
        {
            Console.WriteLine("Tebrikler ! " + ürünAdi + " Sepete Eklendi ve fiyatı : "+fiyat);
            Console.WriteLine();
        }
    }
}
