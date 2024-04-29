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
    public partial class FormEskenarucgen : Form
    {
        public FormEskenarucgen()
        {
            InitializeComponent();
        }

        private void btnEskenarucgen_Click(object sender, EventArgs e)
        {
            float kenar = Convert.ToInt32(txtEskenarucgen.Text);
            int id = Convert.ToInt32(txtEskenarucgenId.Text);
            string Renk = Convert.ToString(checkedListBox1.Text);
            string Ad = "Eşkenar Üçgen";
            EskenarUcgen ucgen = new EskenarUcgen(kenar, id, Renk, Ad);
            ucgen.CevreHesapla();
            ucgen.AlanHesapla();
            ucgen.bilgiYazdir();
            MessageBox.Show(ucgen.metin);
        }

        private void txtEskenarucgenId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEskenarucgen_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEskenarucgen_Load(object sender, EventArgs e)
        {

        }
    }
}
