using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_MasrafOtomasyonu
{
    public partial class frmMasrafTipiYonetimi : Form
    {
        public frmMasrafTipiYonetimi()
        {
            InitializeComponent();
        }

        string path = Application.StartupPath + "\\masraftipleri.json";
        List<string> masrafTipleri = new List<string>();

        private void frmHarcamaYonetimi_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                masrafTipleri = JsonSerializer.Deserialize<List<string>>(json);
                ListBoxaYukle();
            }
        }

        private void ListBoxaYukle()
        {
            lstMasrafTipi.DataSource = null;
            lstMasrafTipi.DataSource = masrafTipleri;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tip = txtMasrafTipi.Text?.Trim();

            if (string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Lütfen bir masraf tipi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (masrafTipleri.Contains(tip))
                {
                    MessageBox.Show($"{tip} isimli masraf zaten mevcuttur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    masrafTipleri.Add(tip);               
                    txtMasrafTipi.Clear();
                    DosyayaYaz();
                    ListBoxaYukle();
                    MessageBox.Show($"{tip} masrafı başarılı bir şekilde eklendi");
                }
            }
        }

        private void DosyayaYaz()
        {
            string json = JsonSerializer.Serialize(masrafTipleri);
            File.WriteAllText(path, json);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstMasrafTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncelleme için bir masraf tipi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string masrafTipi = txtMasrafTipi.Text?.Trim();

            if (string.IsNullOrEmpty(masrafTipi))
            {
                MessageBox.Show("Lütfen bir masraf tipi değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (masrafTipleri.Contains(masrafTipi))
                {
                    MessageBox.Show($"{masrafTipi} isimli masraf tipi zaten mevcuttur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    masrafTipleri[lstMasrafTipi.SelectedIndex] = masrafTipi;
                    txtMasrafTipi.Clear();
                    DosyayaYaz();
                    ListBoxaYukle();
                    MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMasrafTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir masraf tipi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string masrafTipi = masrafTipleri[lstMasrafTipi.SelectedIndex];
            DialogResult dialogResult = MessageBox.Show($"{masrafTipi} tipini silmek istediğinizden emin misiniz?", "Masraf Tipi Sil", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (dialogResult == DialogResult.Yes)
            {
                masrafTipleri.RemoveAt(lstMasrafTipi.SelectedIndex);
                DosyayaYaz();
                ListBoxaYukle();
                MessageBox.Show($"{masrafTipi} masrafı başarılı bir şekilde silindi");
            }
        }

        private void lstMasrafTipi_DoubleClick(object sender, EventArgs e)
        {
            if (lstMasrafTipi.SelectedIndex > -1)
            {
                txtMasrafTipi.Text = lstMasrafTipi.SelectedItem.ToString();
            }
        }
    }
}
