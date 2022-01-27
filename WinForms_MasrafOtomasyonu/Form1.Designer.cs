
namespace WinForms_MasrafOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYonetim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKullanicilar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHarcamaTipleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasrafYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasraflar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBireyselRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonelRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUygulamaHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.mnuYonetim,
            this.mnuMasrafYonetimi,
            this.mnuRaporlar,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(99, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // mnuYonetim
            // 
            this.mnuYonetim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKullanicilar,
            this.mnuHarcamaTipleri});
            this.mnuYonetim.Name = "mnuYonetim";
            this.mnuYonetim.Size = new System.Drawing.Size(63, 20);
            this.mnuYonetim.Text = "Yönetim";
            // 
            // mnuKullanicilar
            // 
            this.mnuKullanicilar.Name = "mnuKullanicilar";
            this.mnuKullanicilar.Size = new System.Drawing.Size(180, 22);
            this.mnuKullanicilar.Text = "Kullanıcılar";
            this.mnuKullanicilar.Click += new System.EventHandler(this.mnuKullanicilar_Click);
            // 
            // mnuHarcamaTipleri
            // 
            this.mnuHarcamaTipleri.Name = "mnuHarcamaTipleri";
            this.mnuHarcamaTipleri.Size = new System.Drawing.Size(180, 22);
            this.mnuHarcamaTipleri.Text = "Harcama Tipleri";
            this.mnuHarcamaTipleri.Click += new System.EventHandler(this.mnuHarcamaTipleri_Click);
            // 
            // mnuMasrafYonetimi
            // 
            this.mnuMasrafYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMasraflar});
            this.mnuMasrafYonetimi.Name = "mnuMasrafYonetimi";
            this.mnuMasrafYonetimi.Size = new System.Drawing.Size(105, 20);
            this.mnuMasrafYonetimi.Text = "Masraf Yönetimi";
            // 
            // mnuMasraflar
            // 
            this.mnuMasraflar.Name = "mnuMasraflar";
            this.mnuMasraflar.Size = new System.Drawing.Size(180, 22);
            this.mnuMasraflar.Text = "Masraf Yönetimi";
            this.mnuMasraflar.Click += new System.EventHandler(this.mnuMasraflar_Click);
            // 
            // mnuRaporlar
            // 
            this.mnuRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBireyselRapor,
            this.mnuPersonelRapor});
            this.mnuRaporlar.Name = "mnuRaporlar";
            this.mnuRaporlar.Size = new System.Drawing.Size(63, 20);
            this.mnuRaporlar.Text = "Raporlar";
            // 
            // mnuBireyselRapor
            // 
            this.mnuBireyselRapor.Name = "mnuBireyselRapor";
            this.mnuBireyselRapor.Size = new System.Drawing.Size(180, 22);
            this.mnuBireyselRapor.Text = "Bireysel Rapor";
            // 
            // mnuPersonelRapor
            // 
            this.mnuPersonelRapor.Name = "mnuPersonelRapor";
            this.mnuPersonelRapor.Size = new System.Drawing.Size(180, 22);
            this.mnuPersonelRapor.Text = "Personel Raporu";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUygulamaHakkinda});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // mnuUygulamaHakkinda
            // 
            this.mnuUygulamaHakkinda.Name = "mnuUygulamaHakkinda";
            this.mnuUygulamaHakkinda.Size = new System.Drawing.Size(181, 22);
            this.mnuUygulamaHakkinda.Text = "Uygulama Hakkında";
            this.mnuUygulamaHakkinda.Click += new System.EventHandler(this.mnuUygulamaHakkinda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Masraf Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuYonetim;
        private System.Windows.Forms.ToolStripMenuItem mnuKullanicilar;
        private System.Windows.Forms.ToolStripMenuItem mnuHarcamaTipleri;
        private System.Windows.Forms.ToolStripMenuItem mnuMasrafYonetimi;
        private System.Windows.Forms.ToolStripMenuItem mnuMasraflar;
        private System.Windows.Forms.ToolStripMenuItem mnuRaporlar;
        private System.Windows.Forms.ToolStripMenuItem mnuBireyselRapor;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonelRapor;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUygulamaHakkinda;
    }
}

