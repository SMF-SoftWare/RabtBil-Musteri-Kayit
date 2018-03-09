using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public class SMF
    {
        public static MySqlConnection Baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb;CharSet=utf8;");

        public static string ProfilResmiYolu = Application.StartupPath + @"\profil\kullanici.smf";
        public static string ProfilKlasoru = Application.StartupPath + @"\profil";
        public static string UygulamaSurum = "v1.0";
        public static string UygulamaAdi = $"RabtBil Müşteri Kayıt {UygulamaSurum}";

        public static bool EpostaDogruMu(string eposta)
        {
            return Regex.IsMatch(eposta, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public void DilDegistir(string dil)
        {
            Resources.Culture = new CultureInfo(dil);
            Settings.Default.Dil = dil;
            Settings.Default.Save();
        }

        public void DilKontrolEt()
        {
            switch (Settings.Default.Dil)
            {
                case "en":
                    Resources.Culture = new CultureInfo("en");
                    break;

                default:
                    Resources.Culture = new CultureInfo("");
                    break;
            }
        }

        public void ConfigDosyasiVarMi()
        {
            try
            {
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            }
            catch (ConfigurationErrorsException ex)
            {
                string filename = ex.Filename;

                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    Settings.Default.Upgrade();
                }
            }
        }

        public void HerTurluKapat()
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                try
                {
                    Application.Exit();
                }
                catch (Exception)
                {
                    Application.Exit();
                }
            }
        }

        public void HerTurluYenidenBaslat()
        {
            try
            {
                Application.Restart();
            }
            catch (Exception)
            {
                try
                {
                    Application.Restart();
                }
                catch (Exception)
                {
                    Application.Restart();
                }
            }
        }

        public static string GetMd5Hash(MD5 MD5, string metin)
        {
            byte[] data = MD5.ComputeHash(Encoding.UTF8.GetBytes(metin));
            StringBuilder sb = new StringBuilder();
            foreach (var i in data)
            {
                sb.Append(i.ToString("x2"));
            }

            return sb.ToString();
        }

        public bool KontrolEt(string eposta, string lisans)
        {
            MD5 MD5 = MD5.Create();
            string x = eposta.ToLower();
            string a = x;
            string b = new string(a.ToCharArray().Reverse().ToArray());
            string A = x.ToUpper();
            string B = new string(A.ToCharArray().Reverse().ToArray());
            string c = GetMd5Hash(MD5, a);

            string aa = GetMd5Hash(MD5, a);
            string bb = GetMd5Hash(MD5, b);
            string AA = GetMd5Hash(MD5, A);
            string BB = GetMd5Hash(MD5, B);
            string cc = GetMd5Hash(MD5, c);

            string aaa = aa.Substring(0, 5);
            string bbb = bb.Substring(0, 5);
            string AAA = AA.Substring(0, 5);
            string BBB = BB.Substring(0, 5);
            string ccc = cc.Substring(0, 5);

            string license = $"{aaa}-{bbb}-{AAA}-{BBB}-{ccc}";
            if (String.Equals(license, lisans, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
}