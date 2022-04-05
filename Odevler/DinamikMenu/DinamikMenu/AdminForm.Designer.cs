
namespace DinamikMenu
{
    partial class AdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.btnMenuGuncelle = new System.Windows.Forms.Button();
            this.btnEkstraGuncelle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.nmMenuFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtMenu1 = new System.Windows.Forms.TextBox();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMenuFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMenu1);
            this.groupBox1.Controls.Add(this.nmMenuFiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menüler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MENU FIYATI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEkstra);
            this.groupBox2.Controls.Add(this.nmEkstraFiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(440, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstralar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FIYATI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EKSTRA MALZEME ADI";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Location = new System.Drawing.Point(49, 172);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(53, 36);
            this.btnMenuEkle.TabIndex = 2;
            this.btnMenuEkle.Text = "Menu Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(440, 172);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(77, 49);
            this.btnEkstraEkle.TabIndex = 3;
            this.btnEkstraEkle.Text = "Ekstra Malzeme Ekle";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // btnMenuGuncelle
            // 
            this.btnMenuGuncelle.Location = new System.Drawing.Point(248, 172);
            this.btnMenuGuncelle.Name = "btnMenuGuncelle";
            this.btnMenuGuncelle.Size = new System.Drawing.Size(67, 36);
            this.btnMenuGuncelle.TabIndex = 4;
            this.btnMenuGuncelle.Text = "Menu Güncelle";
            this.btnMenuGuncelle.UseVisualStyleBackColor = true;
            this.btnMenuGuncelle.Click += new System.EventHandler(this.btnMenuGuncelle_Click);
            // 
            // btnEkstraGuncelle
            // 
            this.btnEkstraGuncelle.Location = new System.Drawing.Point(624, 172);
            this.btnEkstraGuncelle.Name = "btnEkstraGuncelle";
            this.btnEkstraGuncelle.Size = new System.Drawing.Size(82, 49);
            this.btnEkstraGuncelle.TabIndex = 5;
            this.btnEkstraGuncelle.Text = "Ekstra Malzeme Güncelle";
            this.btnEkstraGuncelle.UseVisualStyleBackColor = true;
            this.btnEkstraGuncelle.Click += new System.EventHandler(this.btnEkstraGuncelle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 160);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(440, 244);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(266, 160);
            this.listBox2.TabIndex = 7;
            // 
            // nmMenuFiyat
            // 
            this.nmMenuFiyat.Location = new System.Drawing.Point(116, 72);
            this.nmMenuFiyat.Name = "nmMenuFiyat";
            this.nmMenuFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmMenuFiyat.TabIndex = 11;
            // 
            // nmEkstraFiyat
            // 
            this.nmEkstraFiyat.Location = new System.Drawing.Point(138, 84);
            this.nmEkstraFiyat.Name = "nmEkstraFiyat";
            this.nmEkstraFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmEkstraFiyat.TabIndex = 12;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(306, 444);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(166, 36);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu Sayfasına Git";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtMenu1
            // 
            this.txtMenu1.Location = new System.Drawing.Point(116, 32);
            this.txtMenu1.Name = "txtMenu1";
            this.txtMenu1.Size = new System.Drawing.Size(120, 20);
            this.txtMenu1.TabIndex = 9;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(138, 41);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(120, 20);
            this.txtEkstra.TabIndex = 13;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 503);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkstraGuncelle);
            this.Controls.Add(this.btnMenuGuncelle);
            this.Controls.Add(this.btnEkstraEkle);
            this.Controls.Add(this.btnMenuEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMenuFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.Button btnEkstraEkle;
        private System.Windows.Forms.Button btnMenuGuncelle;
        private System.Windows.Forms.Button btnEkstraGuncelle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.NumericUpDown nmMenuFiyat;
        private System.Windows.Forms.NumericUpDown nmEkstraFiyat;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtMenu1;
        private System.Windows.Forms.TextBox txtEkstra;
    }
}