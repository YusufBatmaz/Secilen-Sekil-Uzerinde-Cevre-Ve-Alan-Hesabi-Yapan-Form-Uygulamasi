using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class Dikdortgen : Sekil
    {
        public int Genislik { get; set; }
        public int En { get; set; }

        public Dikdortgen(int Genislik, int En, int id, string Renk, string Ad)
        {
            this.Id = id;
            this.Genislik = Genislik;
            this.En = En;
            this.Renk = Renk;
            this.Ad = Ad;
        }
        public override void bilgiYazdir()
        {
            base.bilgiYazdir();
            this.Id = Id;
            this.alan = alan;
            this.cevre = cevre;
        }
        public override void AlanHesapla()
        {
            base.AlanHesapla();
            alan = Genislik * En;
        }

        public override void CevreHesapla()
        {
            base.CevreHesapla();
            cevre = (Genislik + En) * 2;
        }
        

    }

    
}
