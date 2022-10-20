using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarr
{
     class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyatı = 13;
            string aciklama = "amasya elması";

            Urun urun1  = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 32;
            urun2.Aciklama = "diyarbekir karpuz";
            urun2.Agırlık = 32;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Agırlık);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("-----------------Metotlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.ekle2("armut", "asd", 123,23);
            sepetManager.ekle2("eelma", "asd", 22,4);
            sepetManager.ekle2("asdasd", "asd", 123,7);
            
        }
    }
}
