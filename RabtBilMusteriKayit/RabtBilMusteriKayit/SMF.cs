using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public class SMF
    {
        public MySqlConnection Baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        public string ProfilResmiYolu = Application.StartupPath + @"\profil\kullanici.smf";
        public string ProfilKlasoru = Application.StartupPath + @"\profil";
    }
}