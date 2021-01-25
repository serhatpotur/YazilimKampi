using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // İmzanın aynı olduğu ancak içerisinin farklı olduğu durumlarda class olarak değil de interface olacak kullanırız
    // interface şablon görevi görür
    //interface : birisi bu interfaceyi kullanırsa , kullanan kişi burada ki metotları kullanmak zorunda
    //Interface olduğunu anlamak için başına I harfi konur
    //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. Bütün kredilerde kredi hesapla , geri ödeme vardır ancak kodları farklıdır(mastafları, gereklilik,yükümlülük vs değişkenlik gsöterir)
    interface IKrediManager       
    {
        public void Hesapla();
        public void BirseyYap();

    }
}
