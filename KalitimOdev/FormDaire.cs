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
    public partial class FormDaire : Form
    {
        public FormDaire()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            float Cap = Convert.ToInt32(txtDaireCap.Text);
            float Aci = Convert.ToInt32(txtDaireAci.Text);
            int id = Convert.ToInt32(txtDaireId.Text);
            string Renk = Convert.ToString(checkedListBox1.Text);
            string Ad = "Daire";
            
            Daire daire = new Daire(Cap, Aci, id, Ad, Renk);
            daire.CevreHesapla();
            daire.AlanHesapla();
            daire.bilgiYazdir();
            MessageBox.Show(daire.metin);
        }

        private void FormDaire_Load(object sender, EventArgs e)
        {

        }
    }
}
