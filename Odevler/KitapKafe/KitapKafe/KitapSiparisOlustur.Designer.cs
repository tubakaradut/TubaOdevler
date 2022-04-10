
namespace KitapKafe
{
    partial class KitapSiparisOlustur
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
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTamamlaKitap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpKitapEkstralar = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.btnHesaplaıcecek = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(502, 393);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(40, 20);
            this.lblToplamTutar.TabIndex = 67;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(386, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "Toplam Tutar: ";
            // 
            // btnTamamlaKitap
            // 
            this.btnTamamlaKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamlaKitap.Location = new System.Drawing.Point(714, 393);
            this.btnTamamlaKitap.Name = "btnTamamlaKitap";
            this.btnTamamlaKitap.Size = new System.Drawing.Size(232, 42);
            this.btnTamamlaKitap.TabIndex = 65;
            this.btnTamamlaKitap.Text = "Siparişi Tamamla";
            this.btnTamamlaKitap.UseVisualStyleBackColor = true;
            this.btnTamamlaKitap.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(390, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 368);
            this.listBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Kitap Menu";
            // 
            // GrpKitapEkstralar
            // 
            this.GrpKitapEkstralar.Location = new System.Drawing.Point(12, 223);
            this.GrpKitapEkstralar.Name = "GrpKitapEkstralar";
            this.GrpKitapEkstralar.Size = new System.Drawing.Size(350, 116);
            this.GrpKitapEkstralar.TabIndex = 62;
            // 
            // cmbKitap
            // 
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(12, 50);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(340, 32);
            this.cmbKitap.TabIndex = 55;
            // 
            // btnHesaplaıcecek
            // 
            this.btnHesaplaıcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesaplaıcecek.Location = new System.Drawing.Point(19, 393);
            this.btnHesaplaıcecek.Name = "btnHesaplaıcecek";
            this.btnHesaplaıcecek.Size = new System.Drawing.Size(232, 42);
            this.btnHesaplaıcecek.TabIndex = 61;
            this.btnHesaplaıcecek.Text = "Hesapla";
            this.btnHesaplaıcecek.UseVisualStyleBackColor = true;
            this.btnHesaplaıcecek.Click += new System.EventHandler(this.btnHesaplaıcecek_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(78, 349);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(176, 29);
            this.nudAdet.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Adet:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 106);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyatı";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazarı";
            this.label4.Visible = false;
            // 
            // KitapSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnTamamlaKitap);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrpKitapEkstralar);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.btnHesaplaıcecek);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label1);
            this.Name = "KitapSiparisOlustur";
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.KitapSiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTamamlaKitap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel GrpKitapEkstralar;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Button btnHesaplaıcecek;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}