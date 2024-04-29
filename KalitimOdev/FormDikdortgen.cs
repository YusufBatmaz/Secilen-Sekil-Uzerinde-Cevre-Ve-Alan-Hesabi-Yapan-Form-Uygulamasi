using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimOdev
{
    public partial class txt1FormDikdortgen : Form
    {
        public txt1FormDikdortgen()
        {
            InitializeComponent();
        }



        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            int kenar1 = Convert.ToInt32(txtDikdortgen.Text);
            int kenar2 = Convert.ToInt32(txt2Dikdortgen.Text);
            int id = Convert.ToInt32(txtDikdortgenId.Text);
            string Renk = Convert.ToString(checkedListBox1.Text);
            string Ad = "Dikdörtgen";
            Dikdortgen dikdortgen = new Dikdortgen(kenar1, kenar2,id,Renk,Ad);
            dikdortgen.CevreHesapla();
            dikdortgen.AlanHesapla();
            dikdortgen.bilgiYazdir();
            MessageBox.Show(dikdortgen.metin);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFormDikdortgen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDikdortgenId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void txt1FormDikdortgen_Load(object sender, EventArgs e)
        {
           
        }
    }
}
