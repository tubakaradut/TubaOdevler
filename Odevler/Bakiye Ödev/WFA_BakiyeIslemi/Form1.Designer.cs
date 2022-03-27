
namespace WFA_BakiyeIslemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.nudParaCek = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.nudParaYatir = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudPeynir = new System.Windows.Forms.NumericUpDown();
            this.nudCikolata = new System.Windows.Forms.NumericUpDown();
            this.nudCay = new System.Windows.Forms.NumericUpDown();
            this.nudYumurta = new System.Windows.Forms.NumericUpDown();
            this.nudEkmek = new System.Windows.Forms.NumericUpDown();
            this.btnAlisverisTamamla = new System.Windows.Forms.Button();
            this.chcPeynir = new System.Windows.Forms.CheckBox();
            this.chcCikolata = new System.Windows.Forms.CheckBox();
            this.chcCay = new System.Windows.Forms.CheckBox();
            this.chcYumurta = new System.Windows.Forms.CheckBox();
            this.chcEkmek = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeynir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCikolata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYumurta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkmek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye";
            // 
            // lblBakiye
            // 
            this.lblBakiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(51, 64);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(467, 101);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "0.00 TL";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Controls.Add(this.nudParaCek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(51, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Çek";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(80, 72);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(120, 31);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // nudParaCek
            // 
            this.nudParaCek.Location = new System.Drawing.Point(80, 39);
            this.nudParaCek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaCek.Name = "nudParaCek";
            this.nudParaCek.Size = new System.Drawing.Size(120, 26);
            this.nudParaCek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnParaYatir);
            this.groupBox2.Controls.Add(this.nudParaYatir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(290, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Yatır";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(86, 71);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(120, 31);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // nudParaYatir
            // 
            this.nudParaYatir.Location = new System.Drawing.Point(86, 39);
            this.nudParaYatir.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaYatir.Name = "nudParaYatir";
            this.nudParaYatir.Size = new System.Drawing.Size(120, 26);
            this.nudParaYatir.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(51, 313);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 172);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudPeynir);
            this.groupBox3.Controls.Add(this.nudCikolata);
            this.groupBox3.Controls.Add(this.nudCay);
            this.groupBox3.Controls.Add(this.nudYumurta);
            this.groupBox3.Controls.Add(this.nudEkmek);
            this.groupBox3.Controls.Add(this.btnAlisverisTamamla);
            this.groupBox3.Controls.Add(this.chcPeynir);
            this.groupBox3.Controls.Add(this.chcCikolata);
            this.groupBox3.Controls.Add(this.chcCay);
            this.groupBox3.Controls.Add(this.chcYumurta);
            this.groupBox3.Controls.Add(this.chcEkmek);
            this.groupBox3.Location = new System.Drawing.Point(600, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 252);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alışveriş Listesi";
            // 
            // nudPeynir
            // 
            this.nudPeynir.Location = new System.Drawing.Point(209, 168);
            this.nudPeynir.Name = "nudPeynir";
            this.nudPeynir.Size = new System.Drawing.Size(120, 20);
            this.nudPeynir.TabIndex = 6;
            // 
            // nudCikolata
            // 
            this.nudCikolata.Location = new System.Drawing.Point(209, 133);
            this.nudCikolata.Name = "nudCikolata";
            this.nudCikolata.Size = new System.Drawing.Size(120, 20);
            this.nudCikolata.TabIndex = 5;
            // 
            // nudCay
            // 
            this.nudCay.Location = new System.Drawing.Point(209, 95);
            this.nudCay.Name = "nudCay";
            this.nudCay.Size = new System.Drawing.Size(120, 20);
            this.nudCay.TabIndex = 4;
            // 
            // nudYumurta
            // 
            this.nudYumurta.Location = new System.Drawing.Point(209, 60);
            this.nudYumurta.Name = "nudYumurta";
            this.nudYumurta.Size = new System.Drawing.Size(120, 20);
            this.nudYumurta.TabIndex = 3;
            // 
            // nudEkmek
            // 
            this.nudEkmek.Location = new System.Drawing.Point(209, 28);
            this.nudEkmek.Name = "nudEkmek";
            this.nudEkmek.Size = new System.Drawing.Size(120, 20);
            this.nudEkmek.TabIndex = 2;
            // 
            // btnAlisverisTamamla
            // 
            this.btnAlisverisTamamla.Location = new System.Drawing.Point(20, 194);
            this.btnAlisverisTamamla.Name = "btnAlisverisTamamla";
            this.btnAlisverisTamamla.Size = new System.Drawing.Size(246, 42);
            this.btnAlisverisTamamla.TabIndex = 1;
            this.btnAlisverisTamamla.Text = "Alışverişi Tamamla";
            this.btnAlisverisTamamla.UseVisualStyleBackColor = true;
            this.btnAlisverisTamamla.Click += new System.EventHandler(this.button1_Click);
            // 
            // chcPeynir
            // 
            this.chcPeynir.AutoSize = true;
            this.chcPeynir.Location = new System.Drawing.Point(20, 165);
            this.chcPeynir.Name = "chcPeynir";
            this.chcPeynir.Size = new System.Drawing.Size(92, 17);
            this.chcPeynir.TabIndex = 0;
            this.chcPeynir.Text = "Peynir (45 TL)";
            this.chcPeynir.UseVisualStyleBackColor = true;
            // 
            // chcCikolata
            // 
            this.chcCikolata.AutoSize = true;
            this.chcCikolata.Location = new System.Drawing.Point(20, 133);
            this.chcCikolata.Name = "chcCikolata";
            this.chcCikolata.Size = new System.Drawing.Size(98, 17);
            this.chcCikolata.TabIndex = 0;
            this.chcCikolata.Text = "Çikolata (30TL)";
            this.chcCikolata.UseVisualStyleBackColor = true;
            // 
            // chcCay
            // 
            this.chcCay.AutoSize = true;
            this.chcCay.Location = new System.Drawing.Point(20, 98);
            this.chcCay.Name = "chcCay";
            this.chcCay.Size = new System.Drawing.Size(102, 17);
            this.chcCay.TabIndex = 0;
            this.chcCay.Text = "Çay (1 kg 35TL)";
            this.chcCay.UseVisualStyleBackColor = true;
            // 
            // chcYumurta
            // 
            this.chcYumurta.AutoSize = true;
            this.chcYumurta.Location = new System.Drawing.Point(20, 63);
            this.chcYumurta.Name = "chcYumurta";
            this.chcYumurta.Size = new System.Drawing.Size(124, 17);
            this.chcYumurta.TabIndex = 0;
            this.chcYumurta.Text = "Yumurta (10\'lu 20TL)";
            this.chcYumurta.UseVisualStyleBackColor = true;
            // 
            // chcEkmek
            // 
            this.chcEkmek.AutoSize = true;
            this.chcEkmek.Location = new System.Drawing.Point(20, 31);
            this.chcEkmek.Name = "chcEkmek";
            this.chcEkmek.Size = new System.Drawing.Size(90, 17);
            this.chcEkmek.TabIndex = 0;
            this.chcEkmek.Text = "Ekmek (4 TL)";
            this.chcEkmek.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(583, 312);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(404, 173);
            this.listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 620);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeynir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCikolata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYumurta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkmek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.NumericUpDown nudParaCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.NumericUpDown nudParaYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAlisverisTamamla;
        private System.Windows.Forms.CheckBox chcPeynir;
        private System.Windows.Forms.CheckBox chcCikolata;
        private System.Windows.Forms.CheckBox chcCay;
        private System.Windows.Forms.CheckBox chcYumurta;
        private System.Windows.Forms.CheckBox chcEkmek;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.NumericUpDown nudEkmek;
        private System.Windows.Forms.NumericUpDown nudPeynir;
        private System.Windows.Forms.NumericUpDown nudCikolata;
        private System.Windows.Forms.NumericUpDown nudCay;
        private System.Windows.Forms.NumericUpDown nudYumurta;
    }
}

