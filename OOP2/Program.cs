using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bu tarz kullanım hatalıdır. Gerçek müşteri ve tüzel müşteri classları ayrı ayrı tanımlanlanmalıdır
            // SOLID kuralına aykırı

            // Serhat Potur müşterisi olsun
            //Musteri musteri1 = new Musteri();
            //musteri1.Id = 1;
            //musteri1.Adi = "Serhat";
            //musteri1.Soyadi = "Potur";
            //musteri1.TcNo = "2222222222";
            //musteri1.MusteriNo = "123456";
            //musteri1.SirketAdi = "???"; //Buraya ne gireceğiz peki ?

            // Gerçek Müşteri -

            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "13345";
            gercekMusteri.Adi = "Serhat";
            gercekMusteri.Soyadi = "Potur";
            gercekMusteri.TcNo = "222222222";


            // Tüzel Müşteri
            TüzelMusteri tüzelMusteri = new TüzelMusteri();
            tüzelMusteri.Id = 2;
            tüzelMusteri.MusteriNo = "24536";
            tüzelMusteri.SirketAdi = "Tekden Yazılım";
            tüzelMusteri.VergiNo = "9876543210";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TüzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(gercekMusteri);
            customerManager.Add(tüzelMusteri);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

        }
    }
}
