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

namespace WinForms_MasrafOtomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            List<Kullanici> kullanicilar = DosyaIslemleri.KullanicilariGetir();

            string kAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi == kAdi && kullanici.Sifre == sifre)
                {
                    Degiskenler.GirisYapanKullanici = kullanici;
                    break;
                }
            }

            if (Degiskenler.GirisYapanKullanici != null)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı ya da şifre!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
