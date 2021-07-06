using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarBugun = 7.23;
            double dolarDun = 7.3;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("yukseldi");

            }
            else
            {
                Console.WriteLine("ayni");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);



        }
    }
}
