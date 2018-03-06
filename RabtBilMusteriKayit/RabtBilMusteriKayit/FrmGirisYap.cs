using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmGirisYap : Form
    {
        private readonly SMF SMF = new SMF();

        private bool _sifremiUnuttumTiklandiMi = true;

        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.LisansliMi)
            {
                TlStrpMenuItemYardimLisansAnahtari.Enabled = false;
            }
            else
            {
                MessageBox.Show(Resources.denemeSurumu, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SMF.DilKontrolEt();
            DilYenile();
            KullaniciOlusturGizle();
        }

        private void BttnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(TxtSifre.Text))
            {
                MessageBox.Show(Resources.kullaniciAdiveSifreBos, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show(Resources.kayitliKullaniciYok, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BttnYeniKullaniciOluştur.Text = Resources.BttnYeniKullaniciOluştur;
                    _sifremiUnuttumTiklandiMi = false;
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
                        MessageBox.Show(Resources.kullaniciAdiveSifreYanlis, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                SMF.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Hata);
            }
        }

        private void BttnYeniKullaniciOluştur_Click(object sender, EventArgs e)
        {
            string kullaniciEposta = TxtEposta.Text.ToLower();
            string kullaniciSifre = SifreOlustur(12);

            if (BttnYeniKullaniciOluştur.Text == Resources.BttnYeniKullaniciOluştur)
            {
                if (String.IsNullOrWhiteSpace(TxtEposta.Text))
                {
                    MessageBox.Show(Resources.epostaBos, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (SMF.EpostaDogruMu(kullaniciEposta))
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
                            MessageBox.Show(Resources.kayitliKullaniciVar, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            KullaniciOlusturGizle();
                            SMF.Baglanti.Close();
                            return;
                        }

                        SMF.Baglanti.Close();
                        SMF.Baglanti.Open();
                        MySqlCommand komutKullaniciKayit = new MySqlCommand("INSERT INTO kullanicilar (KullaniciAdi,Sifre,EPosta) VALUES (@KullaniciAdi,@Sifre,@EPosta)", SMF.Baglanti);
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
                        eposta.Send("rabtbilmail@gmail.com", kullaniciEposta, SMF.UygulamaAdi + " - " + Resources.epostaYeniKullaniciKaydi, Resources.epostaGeciciKullaniciAdi + " " + kullaniciEposta + "\n" + Resources.epostaGeciciSifre + " " + kullaniciSifre);

                        MessageBox.Show(Resources.geciciKullaniciAdiSifreGonderildi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KullaniciOlusturGizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Resources.Hata);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.dogruBirEpostaGirin, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (BttnYeniKullaniciOluştur.Text == Resources.BttnYeniKullaniciOluştur2)
            {
                if (String.IsNullOrWhiteSpace(TxtEposta.Text))
                {
                    MessageBox.Show(Resources.epostaBos, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    if (SMF.EpostaDogruMu(kullaniciEposta))
                    {
                        SMF.Baglanti.Open();
                        MySqlCommand komutEpostaVarMi = new MySqlCommand("SELECT * FROM kullanicilar WHERE EPosta=@EPosta AND ID=1", SMF.Baglanti);
                        komutEpostaVarMi.Parameters.AddWithValue("@EPosta", kullaniciEposta);
                        DataTable dataTable3 = new DataTable();
                        MySqlDataAdapter dataAdapter3 = new MySqlDataAdapter(komutEpostaVarMi);
                        dataAdapter3.Fill(dataTable3);
                        if (dataTable3.Rows.Count != 1)
                        {
                            MessageBox.Show(Resources.epostaKayitliDegil, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            KullaniciOlusturGizle();
                            SMF.Baglanti.Close();
                            return;
                        }

                        SMF.Baglanti.Close();
                        SMF.Baglanti.Open();
                        MySqlCommand komutKullaniciKayit = new MySqlCommand("UPDATE kullanicilar SET Sifre=@Sifre", SMF.Baglanti);
                        komutKullaniciKayit.Parameters.Clear();
                        komutKullaniciKayit.Parameters.AddWithValue("@Sifre", kullaniciSifre);
                        komutKullaniciKayit.ExecuteNonQuery();
                        SMF.Baglanti.Close();

                        var eposta = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("rabtbilmail@gmail.com", "SMF-SoftWare"),
                            EnableSsl = true
                        };
                        eposta.Send("rabtbilmail@gmail.com", kullaniciEposta, SMF.UygulamaAdi + " - " + Resources.epostaSifremiUnuttum, Resources.epostaGeciciSifre + " " + kullaniciSifre);

                        MessageBox.Show(Resources.geciciSifreGonderildi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KullaniciOlusturGizle();
                    }
                    else
                    {
                        MessageBox.Show(Resources.dogruBirEpostaGirin, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Hata);
                }
            }
        }

        private void LinkLblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_sifremiUnuttumTiklandiMi)
            {
                BttnYeniKullaniciOluştur.Text = Resources.BttnYeniKullaniciOluştur2;
                KullaniciOlusturGoster();
                _sifremiUnuttumTiklandiMi = false;
            }
            else
            {
                BttnYeniKullaniciOluştur.Text = Resources.BttnYeniKullaniciOluştur;
                KullaniciOlusturGizle();
                _sifremiUnuttumTiklandiMi = true;
            }
        }

        private void TlStrpMenuItemYardimLisansAnahtari_Click(object sender, EventArgs e)
        {
            FrmLisans frm = new FrmLisans();
            frm.ShowDialog();
        }

        private void TlStrpMenuItemDilTurkce_Click(object sender, EventArgs e)
        {
            SMF.DilDegistir("tr");
            DilYenile();
        }

        private void TlStrpMenuItemDilIngilizce_Click(object sender, EventArgs e)
        {
            SMF.DilDegistir("en");
            DilYenile();
        }

        private void FrmGirisYap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        public void DilYenile()
        {
            Text = Resources.FrmGirisYapBaslik;
            BttnGirisYap.Text = Resources.BttnGirisYap;
            lblKullaniciAdi.Text = Resources.lblKullaniciAdi;
            TlStrpMenuItemAyarlar.Text = Resources.TlStrpMenuItemAyarlar;
            TlStrpMenuItemAyarlarDil.Text = Resources.TlStrpMenuItemAyarlarDil;
            TlStrpMenuItemDilTurkce.Text = Resources.TlStrpMenuItemDilTurkce;
            TlStrpMenuItemDilIngilizce.Text = Resources.TlStrpMenuItemDilIngilizce;
            TlStrpMenuItemAyarlarTema.Text = Resources.TlStrpMenuItemAyarlarTema;
            TlStrpMenuItemYardım.Text = Resources.TlStrpMenuItemYardim;
            TlStrpMenuItemYardimLisansAnahtari.Text = Resources.TlStrpMenuItemYardimLisansAnahtari;
            TlStrpMenuItemYardimHakkinda.Text = Resources.TlStrpMenuItemYardimHakkinda;
            LblSifre.Text = Resources.LblSifre;
            LinkLblSifremiUnuttum.Text = Resources.LinkLblSifremiUnuttum;
            BttnYeniKullaniciOluştur.Text = Resources.BttnYeniKullaniciOluştur;
            LblEposta.Text = Resources.LblEposta;
        }
    }
}