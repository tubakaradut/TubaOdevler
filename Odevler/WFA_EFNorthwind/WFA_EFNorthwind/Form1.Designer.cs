
namespace WFA_EFNorthwind
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
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nakliyeciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.çalışanToolStripMenuItem,
            this.siparişToolStripMenuItem,
            this.tedarikçiToolStripMenuItem,
            this.nakliyeciToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.ürünToolStripMenuItem.Text = "Ürün";
            this.ürünToolStripMenuItem.Click += new System.EventHandler(this.ürünToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            this.müşteriToolStripMenuItem.Click += new System.EventHandler(this.müşteriToolStripMenuItem_Click);
            // 
            // çalışanToolStripMenuItem
            // 
            this.çalışanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.çalışanToolStripMenuItem.Name = "çalışanToolStripMenuItem";
            this.çalışanToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.çalışanToolStripMenuItem.Text = "Çalışan";
            this.çalışanToolStripMenuItem.Click += new System.EventHandler(this.çalışanToolStripMenuItem_Click);
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            this.siparişToolStripMenuItem.Click += new System.EventHandler(this.siparişToolStripMenuItem_Click);
            // 
            // tedarikçiToolStripMenuItem
            // 
            this.tedarikçiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tedarikçiToolStripMenuItem.Name = "tedarikçiToolStripMenuItem";
            this.tedarikçiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.tedarikçiToolStripMenuItem.Text = "Tedarikçi";
            this.tedarikçiToolStripMenuItem.Click += new System.EventHandler(this.tedarikçiToolStripMenuItem_Click);
            // 
            // nakliyeciToolStripMenuItem
            // 
            this.nakliyeciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.nakliyeciToolStripMenuItem.Name = "nakliyeciToolStripMenuItem";
            this.nakliyeciToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.nakliyeciToolStripMenuItem.Text = "Nakliyeci";
            this.nakliyeciToolStripMenuItem.Click += new System.EventHandler(this.nakliyeciToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 673);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nakliyeciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
    }
}

