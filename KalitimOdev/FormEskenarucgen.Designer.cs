
namespace KalitimOdev
{
    partial class FormEskenarucgen
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
            this.btnEskenarucgen = new System.Windows.Forms.Button();
            this.txtEskenarucgen = new System.Windows.Forms.TextBox();
            this.label1Eskenarucgen = new System.Windows.Forms.Label();
            this.txtEskenarucgenId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnEskenarucgen
            // 
            this.btnEskenarucgen.BackColor = System.Drawing.Color.LightCyan;
            this.btnEskenarucgen.Location = new System.Drawing.Point(916, 260);
            this.btnEskenarucgen.Name = "btnEskenarucgen";
            this.btnEskenarucgen.Size = new System.Drawing.Size(136, 52);
            this.btnEskenarucgen.TabIndex = 9;
            this.btnEskenarucgen.Text = "Alan ve Çevre Hesapla";
            this.btnEskenarucgen.UseVisualStyleBackColor = false;
            this.btnEskenarucgen.Click += new System.EventHandler(this.btnEskenarucgen_Click);
            // 
            // txtEskenarucgen
            // 
            this.txtEskenarucgen.BackColor = System.Drawing.Color.LightCyan;
            this.txtEskenarucgen.Location = new System.Drawing.Point(347, 51);
            this.txtEskenarucgen.Name = "txtEskenarucgen";
            this.txtEskenarucgen.Size = new System.Drawing.Size(106, 22);
            this.txtEskenarucgen.TabIndex = 7;
            this.txtEskenarucgen.TextChanged += new System.EventHandler(this.txtEskenarucgen_TextChanged);
            // 
            // label1Eskenarucgen
            // 
            this.label1Eskenarucgen.AutoSize = true;
            this.label1Eskenarucgen.BackColor = System.Drawing.Color.LightCyan;
            this.label1Eskenarucgen.Location = new System.Drawing.Point(42, 49);
            this.label1Eskenarucgen.Name = "label1Eskenarucgen";
            this.label1Eskenarucgen.Size = new System.Drawing.Size(301, 17);
            this.label1Eskenarucgen.TabIndex = 5;
            this.label1Eskenarucgen.Text = "Eşkenar üçgenin bir kenar uzunluğunu giriniz: ";
            // 
            // txtEskenarucgenId
            // 
            this.txtEskenarucgenId.BackColor = System.Drawing.Color.LightCyan;
            this.txtEskenarucgenId.Location = new System.Drawing.Point(347, 23);
            this.txtEskenarucgenId.Name = "txtEskenarucgenId";
            this.txtEskenarucgenId.Size = new System.Drawing.Size(106, 22);
            this.txtEskenarucgenId.TabIndex = 11;
            this.txtEskenarucgenId.TextChanged += new System.EventHandler(this.txtEskenarucgenId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(178, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şeklin id değerini giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(195, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 12;
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
            this.checkedListBox1.Location = new System.Drawing.Point(347, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(106, 89);
            this.checkedListBox1.TabIndex = 22;
            // 
            // FormEskenarucgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1191, 324);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEskenarucgenId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEskenarucgen);
            this.Controls.Add(this.txtEskenarucgen);
            this.Controls.Add(this.label1Eskenarucgen);
            this.Name = "FormEskenarucgen";
            this.Text = "FormEskenarucgen";
            this.Load += new System.EventHandler(this.FormEskenarucgen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEskenarucgen;
        private System.Windows.Forms.TextBox txtEskenarucgen;
        private System.Windows.Forms.Label label1Eskenarucgen;
        private System.Windows.Forms.TextBox txtEskenarucgenId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}