
namespace WFA_BonusOdev
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFusya = new System.Windows.Forms.CheckBox();
            this.chkYavruAgzi = new System.Windows.Forms.CheckBox();
            this.chkToricelliMavisi = new System.Windows.Forms.CheckBox();
            this.chkTitanBeyazi = new System.Windows.Forms.CheckBox();
            this.chkYeşil = new System.Windows.Forms.CheckBox();
            this.chkMavi = new System.Windows.Forms.CheckBox();
            this.chkSari = new System.Windows.Forms.CheckBox();
            this.chkSiyah = new System.Windows.Forms.CheckBox();
            this.chkKirmizi = new System.Windows.Forms.CheckBox();
            this.chkBeyaz = new System.Windows.Forms.CheckBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblSeciliFiyat = new System.Windows.Forms.Label();
            this.lblSeciliKategori = new System.Windows.Forms.Label();
            this.lblSeciliUrunAd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Secilenler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.nudFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(25, 411);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(233, 41);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFusya);
            this.groupBox2.Controls.Add(this.chkYavruAgzi);
            this.groupBox2.Controls.Add(this.chkToricelliMavisi);
            this.groupBox2.Controls.Add(this.chkTitanBeyazi);
            this.groupBox2.Controls.Add(this.chkYeşil);
            this.groupBox2.Controls.Add(this.chkMavi);
            this.groupBox2.Controls.Add(this.chkSari);
            this.groupBox2.Controls.Add(this.chkSiyah);
            this.groupBox2.Controls.Add(this.chkKirmizi);
            this.groupBox2.Controls.Add(this.chkBeyaz);
            this.groupBox2.Location = new System.Drawing.Point(25, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 233);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk";
            // 
            // chkFusya
            // 
            this.chkFusya.AutoSize = true;
            this.chkFusya.Location = new System.Drawing.Point(123, 194);
            this.chkFusya.Name = "chkFusya";
            this.chkFusya.Size = new System.Drawing.Size(54, 17);
            this.chkFusya.TabIndex = 0;
            this.chkFusya.Text = "Fuşya";
            this.chkFusya.UseVisualStyleBackColor = true;
            // 
            // chkYavruAgzi
            // 
            this.chkYavruAgzi.AutoSize = true;
            this.chkYavruAgzi.Location = new System.Drawing.Point(15, 194);
            this.chkYavruAgzi.Name = "chkYavruAgzi";
            this.chkYavruAgzi.Size = new System.Drawing.Size(73, 17);
            this.chkYavruAgzi.TabIndex = 0;
            this.chkYavruAgzi.Text = "Yavruağzı";
            this.chkYavruAgzi.UseVisualStyleBackColor = true;
            // 
            // chkToricelliMavisi
            // 
            this.chkToricelliMavisi.AutoSize = true;
            this.chkToricelliMavisi.Location = new System.Drawing.Point(123, 156);
            this.chkToricelliMavisi.Name = "chkToricelliMavisi";
            this.chkToricelliMavisi.Size = new System.Drawing.Size(95, 17);
            this.chkToricelliMavisi.TabIndex = 0;
            this.chkToricelliMavisi.Text = "Toricelli Mavisi";
            this.chkToricelliMavisi.UseVisualStyleBackColor = true;
            // 
            // chkTitanBeyazi
            // 
            this.chkTitanBeyazi.AutoSize = true;
            this.chkTitanBeyazi.Location = new System.Drawing.Point(15, 156);
            this.chkTitanBeyazi.Name = "chkTitanBeyazi";
            this.chkTitanBeyazi.Size = new System.Drawing.Size(84, 17);
            this.chkTitanBeyazi.TabIndex = 0;
            this.chkTitanBeyazi.Text = "Titan Beyazı";
            this.chkTitanBeyazi.UseVisualStyleBackColor = true;
            // 
            // chkYeşil
            // 
            this.chkYeşil.AutoSize = true;
            this.chkYeşil.Location = new System.Drawing.Point(123, 118);
            this.chkYeşil.Name = "chkYeşil";
            this.chkYeşil.Size = new System.Drawing.Size(48, 17);
            this.chkYeşil.TabIndex = 0;
            this.chkYeşil.Text = "Yeşil";
            this.chkYeşil.UseVisualStyleBackColor = true;
            // 
            // chkMavi
            // 
            this.chkMavi.AutoSize = true;
            this.chkMavi.Location = new System.Drawing.Point(15, 118);
            this.chkMavi.Name = "chkMavi";
            this.chkMavi.Size = new System.Drawing.Size(49, 17);
            this.chkMavi.TabIndex = 0;
            this.chkMavi.Text = "Mavi";
            this.chkMavi.UseVisualStyleBackColor = true;
            // 
            // chkSari
            // 
            this.chkSari.AutoSize = true;
            this.chkSari.Location = new System.Drawing.Point(123, 77);
            this.chkSari.Name = "chkSari";
            this.chkSari.Size = new System.Drawing.Size(44, 17);
            this.chkSari.TabIndex = 0;
            this.chkSari.Text = "Sarı";
            this.chkSari.UseVisualStyleBackColor = true;
            // 
            // chkSiyah
            // 
            this.chkSiyah.AutoSize = true;
            this.chkSiyah.Location = new System.Drawing.Point(123, 41);
            this.chkSiyah.Name = "chkSiyah";
            this.chkSiyah.Size = new System.Drawing.Size(52, 17);
            this.chkSiyah.TabIndex = 0;
            this.chkSiyah.Text = "Siyah";
            this.chkSiyah.UseVisualStyleBackColor = true;
            // 
            // chkKirmizi
            // 
            this.chkKirmizi.AutoSize = true;
            this.chkKirmizi.Location = new System.Drawing.Point(15, 77);
            this.chkKirmizi.Name = "chkKirmizi";
            this.chkKirmizi.Size = new System.Drawing.Size(55, 17);
            this.chkKirmizi.TabIndex = 0;
            this.chkKirmizi.Text = "Kırmızı";
            this.chkKirmizi.UseVisualStyleBackColor = true;
            // 
            // chkBeyaz
            // 
            this.chkBeyaz.AutoSize = true;
            this.chkBeyaz.Location = new System.Drawing.Point(15, 41);
            this.chkBeyaz.Name = "chkBeyaz";
            this.chkBeyaz.Size = new System.Drawing.Size(55, 17);
            this.chkBeyaz.TabIndex = 0;
            this.chkBeyaz.Text = "Beyaz";
            this.chkBeyaz.UseVisualStyleBackColor = true;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(75, 122);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(183, 20);
            this.nudFiyat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyat:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(75, 76);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(183, 21);
            this.cmbKategori.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(75, 36);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(183, 20);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(289, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 467);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Renk";
            this.columnHeader4.Width = 131;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRenk);
            this.groupBox3.Controls.Add(this.lblSeciliFiyat);
            this.groupBox3.Controls.Add(this.lblSeciliKategori);
            this.groupBox3.Controls.Add(this.lblSeciliUrunAd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(772, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçili Ürün";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(138, 185);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(19, 20);
            this.lblRenk.TabIndex = 0;
            this.lblRenk.Text = "--";
            // 
            // lblSeciliFiyat
            // 
            this.lblSeciliFiyat.AutoSize = true;
            this.lblSeciliFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliFiyat.Location = new System.Drawing.Point(138, 142);
            this.lblSeciliFiyat.Name = "lblSeciliFiyat";
            this.lblSeciliFiyat.Size = new System.Drawing.Size(19, 20);
            this.lblSeciliFiyat.TabIndex = 0;
            this.lblSeciliFiyat.Text = "--";
            // 
            // lblSeciliKategori
            // 
            this.lblSeciliKategori.AutoSize = true;
            this.lblSeciliKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliKategori.Location = new System.Drawing.Point(138, 98);
            this.lblSeciliKategori.Name = "lblSeciliKategori";
            this.lblSeciliKategori.Size = new System.Drawing.Size(19, 20);
            this.lblSeciliKategori.TabIndex = 0;
            this.lblSeciliKategori.Text = "--";
            // 
            // lblSeciliUrunAd
            // 
            this.lblSeciliUrunAd.AutoSize = true;
            this.lblSeciliUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliUrunAd.Location = new System.Drawing.Point(138, 55);
            this.lblSeciliUrunAd.Name = "lblSeciliUrunAd";
            this.lblSeciliUrunAd.Size = new System.Drawing.Size(19, 20);
            this.lblSeciliUrunAd.TabIndex = 0;
            this.lblSeciliUrunAd.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seçili Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Adı:";
            // 
            // Secilenler
            // 
            this.Secilenler.FormattingEnabled = true;
            this.Secilenler.Location = new System.Drawing.Point(763, 258);
            this.Secilenler.Name = "Secilenler";
            this.Secilenler.Size = new System.Drawing.Size(358, 238);
            this.Secilenler.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 675);
            this.Controls.Add(this.Secilenler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFusya;
        private System.Windows.Forms.CheckBox chkYavruAgzi;
        private System.Windows.Forms.CheckBox chkToricelliMavisi;
        private System.Windows.Forms.CheckBox chkTitanBeyazi;
        private System.Windows.Forms.CheckBox chkYeşil;
        private System.Windows.Forms.CheckBox chkMavi;
        private System.Windows.Forms.CheckBox chkSari;
        private System.Windows.Forms.CheckBox chkSiyah;
        private System.Windows.Forms.CheckBox chkKirmizi;
        private System.Windows.Forms.CheckBox chkBeyaz;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblSeciliFiyat;
        private System.Windows.Forms.Label lblSeciliKategori;
        private System.Windows.Forms.Label lblSeciliUrunAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Secilenler;
    }
}

