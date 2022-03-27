
namespace Hamburgerr
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
            this.label12 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chcSarımsaklı = new System.Windows.Forms.CheckBox();
            this.chcKetcap = new System.Windows.Forms.CheckBox();
            this.chcChaddar = new System.Windows.Forms.CheckBox();
            this.chcMayonez = new System.Windows.Forms.CheckBox();
            this.chcRanch = new System.Windows.Forms.CheckBox();
            this.chcBufolo = new System.Windows.Forms.CheckBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.cbmMenü = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.nmdAdet = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Tavuklu=20TL";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ekstralar";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boyut";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Menü";
            this.columnHeader1.Width = 128;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(342, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(621, 156);
            this.listView1.TabIndex = 77;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.Width = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Menüler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chcSarımsaklı);
            this.groupBox2.Controls.Add(this.chcKetcap);
            this.groupBox2.Controls.Add(this.chcChaddar);
            this.groupBox2.Controls.Add(this.chcMayonez);
            this.groupBox2.Controls.Add(this.chcRanch);
            this.groupBox2.Controls.Add(this.chcBufolo);
            this.groupBox2.Location = new System.Drawing.Point(19, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 121);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // chcSarımsaklı
            // 
            this.chcSarımsaklı.AutoSize = true;
            this.chcSarımsaklı.Location = new System.Drawing.Point(113, 51);
            this.chcSarımsaklı.Name = "chcSarımsaklı";
            this.chcSarımsaklı.Size = new System.Drawing.Size(88, 17);
            this.chcSarımsaklı.TabIndex = 13;
            this.chcSarımsaklı.Text = "Sarımsaklı M.";
            this.chcSarımsaklı.UseVisualStyleBackColor = true;
            // 
            // chcKetcap
            // 
            this.chcKetcap.AutoSize = true;
            this.chcKetcap.Location = new System.Drawing.Point(7, 19);
            this.chcKetcap.Name = "chcKetcap";
            this.chcKetcap.Size = new System.Drawing.Size(60, 17);
            this.chcKetcap.TabIndex = 8;
            this.chcKetcap.Text = "Ketcap";
            this.chcKetcap.UseVisualStyleBackColor = true;
            // 
            // chcChaddar
            // 
            this.chcChaddar.AutoSize = true;
            this.chcChaddar.Location = new System.Drawing.Point(113, 19);
            this.chcChaddar.Name = "chcChaddar";
            this.chcChaddar.Size = new System.Drawing.Size(66, 17);
            this.chcChaddar.TabIndex = 12;
            this.chcChaddar.Text = "Chaddar";
            this.chcChaddar.UseVisualStyleBackColor = true;
            // 
            // chcMayonez
            // 
            this.chcMayonez.AutoSize = true;
            this.chcMayonez.Location = new System.Drawing.Point(6, 51);
            this.chcMayonez.Name = "chcMayonez";
            this.chcMayonez.Size = new System.Drawing.Size(69, 17);
            this.chcMayonez.TabIndex = 9;
            this.chcMayonez.Text = "Mayonez";
            this.chcMayonez.UseVisualStyleBackColor = true;
            // 
            // chcRanch
            // 
            this.chcRanch.AutoSize = true;
            this.chcRanch.Location = new System.Drawing.Point(113, 85);
            this.chcRanch.Name = "chcRanch";
            this.chcRanch.Size = new System.Drawing.Size(58, 17);
            this.chcRanch.TabIndex = 11;
            this.chcRanch.Text = "Ranch";
            this.chcRanch.UseVisualStyleBackColor = true;
            // 
            // chcBufolo
            // 
            this.chcBufolo.AutoSize = true;
            this.chcBufolo.Location = new System.Drawing.Point(7, 85);
            this.chcBufolo.Name = "chcBufolo";
            this.chcBufolo.Size = new System.Drawing.Size(56, 17);
            this.chcBufolo.TabIndex = 10;
            this.chcBufolo.Text = "Bufola";
            this.chcBufolo.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(180, 152);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(62, 17);
            this.rbBuyuk.TabIndex = 57;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "BUYUK";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(105, 152);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(55, 17);
            this.rbOrta.TabIndex = 56;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "ORTA";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(27, 152);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(62, 17);
            this.rbKucuk.TabIndex = 55;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "KUCUK";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // cbmMenü
            // 
            this.cbmMenü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMenü.FormattingEnabled = true;
            this.cbmMenü.Location = new System.Drawing.Point(37, 104);
            this.cbmMenü.Name = "cbmMenü";
            this.cbmMenü.Size = new System.Drawing.Size(153, 21);
            this.cbmMenü.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Adet";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(424, 219);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(13, 13);
            this.lblToplamFiyat.TabIndex = 76;
            this.lblToplamFiyat.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Toplam Tutar";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(213, 383);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(92, 13);
            this.lblToplam.TabIndex = 74;
            this.lblToplam.Text = "Her bir ekstra 2TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Menüler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Boyutlar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Orta 3TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Büyük 5TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Kücük 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Menüler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "StackHouse=35TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Whooper=25TL";
            // 
            // btnSiparis
            // 
            this.btnSiparis.AutoSize = true;
            this.btnSiparis.Location = new System.Drawing.Point(663, 250);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(94, 23);
            this.btnSiparis.TabIndex = 64;
            this.btnSiparis.Text = "Siparis Tamamla";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(342, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 199);
            this.listBox1.TabIndex = 63;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(199, 319);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 61;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // nmdAdet
            // 
            this.nmdAdet.Location = new System.Drawing.Point(59, 320);
            this.nmdAdet.Name = "nmdAdet";
            this.nmdAdet.Size = new System.Drawing.Size(120, 20);
            this.nmdAdet.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 537);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbKucuk);
            this.Controls.Add(this.cbmMenü);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nmdAdet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chcSarımsaklı;
        private System.Windows.Forms.CheckBox chcKetcap;
        private System.Windows.Forms.CheckBox chcChaddar;
        private System.Windows.Forms.CheckBox chcMayonez;
        private System.Windows.Forms.CheckBox chcRanch;
        private System.Windows.Forms.CheckBox chcBufolo;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.ComboBox cbmMenü;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown nmdAdet;
    }
}

