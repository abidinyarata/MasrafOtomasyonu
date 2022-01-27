using System;
using WinForms_MasrafOtomasyonu.Enums;

namespace WinForms_MasrafOtomasyonu.Classes
{
    public class Kullanici
    {
        public Guid Id { get; set; }
        public string TamAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public KullaniciTipi Tipi { get; set; }
        public Guid? YoneticiId { get; set; }

        public override string ToString()
        {
            return $"{TamAdi} - {KullaniciAdi}";
        }
    }
}
