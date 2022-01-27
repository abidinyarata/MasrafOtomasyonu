
namespace WinForms_MasrafOtomasyonu
{
    partial class frmMasraflar
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.clmTutar = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMasrafTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clmFisNo = new System.Windows.Forms.ColumnHeader();
            this.clmTarih = new System.Windows.Forms.ColumnHeader();
            this.clmMasrafTipi = new System.Windows.Forms.ColumnHeader();
            this.clmSahibi = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmDurumu = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(3, 19);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(585, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // clmTutar
            // 
            this.clmTutar.Text = "Tutar";
            this.clmTutar.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbMasrafTipi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudTutar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFisNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 316);
            this.panel1.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAciklama.Location = new System.Drawing.Point(0, 214);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(291, 59);
            this.txtAciklama.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 188);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label5.Size = new System.Drawing.Size(291, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama";
            // 
            // cmbMasrafTipi
            // 
            this.cmbMasrafTipi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMasrafTipi.FormattingEnabled = true;
            this.cmbMasrafTipi.Location = new System.Drawing.Point(0, 165);
            this.cmbMasrafTipi.Name = "cmbMasrafTipi";
            this.cmbMasrafTipi.Size = new System.Drawing.Size(291, 23);
            this.cmbMasrafTipi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 139);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label4.Size = new System.Drawing.Size(291, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Masraf Tipi";
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTutar.Location = new System.Drawing.Point(0, 116);
            this.nudTutar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(291, 23);
            this.nudTutar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 90);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label3.Size = new System.Drawing.Size(291, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(0, 67);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(291, 23);
            this.dtpTarih.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label2.Size = new System.Drawing.Size(291, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFisNo.Location = new System.Drawing.Point(0, 18);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(291, 23);
            this.txtFisNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiş No";
            // 
            // clmFisNo
            // 
            this.clmFisNo.Text = "Fiş No";
            // 
            // clmTarih
            // 
            this.clmTarih.Text = "Tarih";
            this.clmTarih.Width = 80;
            // 
            // clmMasrafTipi
            // 
            this.clmMasrafTipi.Text = "Masraf Tipi";
            this.clmMasrafTipi.Width = 100;
            // 
            // clmSahibi
            // 
            this.clmSahibi.Text = "Sahibi";
            this.clmSahibi.Width = 160;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSahibi,
            this.clmMasrafTipi,
            this.clmTarih,
            this.clmFisNo,
            this.clmTutar,
            this.clmDurumu});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 350);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmDurumu
            // 
            this.clmDurumu.Text = "Durumu";
            this.clmDurumu.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 397);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masraflar";
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::WinForms_MasrafOtomasyonu.Properties.Resources._2561211_circle_x_icon;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(23, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKaydet.Image = global::WinForms_MasrafOtomasyonu.Properties.Resources.save;
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(23, 22);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::WinForms_MasrafOtomasyonu.Properties.Resources._728898_page_folder_add_plus_file_icon__1_;
            this.btnEkle.Location = new System.Drawing.Point(202, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 28);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEkle);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 360);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKaydet,
            this.btnSil});
            this.toolStrip1.Location = new System.Drawing.Point(3, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(291, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Ekle/Düzenle/Sil";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(892, 397);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 1;
            // 
            // frmMasraflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 397);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMasraflar";
            this.Text = "Masraflar";
            this.Load += new System.EventHandler(this.frmMasraflar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ColumnHeader clmTutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMasrafTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clmFisNo;
        private System.Windows.Forms.ColumnHeader clmTarih;
        private System.Windows.Forms.ColumnHeader clmMasrafTipi;
        private System.Windows.Forms.ColumnHeader clmSahibi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmDurumu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}