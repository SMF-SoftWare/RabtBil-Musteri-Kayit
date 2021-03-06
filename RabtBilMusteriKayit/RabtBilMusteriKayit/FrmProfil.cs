﻿using MySql.Data.MySqlClient;
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
        private bool _gozeTiklandiMi = true;
        FrmHakkinda _frmHakkinda = new FrmHakkinda();
        public FrmProfil()
        {
            InitializeComponent();
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            SMF.ConfigDosyasiVarMi();
            SMF.DilKontrolEt();
            DilYenile();

            if (Settings.Default.LisansliMi && SMF.KontrolEt(Settings.Default.Eposta, Settings.Default.Lisans))
            {
                TlStrpMenuItemYardimLisansAnahtari.Enabled = false;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kullanicilar WHERE Id=1", SMF.Baglanti);
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
                MessageBox.Show(ex.Message, Resources.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(Resources.kullaniciAdiBosOlamaz, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(TxtEpostaniz.Text) || !SMF.EpostaDogruMu(TxtEpostaniz.Text))
            {
                MessageBox.Show(Resources.dogruEpostaGir, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtSifreniz.Text != TxtSifreniziOnaylayın.Text)
            {
                MessageBox.Show(Resources.sifreAyniDegil, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show(Resources.profilBasariylaGuncellendi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SMF.Baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Hata);
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
                    MessageBox.Show(Resources.profilBasariylaGuncellendi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SMF.Baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Hata);
                }
            }
        }

        private void PcTrBoxProfiliDuzenle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog resimSec = new OpenFileDialog())
            {
                resimSec.Title = Resources.resimSecTitle;
                resimSec.Filter = Resources.resimSecFilter;
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
        }

        private void TlStrpMenuItemAraclarGucluSifreOlustur_Click(object sender, EventArgs e)
        {
            FrmGucluSifreOlustur frm = new FrmGucluSifreOlustur();
            frm.ShowDialog();
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            TxtKullaniciAdiniz.Clear();
            TxtSifreniz.Clear();
            TxtSifreniziOnaylayın.Clear();
            TxtAdiniz.Clear();
            TxtSoyadiniz.Clear();
            TxtEpostaniz.Clear();
        }

        private void BttnAnaSayfa_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
            frm.Show();
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

        private void DilYenile()
        {
            Text = Resources.FrmProfil;
            LblKullaniciAdiniz.Text = Resources.LblKullaniciAdiniz;
            LblSifreniz.Text = Resources.LblSifreniz;
            LblSifreniziOnaylayın.Text = Resources.LblSifreniziOnaylayın;
            LblAdiniz.Text = Resources.LblAdiniz;
            LblSoyadiniz.Text = Resources.LblSoyadiniz;
            LblEpostaniz.Text = Resources.LblEpostaniz;
            BttnKaydet.Text = Resources.BttnKaydet;
            BttnTemizle.Text = Resources.BttnTemizle;
            BttnAnaEkran.Text = Resources.BttnAnaPencere;
            TlStrpMenuItemAraclar.Text = Resources.TlStrpMenuItemAraclar;
            TlStrpMenuItemAraclarGucluSifreOlustur.Text = Resources.TlStrpMenuItemAraclarGucluSifreOlustur;
            TlStrpMenuItemAyarlar.Text = Resources.TlStrpMenuItemAyarlar;
            TlStrpMenuItemAyarlarDil.Text = Resources.TlStrpMenuItemAyarlarDil;
            TlStrpMenuItemDilTurkce.Text = Resources.TlStrpMenuItemDilTurkce;
            TlStrpMenuItemDilIngilizce.Text = Resources.TlStrpMenuItemDilIngilizce;
            TlStrpMenuItemAyarlarTema.Text = Resources.TlStrpMenuItemAyarlarTema;
            TlStrpMenuItemYardım.Text = Resources.TlStrpMenuItemYardim;
            TlStrpMenuItemYardimLisansAnahtari.Text = Resources.TlStrpMenuItemYardimLisansAnahtari;
            TlStrpMenuItemYardimHakkinda.Text = Resources.TlStrpMenuItemYardimHakkinda;
        }

        private void FrmProfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
            frm.Show();
            Dispose();
        }

        private void PcTrBoxEye_Click(object sender, EventArgs e)
        {
            if (_gozeTiklandiMi)
            {
                PcTrBoxEye.Image = Resources.eye_off;
                TxtSifreniz.UseSystemPasswordChar = false;
                TxtSifreniziOnaylayın.UseSystemPasswordChar = false;
                _gozeTiklandiMi = false;
            }
            else
            {
                PcTrBoxEye.Image = Resources.eye;
                TxtSifreniz.UseSystemPasswordChar = true;
                TxtSifreniziOnaylayın.UseSystemPasswordChar = true;
                _gozeTiklandiMi = true;
            }
        }

        private void TlStrpMenuItemYardimHakkinda_Click(object sender, EventArgs e)
        {       
            _frmHakkinda.ShowDialog();
        }
    }
}