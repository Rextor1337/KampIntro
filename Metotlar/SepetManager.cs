using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun sepeturun)
        {
            Console.WriteLine("Sepete Eklendi : " + sepeturun.Adi);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat , int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete ekledi :" + urunAdi);
        }
    }
}
