
namespace Constructor
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstEkmek = new System.Windows.Forms.ListBox();
            this.lstTekstil = new System.Windows.Forms.ListBox();
            this.lstCeptelefonu = new System.Windows.Forms.ListBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(533, 353);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // lstEkmek
            // 
            this.lstEkmek.FormattingEnabled = true;
            this.lstEkmek.Location = new System.Drawing.Point(12, 12);
            this.lstEkmek.Name = "lstEkmek";
            this.lstEkmek.Size = new System.Drawing.Size(262, 95);
            this.lstEkmek.TabIndex = 1;
            // 
            // lstTekstil
            // 
            this.lstTekstil.FormattingEnabled = true;
            this.lstTekstil.Location = new System.Drawing.Point(12, 126);
            this.lstTekstil.Name = "lstTekstil";
            this.lstTekstil.Size = new System.Drawing.Size(262, 95);
            this.lstTekstil.TabIndex = 2;
            // 
            // lstCeptelefonu
            // 
            this.lstCeptelefonu.FormattingEnabled = true;
            this.lstCeptelefonu.Location = new System.Drawing.Point(12, 257);
            this.lstCeptelefonu.Name = "lstCeptelefonu";
            this.lstCeptelefonu.Size = new System.Drawing.Size(262, 95);
            this.lstCeptelefonu.TabIndex = 3;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(334, 12);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(387, 147);
            this.lstSepet.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstCeptelefonu);
            this.Controls.Add(this.lstTekstil);
            this.Controls.Add(this.lstEkmek);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstEkmek;
        private System.Windows.Forms.ListBox lstTekstil;
        private System.Windows.Forms.ListBox lstCeptelefonu;
        private System.Windows.Forms.ListBox lstSepet;
    }
}

