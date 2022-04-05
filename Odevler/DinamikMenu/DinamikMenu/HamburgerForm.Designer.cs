
namespace DinamikMenu
{
    partial class HamburgerForm
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
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.cbmMenü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.nmdAdet = new System.Windows.Forms.NumericUpDown();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEkstralar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmdAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(181, 111);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(62, 17);
            this.rbBuyuk.TabIndex = 62;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "BUYUK";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(106, 111);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(55, 17);
            this.rbOrta.TabIndex = 61;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "ORTA";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(28, 111);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(62, 17);
            this.rbKucuk.TabIndex = 60;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "KUCUK";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // cbmMenü
            // 
            this.cbmMenü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMenü.FormattingEnabled = true;
            this.cbmMenü.Location = new System.Drawing.Point(30, 57);
            this.cbmMenü.Name = "cbmMenü";
            this.cbmMenü.Size = new System.Drawing.Size(153, 21);
            this.cbmMenü.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Adet";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(30, 265);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 81;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // nmdAdet
            // 
            this.nmdAdet.Location = new System.Drawing.Point(65, 226);
            this.nmdAdet.Name = "nmdAdet";
            this.nmdAdet.Size = new System.Drawing.Size(120, 20);
            this.nmdAdet.TabIndex = 80;
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(333, 239);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(13, 13);
            this.lblToplamFiyat.TabIndex = 95;
            this.lblToplamFiyat.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 94;
            this.label13.Text = "Toplam Tutar";
            // 
            // btnSiparis
            // 
            this.btnSiparis.AutoSize = true;
            this.btnSiparis.Location = new System.Drawing.Point(627, 239);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(94, 23);
            this.btnSiparis.TabIndex = 93;
            this.btnSiparis.Text = "Siparis Tamamla";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 199);
            this.listBox1.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Menüler";
            // 
            // cmbEkstralar
            // 
            this.cmbEkstralar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEkstralar.FormattingEnabled = true;
            this.cmbEkstralar.Location = new System.Drawing.Point(30, 185);
            this.cmbEkstralar.Name = "cmbEkstralar";
            this.cmbEkstralar.Size = new System.Drawing.Size(153, 21);
            this.cmbEkstralar.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Ekstralar";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(-3, 321);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(81, 48);
            this.btnAdmin.TabIndex = 100;
            this.btnAdmin.Text = "Admin Sayfasına Git";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // HamburgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEkstralar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nmdAdet);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbKucuk);
            this.Controls.Add(this.cbmMenü);
            this.Name = "HamburgerForm";
            this.Text = "HamburgerForm";
            this.Load += new System.EventHandler(this.HamburgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmdAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.ComboBox cbmMenü;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown nmdAdet;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEkstralar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdmin;
    }
}