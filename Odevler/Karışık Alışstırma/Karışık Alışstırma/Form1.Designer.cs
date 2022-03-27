
namespace Karışık_Alışstırma
{
    partial class Form1
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
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblDiller = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnYeniDil = new System.Windows.Forms.Button();
            this.btnSecimleriKaldır = new System.Windows.Forms.Button();
            this.btnDilSil = new System.Windows.Forms.Button();
            this.grpMezuniyet = new System.Windows.Forms.GroupBox();
            this.rOrtaOkul = new System.Windows.Forms.RadioButton();
            this.rUniversite = new System.Windows.Forms.RadioButton();
            this.rLise = new System.Windows.Forms.RadioButton();
            this.rIlkokul = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpKayıtBilgileri = new System.Windows.Forms.GroupBox();
            this.lblDil = new System.Windows.Forms.Label();
            this.lblMezun = new System.Windows.Forms.Label();
            this.lblAS = new System.Windows.Forms.Label();
            this.lblBildigiDiller = new System.Windows.Forms.Label();
            this.lblMezuniyet = new System.Windows.Forms.Label();
            this.lblKayıtAdSoyad = new System.Windows.Forms.Label();
            this.grpMezuniyet.SuspendLayout();
            this.grpKayıtBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(0, 21);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(83, 21);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(183, 20);
            this.txtAdsoyad.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 102);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(225, 109);
            this.checkedListBox1.TabIndex = 2;
            // 
            // lblDiller
            // 
            this.lblDiller.AutoSize = true;
            this.lblDiller.Location = new System.Drawing.Point(0, 71);
            this.lblDiller.Name = "lblDiller";
            this.lblDiller.Size = new System.Drawing.Size(72, 13);
            this.lblDiller.TabIndex = 3;
            this.lblDiller.Text = "Yabancı Diller";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // btnYeniDil
            // 
            this.btnYeniDil.Location = new System.Drawing.Point(150, 262);
            this.btnYeniDil.Name = "btnYeniDil";
            this.btnYeniDil.Size = new System.Drawing.Size(105, 23);
            this.btnYeniDil.TabIndex = 5;
            this.btnYeniDil.Text = "Yeni Dil Ekle";
            this.btnYeniDil.UseVisualStyleBackColor = true;
            this.btnYeniDil.Click += new System.EventHandler(this.btnYeniDil_Click);
            // 
            // btnSecimleriKaldır
            // 
            this.btnSecimleriKaldır.Location = new System.Drawing.Point(140, 300);
            this.btnSecimleriKaldır.Name = "btnSecimleriKaldır";
            this.btnSecimleriKaldır.Size = new System.Drawing.Size(115, 23);
            this.btnSecimleriKaldır.TabIndex = 5;
            this.btnSecimleriKaldır.Text = "Secimleri Kaldır";
            this.btnSecimleriKaldır.UseVisualStyleBackColor = true;
            this.btnSecimleriKaldır.Click += new System.EventHandler(this.btnSecimleriKaldır_Click);
            // 
            // btnDilSil
            // 
            this.btnDilSil.Location = new System.Drawing.Point(12, 300);
            this.btnDilSil.Name = "btnDilSil";
            this.btnDilSil.Size = new System.Drawing.Size(113, 23);
            this.btnDilSil.TabIndex = 5;
            this.btnDilSil.Text = "Secilen Dili Sil";
            this.btnDilSil.UseVisualStyleBackColor = true;
            this.btnDilSil.Click += new System.EventHandler(this.btnDilSil_Click);
            // 
            // grpMezuniyet
            // 
            this.grpMezuniyet.Controls.Add(this.rOrtaOkul);
            this.grpMezuniyet.Controls.Add(this.rUniversite);
            this.grpMezuniyet.Controls.Add(this.rLise);
            this.grpMezuniyet.Controls.Add(this.rIlkokul);
            this.grpMezuniyet.Location = new System.Drawing.Point(272, 12);
            this.grpMezuniyet.Name = "grpMezuniyet";
            this.grpMezuniyet.Size = new System.Drawing.Size(281, 133);
            this.grpMezuniyet.TabIndex = 6;
            this.grpMezuniyet.TabStop = false;
            this.grpMezuniyet.Text = "Mezuniyet";
            // 
            // rOrtaOkul
            // 
            this.rOrtaOkul.AutoSize = true;
            this.rOrtaOkul.Location = new System.Drawing.Point(6, 82);
            this.rOrtaOkul.Name = "rOrtaOkul";
            this.rOrtaOkul.Size = new System.Drawing.Size(70, 17);
            this.rOrtaOkul.TabIndex = 1;
            this.rOrtaOkul.TabStop = true;
            this.rOrtaOkul.Text = "Orta Okul";
            this.rOrtaOkul.UseVisualStyleBackColor = true;
            // 
            // rUniversite
            // 
            this.rUniversite.AutoSize = true;
            this.rUniversite.Location = new System.Drawing.Point(123, 82);
            this.rUniversite.Name = "rUniversite";
            this.rUniversite.Size = new System.Drawing.Size(72, 17);
            this.rUniversite.TabIndex = 0;
            this.rUniversite.TabStop = true;
            this.rUniversite.Text = "Universite";
            this.rUniversite.UseVisualStyleBackColor = true;
            // 
            // rLise
            // 
            this.rLise.AutoSize = true;
            this.rLise.Location = new System.Drawing.Point(123, 37);
            this.rLise.Name = "rLise";
            this.rLise.Size = new System.Drawing.Size(45, 17);
            this.rLise.TabIndex = 0;
            this.rLise.TabStop = true;
            this.rLise.Text = "Lİse";
            this.rLise.UseVisualStyleBackColor = true;
            // 
            // rIlkokul
            // 
            this.rIlkokul.AutoSize = true;
            this.rIlkokul.Location = new System.Drawing.Point(6, 37);
            this.rIlkokul.Name = "rIlkokul";
            this.rIlkokul.Size = new System.Drawing.Size(56, 17);
            this.rIlkokul.TabIndex = 0;
            this.rIlkokul.TabStop = true;
            this.rIlkokul.Text = "İlkokul";
            this.rIlkokul.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(467, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpKayıtBilgileri
            // 
            this.grpKayıtBilgileri.Controls.Add(this.lblDil);
            this.grpKayıtBilgileri.Controls.Add(this.lblMezun);
            this.grpKayıtBilgileri.Controls.Add(this.lblAS);
            this.grpKayıtBilgileri.Controls.Add(this.lblBildigiDiller);
            this.grpKayıtBilgileri.Controls.Add(this.lblMezuniyet);
            this.grpKayıtBilgileri.Controls.Add(this.lblKayıtAdSoyad);
            this.grpKayıtBilgileri.Location = new System.Drawing.Point(272, 197);
            this.grpKayıtBilgileri.Name = "grpKayıtBilgileri";
            this.grpKayıtBilgileri.Size = new System.Drawing.Size(281, 126);
            this.grpKayıtBilgileri.TabIndex = 8;
            this.grpKayıtBilgileri.TabStop = false;
            this.grpKayıtBilgileri.Text = "Kayıt Bilgileri";
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Location = new System.Drawing.Point(123, 57);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(19, 13);
            this.lblDil.TabIndex = 4;
            this.lblDil.Text = "----";
            // 
            // lblMezun
            // 
            this.lblMezun.AutoSize = true;
            this.lblMezun.Location = new System.Drawing.Point(133, 92);
            this.lblMezun.Name = "lblMezun";
            this.lblMezun.Size = new System.Drawing.Size(19, 13);
            this.lblMezun.TabIndex = 3;
            this.lblMezun.Text = "----";
            // 
            // lblAS
            // 
            this.lblAS.AutoSize = true;
            this.lblAS.Location = new System.Drawing.Point(133, 31);
            this.lblAS.Name = "lblAS";
            this.lblAS.Size = new System.Drawing.Size(19, 13);
            this.lblAS.TabIndex = 2;
            this.lblAS.Text = "----";
            // 
            // lblBildigiDiller
            // 
            this.lblBildigiDiller.AutoSize = true;
            this.lblBildigiDiller.Location = new System.Drawing.Point(34, 65);
            this.lblBildigiDiller.Name = "lblBildigiDiller";
            this.lblBildigiDiller.Size = new System.Drawing.Size(58, 13);
            this.lblBildigiDiller.TabIndex = 1;
            this.lblBildigiDiller.Text = "Bildigi diller";
            // 
            // lblMezuniyet
            // 
            this.lblMezuniyet.AutoSize = true;
            this.lblMezuniyet.Location = new System.Drawing.Point(34, 92);
            this.lblMezuniyet.Name = "lblMezuniyet";
            this.lblMezuniyet.Size = new System.Drawing.Size(55, 13);
            this.lblMezuniyet.TabIndex = 0;
            this.lblMezuniyet.Text = "Mezuniyet";
            // 
            // lblKayıtAdSoyad
            // 
            this.lblKayıtAdSoyad.AutoSize = true;
            this.lblKayıtAdSoyad.Location = new System.Drawing.Point(34, 30);
            this.lblKayıtAdSoyad.Name = "lblKayıtAdSoyad";
            this.lblKayıtAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblKayıtAdSoyad.TabIndex = 0;
            this.lblKayıtAdSoyad.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.grpKayıtBilgileri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpMezuniyet);
            this.Controls.Add(this.btnDilSil);
            this.Controls.Add(this.btnSecimleriKaldır);
            this.Controls.Add(this.btnYeniDil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDiller);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtAdsoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMezuniyet.ResumeLayout(false);
            this.grpMezuniyet.PerformLayout();
            this.grpKayıtBilgileri.ResumeLayout(false);
            this.grpKayıtBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblDiller;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnYeniDil;
        private System.Windows.Forms.Button btnSecimleriKaldır;
        private System.Windows.Forms.Button btnDilSil;
        private System.Windows.Forms.GroupBox grpMezuniyet;
        private System.Windows.Forms.RadioButton rOrtaOkul;
        private System.Windows.Forms.RadioButton rUniversite;
        private System.Windows.Forms.RadioButton rLise;
        private System.Windows.Forms.RadioButton rIlkokul;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grpKayıtBilgileri;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.Label lblMezun;
        private System.Windows.Forms.Label lblAS;
        private System.Windows.Forms.Label lblBildigiDiller;
        private System.Windows.Forms.Label lblMezuniyet;
        private System.Windows.Forms.Label lblKayıtAdSoyad;
    }
}

