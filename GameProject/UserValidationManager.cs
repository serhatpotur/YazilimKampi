using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // 5. Adım
    // E-Devlet doğrulama simülasyonunu yapıyoruz
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirdOfYear == 1998 && gamer.FirstName == "Serhat" && gamer.LastName == "Potur" && gamer.IdentityNumber == 12365478963)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
