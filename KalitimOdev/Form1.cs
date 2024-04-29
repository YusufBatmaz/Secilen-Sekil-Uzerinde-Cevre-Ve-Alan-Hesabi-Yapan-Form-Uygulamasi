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
    public partial class Bildirim : Form
    {
        public Bildirim()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000, "Programa hoş geldiniz!", "Nesne Yönelimli Programlama Ödevi", ToolTipIcon.Info);

        }


        private void tabPageAnaSayfa_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAnaliz_Click(object sender, EventArgs e)
        {

        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab =tabPageAnaSayfa;
        }


        private void btnIleri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAnaliz;

        }

        private void btnDikdortgenForm_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            txt1FormDikdortgen dikdortgen = new txt1FormDikdortgen();
            dikdortgen.MdiParent = this;
            dikdortgen.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(dikdortgen);
            dikdortgen.Show();

            
        }

        private void btnEskenarUcgenForm_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormEskenarucgen ucgen = new FormEskenarucgen();
            ucgen.MdiParent = this;
            ucgen.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ucgen);
            ucgen.Show();
        }

        private void btnDaireForm_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormDaire daire = new FormDaire();
            daire.MdiParent = this;
            daire.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(daire);
            daire.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAnaliz.Text = " ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAnaliz_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
