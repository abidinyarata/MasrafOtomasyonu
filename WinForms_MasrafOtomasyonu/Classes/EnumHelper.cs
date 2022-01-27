using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_MasrafOtomasyonu.Enums;

namespace WinForms_MasrafOtomasyonu.Classes
{
    public static class EnumHelper
    {
        public static string GetKullaniciTipiName(KullaniciTipi kullaniciTipi)
        {
            string result = string.Empty;

            switch (kullaniciTipi)
            {
                case KullaniciTipi.admin:
                    result = "Admin";
                    break;
                case KullaniciTipi.personel:
                    result = "Personel";
                    break;
                case KullaniciTipi.yonetici:
                    result = "Yönetici";
                    break;
                case KullaniciTipi.muhasebeci:
                    result = "Muhasebeci";
                    break;
                default:
                    break;
            }

            return result;
        }

        public static List<EnumObject> GetKullaniciTipiList()
        {
            List<EnumObject> result = new List<EnumObject>();

            foreach (string enumName in Enum.GetNames(typeof(KullaniciTipi)))
            {
                KullaniciTipi tip = Enum.Parse<KullaniciTipi>(enumName);

                result.Add(new EnumObject
                {
                    Name = GetKullaniciTipiName(tip),
                    Value = (int)tip
                });                
            }

            return result;
        }

        public static string GetMasrafDurumName(MasrafDurum durum)
        {
            string result = string.Empty;

            switch (durum)
            {
                case MasrafDurum.OnayBekliyor:
                    result = "Onay Bekliyor";
                    break;
                case MasrafDurum.Onaylandi:
                    result = "Onaylandı";
                    break;
                case MasrafDurum.Reddedildi:
                    result = "Reddedildi";
                    break;
                case MasrafDurum.Odendi:
                    result = "Ödendi";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
