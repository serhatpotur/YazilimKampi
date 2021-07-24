using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // 3. Adım
    // Operasyonları somutlaştırdık
    // IGamerService Implame edildi
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + "kullanıcısı eklendi.");

            }
            else
            {
                throw new Exception("Kayıt Ekleme Başarısız !");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + "kullanıcısı silindi.");
            }
            else
            {
                throw new Exception("Kayıt Silme Başarısız !");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + "kullanıcısı güncellendi.");
            }
            else
            {
                throw new Exception("Kayıt Güncelleme  Başarısız !");
            }
        }
    }
}
