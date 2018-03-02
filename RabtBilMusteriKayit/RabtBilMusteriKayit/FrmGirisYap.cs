using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmGirisYap : Form
    {
        SMF SMF = new SMF();

        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KullaniciOlusturGizle();
        }

        private void BttnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(TxtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Boş!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SMF.Baglanti.Open();
                MySqlCommand komutKullaniciVarMi = new MySqlCommand("SELECT * FROM kullanicilar", SMF.Baglanti);
                DataTable dataTable1 = new DataTable();
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(komutKullaniciVarMi);
                dataAdapter1.Fill(dataTable1);

                if (dataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("Kayıtlı Kullanıcı Yok Lütfen Yeni Bir Kullanıcı Oluşturun!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    KullaniciOlusturGoster();
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", SMF.Baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                    DataTable dataTable2 = new DataTable();
                    MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(cmd);
                    dataAdapter2.Fill(dataTable2);

                    if (dataTable2.Rows.Count > 0)
                    {
                        FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                SMF.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void BttnYeniKullaniciOluştur_Click(object sender, EventArgs e)
        {
            string kullaniciEposta = TxtEposta.Text.ToLower();
            string kullaniciSifre = SifreOlustur(12);

            if (String.IsNullOrWhiteSpace(TxtEposta.Text))
            {
                MessageBox.Show("E-posta Boş!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EpostaDogruMu(kullaniciEposta))
            {
                try
                {
                    SMF.Baglanti.Open();
                    MySqlCommand komutKullaniciVarMi = new MySqlCommand("SELECT * FROM kullanicilar", SMF.Baglanti);
                    DataTable dataTable1 = new DataTable();
                    MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(komutKullaniciVarMi);
                    dataAdapter1.Fill(dataTable1);
                    if (dataTable1.Rows.Count > 0)
                    {
                        MessageBox.Show("Kayıtlı Bir Kullanıcı Zaten Var!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        KullaniciOlusturGizle();
                        return;
                    }

                    MySqlCommand komutKullaniciKayit = new MySqlCommand("INSERT INTO kullanicilar (KullaniciAdi,Sifre,EPosta) VALUES (@KullaniciAdi,@Sifre,@EPosta)", SMF.Baglanti); komutKullaniciKayit.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text);
                    komutKullaniciKayit.Parameters.Clear();
                    komutKullaniciKayit.Parameters.AddWithValue("@KullaniciAdi", kullaniciEposta);
                    komutKullaniciKayit.Parameters.AddWithValue("@Sifre", kullaniciSifre);
                    komutKullaniciKayit.Parameters.AddWithValue("@EPosta", kullaniciEposta);
                    komutKullaniciKayit.ExecuteNonQuery();
                    SMF.Baglanti.Close();

                    var eposta = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("rabtbilmail@gmail.com", "SMF-SoftWare"),
                        EnableSsl = true
                    };
                    eposta.Send("rabtbilmail@gmail.com", kullaniciEposta, "Rabt Bil. Müşteri Kayıt - Yeni Kullanıcı Kaydı", "Geçici Kullanıcı Adınız: " + kullaniciEposta + "\nGeçici Şifreniz: " + kullaniciSifre);

                    MessageBox.Show("Kullanıcı Adı Ve Şifre E-posta Adresinize Gönderilmiştir!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KullaniciOlusturGizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata");
                }
            }
            else
            {
                MessageBox.Show("Doğru Bir E-posta Adresi Girin!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string SifreOlustur(int uzunluk)
        {
            const string karakterler = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            while (0 < uzunluk--)
            {
                sb.Append(karakterler[rnd.Next(karakterler.Length)]);
            }
            return sb.ToString();
        }

        private bool EpostaDogruMu(string eposta)
        {
            return Regex.IsMatch(eposta, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public void KullaniciOlusturGoster()
        {
            Width = 355;
            Height = 370;
            TxtEposta.Show();
            BttnYeniKullaniciOluştur.Show();
        }

        public void KullaniciOlusturGizle()
        {
            Width = 355;
            Height = 265;
            TxtEposta.Hide();
            BttnYeniKullaniciOluştur.Hide();
        }

        private void FrmGirisYap_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
}