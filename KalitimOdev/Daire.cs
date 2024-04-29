using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class Daire : Sekil
    {
        public float Cap { get; set; }
        public float Aci { get; set; }


        public Daire(float Cap, float Aci, int id, string Ad, string Renk)
        {
            this.Id = id;
            this.Cap = Cap;
            this.Aci = Aci;
            this.Ad = Ad;
            this.Renk = Renk;
        }
        public override void bilgiYazdir()
        {
            base.bilgiYazdir();
            this.Id = Id;

        }
        public override void CevreHesapla()
        {
            const float pi =3.14F;
            float x = Aci / 360;

            base.CevreHesapla();
            cevre = pi * Cap * x;
        }
        public override void AlanHesapla()
        {
            const double pi = 3.14;
            float x = Aci / 360;
            base.AlanHesapla();
            alan = Convert.ToInt32((pi * Cap * Cap) / 4) * x;

        }
    }
}
