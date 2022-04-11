namespace WFKimBilirSql
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kimBilirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kimBilirToolStripMenuItem,
            this.ogrenciBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kimBilirToolStripMenuItem
            // 
            this.kimBilirToolStripMenuItem.Name = "kimBilirToolStripMenuItem";
            this.kimBilirToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kimBilirToolStripMenuItem.Text = "Kim Bilir";
            this.kimBilirToolStripMenuItem.Click += new System.EventHandler(this.KimBilirToolStripMenuItem_Click);
            // 
            // ogrenciBilgileriToolStripMenuItem
            // 
            this.ogrenciBilgileriToolStripMenuItem.Name = "ogrenciBilgileriToolStripMenuItem";
            this.ogrenciBilgileriToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.ogrenciBilgileriToolStripMenuItem.Text = "Ogrenci Bilgileri";
            this.ogrenciBilgileriToolStripMenuItem.Click += new System.EventHandler(this.OgrenciBilgileriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
        
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kimBilirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciBilgileriToolStripMenuItem;
    }
}

