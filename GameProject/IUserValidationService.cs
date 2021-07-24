using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // 4. Adım
    // Kullanıcı doğrulama şablon için oluşturduk
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); // doğrulama başarılıysa true, değilse false dönecek
    }
}
