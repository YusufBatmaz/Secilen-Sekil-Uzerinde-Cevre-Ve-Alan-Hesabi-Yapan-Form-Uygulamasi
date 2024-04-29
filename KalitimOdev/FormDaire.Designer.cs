
namespace KalitimOdev
{
    partial class FormDaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDaire = new System.Windows.Forms.Button();
            this.txtDaireAci = new System.Windows.Forms.TextBox();
            this.txtDaireCap = new System.Windows.Forms.TextBox();
            this.label2Daire = new System.Windows.Forms.Label();
            this.label1Daire = new System.Windows.Forms.Label();
            this.txtDaireId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnDaire
            // 
            this.btnDaire.BackColor = System.Drawing.Color.LightCyan;
            this.btnDaire.Location = new System.Drawing.Point(916, 260);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(136, 52);
            this.btnDaire.TabIndex = 9;
            this.btnDaire.Text = "Alan ve Çevre Hesapla";
            this.btnDaire.UseVisualStyleBackColor = false;
            this.btnDaire.Click += new System.EventHandler(this.btnDaire_Click);
            // 
            // txtDaireAci
            // 
            this.txtDaireAci.BackColor = System.Drawing.Color.LightCyan;
            this.txtDaireAci.Location = new System.Drawing.Point(258, 101);
            this.txtDaireAci.Name = "txtDaireAci";
            this.txtDaireAci.Size = new System.Drawing.Size(106, 22);
            this.txtDaireAci.TabIndex = 8;
            // 
            // txtDaireCap
            // 
            this.txtDaireCap.BackColor = System.Drawing.Color.LightCyan;
            this.txtDaireCap.Location = new System.Drawing.Point(258, 56);
            this.txtDaireCap.Name = "txtDaireCap";
            this.txtDaireCap.Size = new System.Drawing.Size(106, 22);
            this.txtDaireCap.TabIndex = 7;
            // 
            // label2Daire
            // 
            this.label2Daire.AutoSize = true;
            this.label2Daire.BackColor = System.Drawing.Color.LightCyan;
            this.label2Daire.Location = new System.Drawing.Point(125, 101);
            this.label2Daire.Name = "label2Daire";
            this.label2Daire.Size = new System.Drawing.Size(116, 17);
            this.label2Daire.TabIndex = 6;
            this.label2Daire.Text = "Açı değeri giriniz:";
            // 
            // label1Daire
            // 
            this.label1Daire.AutoSize = true;
            this.label1Daire.BackColor = System.Drawing.Color.LightCyan;
            this.label1Daire.Location = new System.Drawing.Point(118, 56);
            this.label1Daire.Name = "label1Daire";
            this.label1Daire.Size = new System.Drawing.Size(124, 17);
            this.label1Daire.TabIndex = 5;
            this.label1Daire.Text = "Çap uzunlu giriniz:";
            // 
            // txtDaireId
            // 
            this.txtDaireId.BackColor = System.Drawing.Color.LightCyan;
            this.txtDaireId.Location = new System.Drawing.Point(258, 16);
            this.txtDaireId.Name = "txtDaireId";
            this.txtDaireId.Size = new System.Drawing.Size(106, 22);
            this.txtDaireId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(80, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şeklin id değerini giriniz:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(97, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Şeklin rengini seçiniz:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.LightCyan;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Kırmızı",
            "Siyah",
            "Mavi",
            "Sarı"});
            this.checkedListBox1.Location = new System.Drawing.Point(258, 144);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(106, 89);
            this.checkedListBox1.TabIndex = 22;
            // 
            // FormDaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1191, 324);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDaireId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDaire);
            this.Controls.Add(this.txtDaireAci);
            this.Controls.Add(this.txtDaireCap);
            this.Controls.Add(this.label2Daire);
            this.Controls.Add(this.label1Daire);
            this.Name = "FormDaire";
            this.Text = "FormDaire";
            this.Load += new System.EventHandler(this.FormDaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDaire;
        private System.Windows.Forms.TextBox txtDaireAci;
        private System.Windows.Forms.TextBox txtDaireCap;
        private System.Windows.Forms.Label label2Daire;
        private System.Windows.Forms.Label label1Daire;
        private System.Windows.Forms.TextBox txtDaireId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}