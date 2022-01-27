using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_MasrafOtomasyonu.Classes
{
    public static class DosyaIslemleri
    {
        private static string pathKullanicilar = Application.StartupPath + "\\kullanicilar.json";
        private static string pathMasraflar = Application.StartupPath + "\\masraflar.json";
        private static string pathMasrafTipleri = Application.StartupPath + "\\masraftipleri.json";
        private static JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static List<Kullanici> KullanicilariGetir()
        {
            if (File.Exists(pathKullanicilar))
            {
                string json = File.ReadAllText(pathKullanicilar);
                return JsonSerializer.Deserialize<List<Kullanici>>(json, options);
            }

            return new List<Kullanici>();
        }

        public static void KaydetKullanicilar(List<Kullanici> kullanicilar)
        {
            string json = JsonSerializer.Serialize<List<Kullanici>>(kullanicilar, options);
            File.WriteAllText(pathKullanicilar, json);
        }

        public static List<string> GetirMasrafTipleri()
        {
            if (File.Exists(pathMasrafTipleri))
            {
                string json = File.ReadAllText(pathMasrafTipleri);
                return JsonSerializer.Deserialize<List<string>>(json, options);
            }

            return new List<string>();
        }

        public static void KaydetMasrafTipleri(List<string> masrafTipleri)
        {
            string json = JsonSerializer.Serialize<List<string>>(masrafTipleri, options);
            File.WriteAllText(pathMasrafTipleri, json);
        }

        public static List<Masraf> GetirMasraflar()
        {
            if (File.Exists(pathMasraflar))
            {
                string json = File.ReadAllText(pathMasraflar);
                return JsonSerializer.Deserialize<List<Masraf>>(json, options);
            }

            return new List<Masraf>();
        }

        public static void KaydetMasraflar(List<Masraf> masraflar)
        {
            string json = JsonSerializer.Serialize<List<Masraf>>(masraflar, options);
            File.WriteAllText(pathMasraflar, json);
        }
    }
}
