
namespace KitapKafe
{
    partial class IcecekOlustur
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudicecekFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnİcecekEkle = new System.Windows.Forms.Button();
            this.txticecekAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudicecekFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudicecekFiyat);
            this.groupBox1.Controls.Add(this.btnİcecekEkle);
            this.groupBox1.Controls.Add(this.txticecekAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İçecek Bilgiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı";
            // 
            // nudicecekFiyat
            // 
            this.nudicecekFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudicecekFiyat.Location = new System.Drawing.Point(115, 88);
            this.nudicecekFiyat.Name = "nudicecekFiyat";
            this.nudicecekFiyat.Size = new System.Drawing.Size(224, 29);
            this.nudicecekFiyat.TabIndex = 2;
            // 
            // btnİcecekEkle
            // 
            this.btnİcecekEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİcecekEkle.Location = new System.Drawing.Point(51, 146);
            this.btnİcecekEkle.Name = "btnİcecekEkle";
            this.btnİcecekEkle.Size = new System.Drawing.Size(224, 37);
            this.btnİcecekEkle.TabIndex = 1;
            this.btnİcecekEkle.Text = "Ekle";
            this.btnİcecekEkle.UseVisualStyleBackColor = true;
            this.btnİcecekEkle.Click += new System.EventHandler(this.btnİcecekEkle_Click);
            // 
            // txticecekAdi
            // 
            this.txticecekAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txticecekAdi.Location = new System.Drawing.Point(115, 36);
            this.txticecekAdi.Name = "txticecekAdi";
            this.txticecekAdi.Size = new System.Drawing.Size(224, 29);
            this.txticecekAdi.TabIndex = 0;
            // 
            // IcecekOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "IcecekOlustur";
            this.Text = "IcecekOlustur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudicecekFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudicecekFiyat;
        private System.Windows.Forms.Button btnİcecekEkle;
        private System.Windows.Forms.TextBox txticecekAdi;
    }
}