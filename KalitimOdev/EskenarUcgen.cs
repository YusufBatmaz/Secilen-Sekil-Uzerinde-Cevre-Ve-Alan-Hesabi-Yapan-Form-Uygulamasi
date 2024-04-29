using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class EskenarUcgen : Sekil
    {
        public float Kenar { get; set; }
        public EskenarUcgen(float Kenar ,int id, string Renk, string Ad)
        {
            this.Id = id;
            this.Kenar = Kenar;
            this.Ad = Ad;
            this.Renk = Renk;
        }
        public override void bilgiYazdir()
        {
            base.bilgiYazdir();
            this.Id = Id;
            this.alan = alan;
            this.cevre = cevre;
        }
        public override void CevreHesapla()
        {
            base.CevreHesapla();
            cevre = Kenar * 3;
        }
        public override void AlanHesapla()
        {
            base.AlanHesapla();
            alan = (Kenar * Kenar * Convert.ToInt32(Math.Sqrt(3))) / 4;
        }
    }

}
