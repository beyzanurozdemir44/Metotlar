using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Ekle:"+" "+urun.Adi+" "+urun.Açiklama+" "+urun.Fiyati);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete Ekle:"+""+urunAdi+""+aciklama+""+fiyat);
        }
    }
}
