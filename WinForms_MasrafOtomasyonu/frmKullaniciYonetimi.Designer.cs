
namespace WinForms_MasrafOtomasyonu
{
    partial class frmKullaniciYonetimi
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
        {            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciYonetimi));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTamAdi = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTipi = new System.Windows.Forms.Label();
            this.flpLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblYoneticisi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYonetici = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInputPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mnuExcelAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstKullanicilar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpLabels.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flpInputPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Excel aktarım işlemi tamamlanmıştır.";
            this.notifyIcon1.BalloonTipTitle = "Aktarım Tamamlandı";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblTamAdi
            // 
            this.lblTamAdi.AutoSize = true;
            this.lblTamAdi.Location = new System.Drawing.Point(3, 0);
            this.lblTamAdi.Name = "lblTamAdi";
            this.lblTamAdi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTamAdi.Size = new System.Drawing.Size(38, 20);
            this.lblTamAdi.TabIndex = 0;
            this.lblTamAdi.Text = "label1";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(3, 20);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblKullaniciAdi.Size = new System.Drawing.Size(38, 20);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "label2";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(3, 40);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblSifre.Size = new System.Drawing.Size(38, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "label3";
            // 
            // lblTipi
            // 
            this.lblTipi.AutoSize = true;
            this.lblTipi.Location = new System.Drawing.Point(3, 60);
            this.lblTipi.Name = "lblTipi";
            this.lblTipi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTipi.Size = new System.Drawing.Size(38, 20);
            this.lblTipi.TabIndex = 3;
            this.lblTipi.Text = "label4";
            // 
            // flpLabels
            // 
            this.flpLabels.Controls.Add(this.lblTamAdi);
            this.flpLabels.Controls.Add(this.lblKullaniciAdi);
            this.flpLabels.Controls.Add(this.lblSifre);
            this.flpLabels.Controls.Add(this.lblTipi);
            this.flpLabels.Controls.Add(this.lblYoneticisi);
            this.flpLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLabels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLabels.Location = new System.Drawing.Point(8, 23);
            this.flpLabels.Name = "flpLabels";
            this.flpLabels.Size = new System.Drawing.Size(249, 112);
            this.flpLabels.TabIndex = 0;
            // 
            // lblYoneticisi
            // 
            this.lblYoneticisi.AutoSize = true;
            this.lblYoneticisi.Location = new System.Drawing.Point(3, 80);
            this.lblYoneticisi.Name = "lblYoneticisi";
            this.lblYoneticisi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblYoneticisi.Size = new System.Drawing.Size(38, 20);
            this.lblYoneticisi.TabIndex = 4;
            this.lblYoneticisi.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpLabels);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(8, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(265, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Detay";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(170, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 26);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(89, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 26);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 26);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Yeni Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tam Adı";
            // 
            // txtTamAdi
            // 
            this.txtTamAdi.Location = new System.Drawing.Point(3, 18);
            this.txtTamAdi.Name = "txtTamAdi";
            this.txtTamAdi.Size = new System.Drawing.Size(248, 23);
            this.txtTamAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(3, 62);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(248, 23);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(3, 106);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(248, 23);
            this.txtSifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipi";
            // 
            // cmbTipi
            // 
            this.cmbTipi.DisplayMember = "Name";
            this.cmbTipi.FormattingEnabled = true;
            this.cmbTipi.Location = new System.Drawing.Point(3, 150);
            this.cmbTipi.Name = "cmbTipi";
            this.cmbTipi.Size = new System.Drawing.Size(248, 23);
            this.cmbTipi.TabIndex = 7;
            this.cmbTipi.ValueMember = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yönetici";
            // 
            // cmbYonetici
            // 
            this.cmbYonetici.FormattingEnabled = true;
            this.cmbYonetici.Location = new System.Drawing.Point(3, 194);
            this.cmbYonetici.Name = "cmbYonetici";
            this.cmbYonetici.Size = new System.Drawing.Size(248, 23);
            this.cmbYonetici.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSil);
            this.flowLayoutPanel3.Controls.Add(this.btnKaydet);
            this.flowLayoutPanel3.Controls.Add(this.btnEkle);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(248, 36);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // flpInputPanel
            // 
            this.flpInputPanel.Controls.Add(this.label1);
            this.flpInputPanel.Controls.Add(this.txtTamAdi);
            this.flpInputPanel.Controls.Add(this.label2);
            this.flpInputPanel.Controls.Add(this.txtKullaniciAdi);
            this.flpInputPanel.Controls.Add(this.label3);
            this.flpInputPanel.Controls.Add(this.txtSifre);
            this.flpInputPanel.Controls.Add(this.label4);
            this.flpInputPanel.Controls.Add(this.cmbTipi);
            this.flpInputPanel.Controls.Add(this.label5);
            this.flpInputPanel.Controls.Add(this.cmbYonetici);
            this.flpInputPanel.Controls.Add(this.flowLayoutPanel3);
            this.flpInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpInputPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInputPanel.Location = new System.Drawing.Point(8, 23);
            this.flpInputPanel.Name = "flpInputPanel";
            this.flpInputPanel.Size = new System.Drawing.Size(249, 268);
            this.flpInputPanel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flpInputPanel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(265, 298);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı Ekle/Düzenle/Sil";
            // 
            // mnuExcelAktar
            // 
            this.mnuExcelAktar.Name = "mnuExcelAktar";
            this.mnuExcelAktar.Size = new System.Drawing.Size(132, 22);
            this.mnuExcelAktar.Text = "Excel Aktar";
            this.mnuExcelAktar.Click += new System.EventHandler(this.mnuExcelAktar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // mnuSil
            // 
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.Size = new System.Drawing.Size(132, 22);
            this.mnuSil.Text = "Sil";
            this.mnuSil.Click += new System.EventHandler(this.mnuSil_Click);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.Size = new System.Drawing.Size(132, 22);
            this.mnuKaydet.Text = "Kaydet";
            this.mnuKaydet.Click += new System.EventHandler(this.mnuKaydet_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKaydet,
            this.mnuSil,
            this.toolStripMenuItem1,
            this.mnuExcelAktar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 76);
            // 
            // lstKullanicilar
            // 
            this.lstKullanicilar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKullanicilar.FormattingEnabled = true;
            this.lstKullanicilar.ItemHeight = 15;
            this.lstKullanicilar.Location = new System.Drawing.Point(8, 23);
            this.lstKullanicilar.Name = "lstKullanicilar";
            this.lstKullanicilar.Size = new System.Drawing.Size(467, 410);
            this.lstKullanicilar.TabIndex = 0;
            this.lstKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lstKullanicilar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstKullanicilar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(483, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcılar";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(8, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitContainer1.Size = new System.Drawing.Size(784, 454);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 1;
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKullaniciYonetimi";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Kullanıcı Yönetimi";
            this.Load += new System.EventHandler(this.frmKullaniciYonetimi_Load);
            this.flpLabels.ResumeLayout(false);
            this.flpLabels.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flpInputPanel.ResumeLayout(false);
            this.flpInputPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblTamAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTipi;
        private System.Windows.Forms.FlowLayoutPanel flpLabels;
        private System.Windows.Forms.Label lblYoneticisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYonetici;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flpInputPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem mnuExcelAktar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSil;
        private System.Windows.Forms.ToolStripMenuItem mnuKaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lstKullanicilar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}