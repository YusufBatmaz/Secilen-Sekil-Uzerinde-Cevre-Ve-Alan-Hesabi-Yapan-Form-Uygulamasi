
namespace KalitimOdev
{
    partial class Bildirim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bildirim));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAnaSayfa = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnEskenarUcgenForm = new System.Windows.Forms.Button();
            this.btnDikdortgenForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDaireForm = new System.Windows.Forms.Button();
            this.tabPageAnaliz = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtAnaliz = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageAnaSayfa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAnaliz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAnaSayfa);
            this.tabControl1.Controls.Add(this.tabPageAnaliz);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAnaSayfa
            // 
            this.tabPageAnaSayfa.BackColor = System.Drawing.Color.LightGray;
            this.tabPageAnaSayfa.Controls.Add(this.panel2);
            this.tabPageAnaSayfa.Controls.Add(this.panel1);
            this.tabPageAnaSayfa.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnaSayfa.Name = "tabPageAnaSayfa";
            this.tabPageAnaSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnaSayfa.Size = new System.Drawing.Size(1215, 552);
            this.tabPageAnaSayfa.TabIndex = 0;
            this.tabPageAnaSayfa.Text = "Ana Sayfa";
            this.tabPageAnaSayfa.Click += new System.EventHandler(this.tabPageAnaSayfa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 371);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnIleri);
            this.panel1.Controls.Add(this.btnEskenarUcgenForm);
            this.panel1.Controls.Add(this.btnDikdortgenForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDaireForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 175);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.Aqua;
            this.btnIleri.Location = new System.Drawing.Point(916, 134);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(120, 35);
            this.btnIleri.TabIndex = 4;
            this.btnIleri.Text = "İLERİ";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnEskenarUcgenForm
            // 
            this.btnEskenarUcgenForm.BackColor = System.Drawing.Color.Cyan;
            this.btnEskenarUcgenForm.Location = new System.Drawing.Point(644, 75);
            this.btnEskenarUcgenForm.Name = "btnEskenarUcgenForm";
            this.btnEskenarUcgenForm.Size = new System.Drawing.Size(160, 25);
            this.btnEskenarUcgenForm.TabIndex = 1;
            this.btnEskenarUcgenForm.Text = "EŞKENAR ÜÇGEN";
            this.btnEskenarUcgenForm.UseVisualStyleBackColor = false;
            this.btnEskenarUcgenForm.Click += new System.EventHandler(this.btnEskenarUcgenForm_Click);
            // 
            // btnDikdortgenForm
            // 
            this.btnDikdortgenForm.BackColor = System.Drawing.Color.Cyan;
            this.btnDikdortgenForm.Location = new System.Drawing.Point(422, 75);
            this.btnDikdortgenForm.Name = "btnDikdortgenForm";
            this.btnDikdortgenForm.Size = new System.Drawing.Size(160, 25);
            this.btnDikdortgenForm.TabIndex = 0;
            this.btnDikdortgenForm.Text = "DİKDÖRTGEN";
            this.btnDikdortgenForm.UseVisualStyleBackColor = false;
            this.btnDikdortgenForm.Click += new System.EventHandler(this.btnDikdortgenForm_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(106, 75);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "İşlem yapmak istediğiniz şekle tıklayınız.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDaireForm
            // 
            this.btnDaireForm.BackColor = System.Drawing.Color.Cyan;
            this.btnDaireForm.Location = new System.Drawing.Point(876, 75);
            this.btnDaireForm.Name = "btnDaireForm";
            this.btnDaireForm.Size = new System.Drawing.Size(160, 25);
            this.btnDaireForm.TabIndex = 2;
            this.btnDaireForm.Text = "DAİRE";
            this.btnDaireForm.UseVisualStyleBackColor = false;
            this.btnDaireForm.Click += new System.EventHandler(this.btnDaireForm_Click);
            // 
            // tabPageAnaliz
            // 
            this.tabPageAnaliz.BackColor = System.Drawing.Color.LightGray;
            this.tabPageAnaliz.Controls.Add(this.txtAnaliz);
            this.tabPageAnaliz.Controls.Add(this.btnTemizle);
            this.tabPageAnaliz.Controls.Add(this.btnGeri);
            this.tabPageAnaliz.Controls.Add(this.panel3);
            this.tabPageAnaliz.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnaliz.Name = "tabPageAnaliz";
            this.tabPageAnaliz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnaliz.Size = new System.Drawing.Size(1215, 552);
            this.tabPageAnaliz.TabIndex = 1;
            this.tabPageAnaliz.Text = "Analiz Sonuçları";
            this.tabPageAnaliz.Click += new System.EventHandler(this.tabPageAnaliz_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Aqua;
            this.btnTemizle.Location = new System.Drawing.Point(669, 492);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Aqua;
            this.btnGeri.Location = new System.Drawing.Point(357, 492);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(120, 35);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtAnaliz
            // 
            this.txtAnaliz.Location = new System.Drawing.Point(357, 27);
            this.txtAnaliz.Multiline = true;
            this.txtAnaliz.Name = "txtAnaliz";
            this.txtAnaliz.Size = new System.Drawing.Size(432, 439);
            this.txtAnaliz.TabIndex = 4;
            this.txtAnaliz.TextChanged += new System.EventHandler(this.txtAnaliz_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 546);
            this.panel3.TabIndex = 5;
            // 
            // Bildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 625);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Name = "Bildirim";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAnaSayfa.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageAnaliz.ResumeLayout(false);
            this.tabPageAnaliz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAnaSayfa;
        private System.Windows.Forms.TabPage tabPageAnaliz;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDikdortgenForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDaireForm;
        private System.Windows.Forms.Button btnEskenarUcgenForm;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtAnaliz;
        private System.Windows.Forms.Panel panel3;
    }
}

