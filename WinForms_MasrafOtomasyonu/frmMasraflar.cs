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
    public partial class frmMasraflar : Form
    {
        public frmMasraflar()
        {
            InitializeComponent();
        }

        List<Masraf> masraflar = new List<Masraf>();
        List<string> masrafTipleri = new List<string>();

        private void frmMasraflar_Load(object sender, EventArgs e)
        {
            masrafTipleri = DosyaIslemleri.GetirMasrafTipleri();
            masraflar = DosyaIslemleri.GetirMasraflar();

            Listele();

            cmbMasrafTipi.DataSource = null;
            cmbMasrafTipi.DataSource = masrafTipleri;

            dtpTarih.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTarih.MaxDate = DateTime.Now;
        }

        private void Listele()
        {
            listView1.Items.Clear();

            foreach (Masraf masraf in masraflar)
            {
                ListViewItem listViewItem = new ListViewItem("----");
                listViewItem.SubItems.Add(masraf.MasrafTipi);
                listViewItem.SubItems.Add(masraf.FisBilgisi.Tarih.ToShortDateString());
                listViewItem.SubItems.Add(masraf.FisBilgisi.No);
                listViewItem.SubItems.Add(masraf.FisBilgisi.Tutar.ToString("C2"));
                listViewItem.SubItems.Add(EnumHelper.GetMasrafDurumName(masraf.Durumu));
                listViewItem.Tag = masraf;

                listView1.Items.Add(listViewItem);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis
            {
                No = txtFisNo.Text,
                Tarih = dtpTarih.Value,
                Tutar = nudTutar.Value
            };

            MasrafDurum masrafDurum = (Degiskenler.GirisYapanKullanici.YoneticiId == null) ? MasrafDurum.Onaylandi : MasrafDurum.OnayBekliyor;

            Masraf masraf = new Masraf
            {
                Id = Guid.NewGuid(),
                FisBilgisi = fis,
                Aciklama = txtAciklama.Text,
                Durumu = masrafDurum,
                MasrafTipi = cmbMasrafTipi.SelectedItem.ToString(),
                KullaniciId = Degiskenler.GirisYapanKullanici.Id
            };

            masraflar.Add(masraf);
            Listele();
            MessageBox.Show("Masraf başarılı bir şekilde eklendi");
            DosyaIslemleri.KaydetMasraflar(masraflar);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];

                ListViewItem listViewItem = listView1.Items[selectedIndex];
                Masraf masraf = listViewItem.Tag as Masraf;

                if (masraf != null)
                {
                    if (masraf.Durumu == MasrafDurum.OnayBekliyor)
                    {
                        masraf.FisBilgisi.No = txtFisNo.Text;
                        masraf.Aciklama = txtAciklama.Text;
                        masraf.FisBilgisi.Tutar = nudTutar.Value;
                        masraf.FisBilgisi.Tarih = dtpTarih.Value;
                        masraf.MasrafTipi = cmbMasrafTipi.SelectedItem.ToString();

                        Listele();
                        DosyaIslemleri.KaydetMasraflar(masraflar);
                    }
                    else
                    {
                        MessageBox.Show("Sadece \"Onay Bekleyen\" masraflar güncellenebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];

                ListViewItem listViewItem = listView1.Items[selectedIndex];

                Masraf masraf = listViewItem.Tag as Masraf;

                if (masraf != null)
                {
                    if (masraf.Durumu == MasrafDurum.OnayBekliyor)
                    {
                        DialogResult dialogResult = MessageBox.Show($"{masraf.FisBilgisi.No} fiş numaralı masrafı silmek istediğinize emin misiniz?", "Masraf Sil", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            masraflar.RemoveAt(selectedIndex);
                            Listele();
                            MessageBox.Show($"{masraf.MasrafTipi} masrafı başarılı bir şekilde silindi");
                            DosyaIslemleri.KaydetMasraflar(masraflar);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sadece \"Onay Bekleyen\" masraflar silinebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];

                ListViewItem listViewItem = listView1.Items[selectedIndex];
 
                Masraf masraf = listViewItem.Tag as Masraf;

                if (masraf != null)
                {
                    txtFisNo.Text = masraf.FisBilgisi.No;
                    txtAciklama.Text = masraf.Aciklama;
                    nudTutar.Value = masraf.FisBilgisi.Tutar;
                    dtpTarih.Value = masraf.FisBilgisi.Tarih;
                    cmbMasrafTipi.SelectedItem = masraf.MasrafTipi;
                }
            }
        }
    }
}
