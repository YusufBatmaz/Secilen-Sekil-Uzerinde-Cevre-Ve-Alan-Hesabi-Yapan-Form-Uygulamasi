using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class Sekil
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Renk { get; set; }
        public float cevre { get; set; }
        public float alan { get; set; }
        public string metin { get; set; }
        public Sekil()
        {

        }
        public virtual void bilgiYazdir()
        {
            metin = "id:" + Id + "  Şeklin Adı: " +Ad+ "   Rengi:" + Renk + "  Alan:" + alan + "   Cevre: " + cevre;
            
        }
        public virtual void AlanHesapla()
        {
            //
        }

        public virtual void CevreHesapla()
        {
            //
        }
    }
}
