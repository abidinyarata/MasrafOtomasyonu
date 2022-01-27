using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_MasrafOtomasyonu.Enums;

namespace WinForms_MasrafOtomasyonu.Classes
{
    public class Masraf
    {
        public Guid Id { get; set; }
        public string MasrafTipi { get; set; }
        public Fis FisBilgisi { get; set; }
        public string Aciklama { get; set; }
        public MasrafDurum Durumu { get; set; }
        public Guid KullaniciId { get; set; }
    }
}