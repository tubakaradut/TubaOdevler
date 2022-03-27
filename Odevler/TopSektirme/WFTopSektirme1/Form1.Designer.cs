
namespace WFTopSektirme1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.timerSağ = new System.Windows.Forms.Timer(this.components);
            this.timerYukari = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTop
            // 
            this.pbTop.Image = ((System.Drawing.Image)(resources.GetObject("pbTop.Image")));
            this.pbTop.Location = new System.Drawing.Point(389, 136);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(109, 104);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTop.TabIndex = 0;
            this.pbTop.TabStop = false;
            // 
            // timerSağ
            // 
            this.timerSağ.Tick += new System.EventHandler(this.timerSağ_Tick);
            // 
            // timerYukari
            // 
            this.timerYukari.Tick += new System.EventHandler(this.timerYukari_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1041, 540);
            this.Controls.Add(this.pbTop);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.Timer timerSağ;
        private System.Windows.Forms.Timer timerYukari;
    }
}

