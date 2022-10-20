using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarr
{
    class SepetManager
    {
        public void Ekle(Urun asd)
        {
            Console.WriteLine("TEBRİKLERR sepete eklendiii : " +asd.Adi);
        }
        public void ekle2(string urunadi, string acıklama, double fiyat,int stokadet)
        {
            Console.WriteLine("TEBRİKLERR sepete eklendi : " + urunadi);
        }
    }
}
