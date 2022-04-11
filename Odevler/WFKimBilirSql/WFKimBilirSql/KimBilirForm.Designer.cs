namespace WFKimBilirSql
{
    partial class KimBilirForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBilirKisi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblSayac = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(256, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(603, 317);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 343;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 179;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Puan";
            // 
            // btnBilirKisi
            // 
            this.btnBilirKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilirKisi.Location = new System.Drawing.Point(256, 359);
            this.btnBilirKisi.Name = "btnBilirKisi";
            this.btnBilirKisi.Size = new System.Drawing.Size(603, 45);
            this.btnBilirKisi.TabIndex = 6;
            this.btnBilirKisi.Text = "Bilir Kişi";
            this.btnBilirKisi.UseVisualStyleBackColor = true;
            this.btnBilirKisi.Click += new System.EventHandler(this.BtnBilirKisi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 381);
            this.listBox1.TabIndex = 5;
            // 
            // lblSayac
            // 
            this.lblSayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(885, 23);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(166, 165);
            this.lblSayac.TabIndex = 8;
            this.lblSayac.Text = "30";
            this.lblSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KimBilirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 410);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBilirKisi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSayac);
            this.Name = "KimBilirForm";
            this.Text = "KimBilirForm";
            this.Load += new System.EventHandler(this.KimBilirForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnBilirKisi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Timer timer1;
    }
}