using System;

namespace GameProject
{
    class Program
    {
        /*
         * Bir oyun yazmak istiyoruz. Yeni üye, satış, kampanya yönetimi yapılması isteniyor.
         * 
         * Oyuncuların sisteme kayıt olduğu ,bilgilerini silebileceği, güncelleyebileceği bir simülasyon tasarlayınız(1-2-3. Adım)
         * Müşteri bilgilerinin doğruluğunu E-Devlet üzerinden yapınız. Doğrulama TcNo, Ad, Soyad, DYılı ile yapılır(4-5-6)
         * 
         * Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)
         * 
         * Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
         * 
         * Satışlarda kampanya entegrasyonunu simule ediniz.
         
         */
        static void Main(string[] args)
        {
            // Kullanıcı Ekle
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Serhat",
                BirdOfYear = 1998,
                LastName = "Potur",
                IdentityNumber = 12365478963 
            });

            //Kullanıcı Sil
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Delete(new Gamer
            //{
            //    Id = 1,
            //    FirstName = "Serhat",
            //    BirdOfYear = 1998,
            //    LastName = "Potur",
            //    IdentityNumber = 12365478963
            //});

            //Kullanıcı Güncelle
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Delete(new Gamer
            //{
            //    Id = 1,
            //    FirstName = "Serhat",
            //    BirdOfYear = 1998,
            //    LastName = "Potur",
            //    IdentityNumber = 12365478963
            //});
        }
    }
}
