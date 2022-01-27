
namespace WinForms_MasrafOtomasyonu
{
    partial class frmMasrafTipiYonetimi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMasrafTipi = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtMasrafTipi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMasrafTipi);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 461);
            this.panel1.TabIndex = 0;
            // 
            // lstMasrafTipi
            // 
            this.lstMasrafTipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMasrafTipi.FormattingEnabled = true;
            this.lstMasrafTipi.ItemHeight = 15;
            this.lstMasrafTipi.Location = new System.Drawing.Point(0, 0);
            this.lstMasrafTipi.Name = "lstMasrafTipi";
            this.lstMasrafTipi.Size = new System.Drawing.Size(539, 344);
            this.lstMasrafTipi.TabIndex = 2;
            this.lstMasrafTipi.DoubleClick += new System.EventHandler(this.lstMasrafTipi_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 10);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtMasrafTipi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcama Ekleme/Güncelleme/Silme";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(445, 58);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(364, 58);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(282, 58);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMasrafTipi
            // 
            this.txtMasrafTipi.Location = new System.Drawing.Point(6, 59);
            this.txtMasrafTipi.Name = "txtMasrafTipi";
            this.txtMasrafTipi.Size = new System.Drawing.Size(269, 23);
            this.txtMasrafTipi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masraf Tipi";
            // 
            // frmMasrafTipiYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMasrafTipiYonetimi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Masrafa Tip Yönetimi";
            this.Load += new System.EventHandler(this.frmHarcamaYonetimi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMasrafTipi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasrafTipi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
    }
}