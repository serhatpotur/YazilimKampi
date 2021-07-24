using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // 2. Adım
    // Operasyonların yapılacağı Interface oluşturuldu
    interface IGamerService
    {
        void Add(Gamer gamer); //Gamer Ekle
        void Update(Gamer gamer); //Gamer Güncelle
        void Delete(Gamer gamer); //Gamer Sil
    }
}
