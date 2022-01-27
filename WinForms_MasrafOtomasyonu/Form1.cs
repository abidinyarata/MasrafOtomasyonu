using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_MasrafOtomasyonu.Classes;
using WinForms_MasrafOtomasyonu.Enums;

namespace WinForms_MasrafOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuUygulamaHakkinda_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuHarcamaTipleri_Click(object sender, EventArgs e)
        {
            frmMasrafTipiYonetimi frmHarcamaYonetimi = new frmMasrafTipiYonetimi();
            frmHarcamaYonetimi.MdiParent = this;
            frmHarcamaYonetimi.Show();
        }

        private void mnuKullanicilar_Click(object sender, EventArgs e)
        {
            frmKullaniciYonetimi frmKullaniciYonetimi = new frmKullaniciYonetimi();
            frmKullaniciYonetimi.MdiParent = this;
            frmKullaniciYonetimi.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.FormClosed += FrmGiris_FormClosed;
            frmGiris.MdiParent = this;
            frmGiris.Show();
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Degiskenler.GirisYapanKullanici != null)
            {
                menuStrip1.Visible = true;

                mnuYonetim.Visible = false;
                mnuMasrafYonetimi.Visible = false;
                mnuRaporlar.Visible = false;

                switch (Degiskenler.GirisYapanKullanici.Tipi)
                {
                    case KullaniciTipi.admin:
                        mnuYonetim.Visible = true;
                        break;
                    case KullaniciTipi.personel:
                        mnuMasrafYonetimi.Visible = true;
                        break;
                    case KullaniciTipi.yonetici:
                        mnuMasrafYonetimi.Visible = true;
                        mnuRaporlar.Visible = true;
                        break;
                    case KullaniciTipi.muhasebeci:
                        mnuMasrafYonetimi.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void mnuMasraflar_Click(object sender, EventArgs e)
        {
            frmMasraflar frmMasraflar = new frmMasraflar();
            frmMasraflar.MdiParent = this;
            frmMasraflar.Show();
        }
    }
}