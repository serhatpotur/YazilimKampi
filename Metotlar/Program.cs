using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun ürün1 = new Urun();
            ürün1.Adi = "Elma";
            ürün1.Fiyati = 15;
            ürün1.Aciklama = "Amasya Elması";

            Urun ürün2 = new Urun();
            ürün2.Adi = "Karpuz";
            
            ürün2.Fiyati = 80;
            ürün2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] meyveler = new Urun[] { ürün1, ürün2 };
            foreach (var item in meyveler)
            {
                Console.WriteLine("Ürün Adı : "+item.Adi);
                Console.WriteLine("Ürün Fiyatı : "+item.Fiyati);
                Console.WriteLine("Ürün Aciklama : " + item.Aciklama);
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("--------METOTLAR---------");
            SepetManager sepetManager = new SepetManager();
            //kapsülleme
            //doğru kullanım
            sepetManager.Ekle(ürün1);
            sepetManager.Ekle(ürün2);
            
            /*hatalı kullanım. çünkü sepetmanagerde bi değişiklik yapmamız 
            gerektiğinde bu değişikliği bütün sayfalarda yapmamız gerekecek */
            sepetManager.EkleAlternatif("Armut", "Yeşil", 12,10);

        }
    }
}
