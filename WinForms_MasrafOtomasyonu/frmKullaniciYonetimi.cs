using Ganss.Excel;
using MFramework.Services.FakeData;
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
    public partial class frmKullaniciYonetimi : Form
    {
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
        }

        List<Kullanici> kullanicilar = new List<Kullanici>();
        List<Kullanici> yoneticiler = new List<Kullanici>();

        private void frmKullaniciYonetimi_Load(object sender, EventArgs e)
        {
            kullanicilar = DosyaIslemleri.KullanicilariGetir();

            YoneticiListesiOlustur();

            foreach (Kullanici kullanici in kullanicilar)
            {
                if (BooleanData.GetBoolean())
                {
                    Kullanici yonetici = CollectionData.GetElement<Kullanici>(yoneticiler);
                    kullanici.YoneticiId = yonetici.Id;
                }
            }

            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = kullanicilar;

            cmbYonetici.DataSource = null;
            cmbYonetici.DataSource = yoneticiler;

            cmbTipi.DataSource = null;
            cmbTipi.DataSource = EnumHelper.GetKullaniciTipiList();
        }

        private void YoneticiListesiOlustur()
        {
            yoneticiler = new List<Kullanici>();

            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.Tipi == KullaniciTipi.yonetici)
                {
                    yoneticiler.Add(kullanici);
                }
            }
        }

        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            KullaniciDetayYazdir();

            if (lstKullanicilar.SelectedIndex > -1)
            {
                Kullanici seciliKullanici = (Kullanici)lstKullanicilar.SelectedItem;
                Kullanici seciliYonetici = null;

                foreach (Kullanici yonetici in yoneticiler)
                {
                    if (yonetici.Id == seciliKullanici.YoneticiId)
                    {
                        seciliYonetici = yonetici;
                        break;
                    }
                }

                txtTamAdi.Text = seciliKullanici.TamAdi;
                txtKullaniciAdi.Text = seciliKullanici.KullaniciAdi;
                txtSifre.Text = seciliKullanici.Sifre;
                cmbTipi.SelectedValue = (int)seciliKullanici.Tipi;
                cmbYonetici.SelectedItem = seciliYonetici;
            }
        }

        private void KullaniciDetayYazdir()
        {
            if (lstKullanicilar.SelectedIndex == -1)
            {
                foreach (Control control in flpLabels.Controls)
                {
                    if (control.GetType() == typeof(Label))
                    {
                        ((Label)control).ResetText();
                    }
                }
            }
            else
            {
                Kullanici kullanici = (Kullanici)lstKullanicilar.SelectedItem;

                lblTamAdi.Text = kullanici.TamAdi;
                lblKullaniciAdi.Text = kullanici.KullaniciAdi;
                lblSifre.Text = kullanici.Sifre;
                lblTipi.Text = EnumHelper.GetKullaniciTipiName(kullanici.Tipi);

                string yoneticiTamAdi = string.Empty;

                foreach (Kullanici yonetici in yoneticiler)
                {
                    if (yonetici.Id == kullanici.YoneticiId)
                    {
                        yoneticiTamAdi = yonetici.ToString();
                        break;
                    }
                }

                lblYoneticisi.Text = yoneticiTamAdi;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici
            {
                Id = Guid.NewGuid(),
                TamAdi = txtTamAdi.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Tipi = (KullaniciTipi)(cmbTipi.SelectedItem as EnumObject).Value,
                YoneticiId = (cmbYonetici.SelectedItem as Kullanici)?.Id
            };

            kullanicilar.Add(kullanici);

            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = kullanicilar;

            MessageBox.Show($"{kullanici.TamAdi} başarılı bir şekilde eklendi");

            if (kullanici.Tipi == KullaniciTipi.yonetici)
            {
                yoneticiler.Add(kullanici);

                cmbYonetici.DataSource = null;
                cmbYonetici.DataSource = yoneticiler;
            }

            Helper.ClearControls(flpInputPanel);
            DosyaIslemleri.KaydetKullanicilar(kullanicilar);
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex > -1)
            {
                Kullanici secilenKullanici = (Kullanici)lstKullanicilar.SelectedItem;
                secilenKullanici.TamAdi = txtTamAdi.Text.Trim();
                secilenKullanici.KullaniciAdi = txtKullaniciAdi.Text.Trim();
                secilenKullanici.Sifre = txtSifre.Text.Trim();
                secilenKullanici.Tipi = (KullaniciTipi)(cmbTipi.SelectedItem as EnumObject).Value;
                secilenKullanici.YoneticiId = (cmbYonetici.SelectedItem as Kullanici)?.Id;

                KullaniciListboxYenileYoneticiListeYenile();
                DosyaIslemleri.KaydetKullanicilar(kullanicilar);
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti");
                Helper.ClearControls(flpInputPanel);
            }
        }

        private void KullaniciListboxYenileYoneticiListeYenile()
        {
            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = kullanicilar;

            YoneticiListesiOlustur();

            cmbYonetici.DataSource = null;
            cmbYonetici.DataSource = yoneticiler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex > -1)
            {
                Kullanici seciliKullanici = (Kullanici)lstKullanicilar.SelectedItem;

                if (seciliKullanici.Tipi == KullaniciTipi.yonetici)
                {
                    foreach (Kullanici kullanici in kullanicilar)
                    {
                        if (kullanici.YoneticiId == seciliKullanici.Id)
                        {
                            kullanici.YoneticiId = Guid.Empty;
                        }
                    }
                }

                DialogResult result = MessageBox.Show($"{seciliKullanici.TamAdi} isimli kullanıcıyı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Yes)
                {
                    kullanicilar.RemoveAt(lstKullanicilar.SelectedIndex);
                    KullaniciListboxYenileYoneticiListeYenile();
                    DosyaIslemleri.KaydetKullanicilar(kullanicilar);
                    MessageBox.Show($"{seciliKullanici.TamAdi} başarılı bir şekilde silindi");
                    Helper.ClearControls(flpInputPanel);
                }
            }
        }

        private void mnuKaydet_Click(object sender, EventArgs e)
        {
            btnKaydet_Click(btnEkle, e);
        }

        private void mnuSil_Click(object sender, EventArgs e)
        {
            btnSil_Click(btnSil, e);
        }

        private void mnuExcelAktar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Title = "Excel Aktar";
            saveFileDialog.FileName = "kullanicilar.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelMapper mapper = new ExcelMapper();
                mapper.Save<Kullanici>(saveFileDialog.FileName, kullanicilar, "Kullanıcılar");

                notifyIcon1.ShowBalloonTip(5000);
            }
        }
    }
}
