using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmProfil : Form
    {
        private SMF SMF = new SMF();

        public FrmProfil()
        {
            InitializeComponent();
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            SMF.DilKontrolEt();
            //DilYenile();

            if (Settings.Default.LisansliMi)
            {
                TlStrpMenuItemYardimLisansAnahtari.Enabled = false;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kullanicilar where Id=1", SMF.Baglanti);
                SMF.Baglanti.Open();
                MySqlDataReader dataReader1 = cmd.ExecuteReader();
                if (dataReader1.Read())
                {
                    TxtKullaniciAdiniz.Text = dataReader1["KullaniciAdi"].ToString();
                    TxtAdiniz.Text = dataReader1["Adi"].ToString();
                    TxtSoyadiniz.Text = dataReader1["Soyadi"].ToString();
                    TxtEpostaniz.Text = dataReader1["EPosta"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                PcTrBoxProfiliDuzenle.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
            }
            catch (Exception)
            {
                PcTrBoxProfiliDuzenle.Image = Resources.varsayilanProfilResmi;
            }
            SMF.Baglanti.Close();
        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtKullaniciAdiniz.Text))
            {
                MessageBox.Show("Kullanıcı adı kısmı boş olmamalıdır!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(TxtEpostaniz.Text) || !SMF.EpostaDogruMu(TxtEpostaniz.Text))
            {
                MessageBox.Show("Doğru bir e-posta adresi girin!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtSifreniz.Text != TxtSifreniziOnaylayın.Text)
            {
                MessageBox.Show("Şifreler aynı değil!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(TxtSifreniz.Text) || String.IsNullOrWhiteSpace(TxtSifreniziOnaylayın.Text))
            {
                try
                {
                    MySqlCommand guncelle = new MySqlCommand("UPDATE kullanicilar SET KullaniciAdi=@KullaniciAdi,Adi=@Adi,Soyadi=@Soyadi,EPosta=@EPosta WHERE Id=1", SMF.Baglanti);
                    guncelle.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdiniz.Text);
                    guncelle.Parameters.AddWithValue("@Adi", TxtAdiniz.Text);
                    guncelle.Parameters.AddWithValue("@Soyadi", TxtSoyadiniz.Text);
                    guncelle.Parameters.AddWithValue("@EPosta", TxtEpostaniz.Text);
                    SMF.Baglanti.Open();
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız Güncellenmiştir.");
                    SMF.Baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata");
                }
                return;
            }

            if (TxtSifreniz.Text == TxtSifreniziOnaylayın.Text)
            {
                try
                {
                    MySqlCommand guncelle = new MySqlCommand("UPDATE kullanicilar SET KullaniciAdi=@KullaniciAdi,Adi=@Adi,Soyadi=@Soyadi,EPosta=@EPosta,Sifre=@Sifre WHERE Id=1", SMF.Baglanti);
                    guncelle.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdiniz.Text);
                    guncelle.Parameters.AddWithValue("@Adi", TxtAdiniz.Text);
                    guncelle.Parameters.AddWithValue("@Soyadi", TxtSoyadiniz.Text);
                    guncelle.Parameters.AddWithValue("@EPosta", TxtEpostaniz.Text);
                    guncelle.Parameters.AddWithValue("@Sifre", TxtSifreniz.Text);
                    SMF.Baglanti.Open();
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız Güncellenmiştir.");
                    SMF.Baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata");
                }
            }
        }

        private void PcTrBoxProfiliDuzenle_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimSec = new OpenFileDialog();
            resimSec.Title = "Profil resmini seçin";
            resimSec.Filter = "Resim Dosyaları(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg|SMF Format(*.smf)|*.smf";
            if (resimSec.ShowDialog() == DialogResult.OK)
            {
                string kaynakResimYolu = resimSec.FileName;
                if (!Directory.Exists(SMF.ProfilKlasoru))
                {
                    Directory.CreateDirectory(SMF.ProfilKlasoru);
                }
                PcTrBoxProfiliDuzenle.Image?.Dispose();
                FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
                frm.PcTrBoxProfiliDuzenle.Image?.Dispose();
                try
                {
                    PcTrBoxProfiliDuzenle.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
                    File.Copy(kaynakResimYolu, SMF.ProfilResmiYolu, true);
                }
                catch (Exception)
                {
                    PcTrBoxProfiliDuzenle.Image = Resources.varsayilanProfilResmi;
                }
                PcTrBoxProfiliDuzenle.Image = Image.FromFile(kaynakResimYolu);
            }
        }

        private void FrmProfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TlStrpMenuItemAraclarGucluSifreOlustur_Click(object sender, EventArgs e)
        {
            FrmGucluSifreOlustur frm = new FrmGucluSifreOlustur();
            frm.ShowDialog();
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            TxtKullaniciAdiniz.Text = "";
            TxtSifreniz.Text = "";
            TxtSifreniziOnaylayın.Text = "";
            TxtAdiniz.Text = "";
            TxtSoyadiniz.Text = "";
            TxtEpostaniz.Text = "";
        }

        private void BttnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
            frm.Show();
            Hide();
        }

        private void TlStrpMenuItemYardimLisansAnahtari_Click(object sender, EventArgs e)
        {
            FrmLisans frm = new FrmLisans();
            frm.ShowDialog();
        }

        private void TlStrpMenuItemDilTurkce_Click(object sender, EventArgs e)
        {
            SMF.DilDegistir("tr");
            //DilYenile();
        }

        private void TlStrpMenuItemDilIngilizce_Click(object sender, EventArgs e)
        {
            SMF.DilDegistir("en");
            //DilYenile();
        }
    }
}