using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public class SMF
    {
        public MySqlConnection Baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        public string ProfilResmiYolu = Application.StartupPath + @"\profil\kullanici.smf";
        public string ProfilKlasoru = Application.StartupPath + @"\profil";

        public static bool EpostaDogruMu(string eposta)
        {
            return Regex.IsMatch(eposta, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private static string GetMd5Hash(MD5 MD5, string metin)
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