
namespace KalitimOdev
{
    partial class txt1FormDikdortgen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDikdortgen = new System.Windows.Forms.TextBox();
            this.txt2Dikdortgen = new System.Windows.Forms.TextBox();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDikdortgenId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(127, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birinci kenarı giriniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(134, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İkinci kenarı giriniz:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDikdortgen
            // 
            this.txtDikdortgen.BackColor = System.Drawing.Color.LightCyan;
            this.txtDikdortgen.Location = new System.Drawing.Point(267, 59);
            this.txtDikdortgen.Name = "txtDikdortgen";
            this.txtDikdortgen.Size = new System.Drawing.Size(106, 22);
            this.txtDikdortgen.TabIndex = 2;
            this.txtDikdortgen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2Dikdortgen
            // 
            this.txt2Dikdortgen.BackColor = System.Drawing.Color.LightCyan;
            this.txt2Dikdortgen.Location = new System.Drawing.Point(267, 100);
            this.txt2Dikdortgen.Name = "txt2Dikdortgen";
            this.txt2Dikdortgen.Size = new System.Drawing.Size(106, 22);
            this.txt2Dikdortgen.TabIndex = 3;
            this.txt2Dikdortgen.TextChanged += new System.EventHandler(this.txtFormDikdortgen_TextChanged);
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.BackColor = System.Drawing.Color.LightCyan;
            this.btnDikdortgen.Location = new System.Drawing.Point(916, 260);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(136, 52);
            this.btnDikdortgen.TabIndex = 4;
            this.btnDikdortgen.Text = "Alan ve Çevre Hesapla";
            this.btnDikdortgen.UseVisualStyleBackColor = false;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(96, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şeklin id değerini giriniz:";
            // 
            // txtDikdortgenId
            // 
            this.txtDikdortgenId.BackColor = System.Drawing.Color.LightCyan;
            this.txtDikdortgenId.Location = new System.Drawing.Point(267, 22);
            this.txtDikdortgenId.Name = "txtDikdortgenId";
            this.txtDikdortgenId.Size = new System.Drawing.Size(106, 22);
            this.txtDikdortgenId.TabIndex = 6;
            this.txtDikdortgenId.TextChanged += new System.EventHandler(this.txtDikdortgenId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(113, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şeklin rengini seçiniz:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.checkedListBox1.Location = new System.Drawing.Point(267, 139);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(106, 89);
            this.checkedListBox1.TabIndex = 21;
            // 
            // txt1FormDikdortgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1191, 324);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDikdortgenId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.txt2Dikdortgen);
            this.Controls.Add(this.txtDikdortgen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txt1FormDikdortgen";
            this.Text = "FormDikdortgen";
            this.Load += new System.EventHandler(this.txt1FormDikdortgen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDikdortgen;
        private System.Windows.Forms.TextBox txt2Dikdortgen;
        private System.Windows.Forms.Button btnDikdortgen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDikdortgenId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}