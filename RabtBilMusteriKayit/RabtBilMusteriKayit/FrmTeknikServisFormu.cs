﻿using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmTeknikServisFormu : Form
    {

        private SMF SMF = new SMF();

        private readonly Random _rnd = new Random();
        private int _takipNo;

        public FrmTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void BttnKayitlariGoster_Click(object sender, System.EventArgs e)
        {
            Hide();
            FrmKayitlariGoster frmKayitlariGoster = new FrmKayitlariGoster();
            frmKayitlariGoster.ShowDialog();
        }

        private void FrmTeknikServisFormu_Load(object sender, System.EventArgs e)
        {
            TimerTarihSaat.Enabled = true;
            _takipNo = _rnd.Next(10000, 99999);
            TxtUrunTakipNo.Text = _takipNo.ToString();
            try
            {
                PcTrBoxProfiliDuzenle.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Properties.Resources.varsayilanProfilResmi;
            }
            catch (Exception)
            {
                PcTrBoxProfiliDuzenle.Image = Properties.Resources.varsayilanProfilResmi;
            }
        }

        private void TimerTarihSaat_Tick(object sender, System.EventArgs e)
        {
            TlStripTarihSaat.Text = DateTime.Now.ToString();
        }

        private void BttnQrKoduOlustur_Click(object sender, EventArgs e)
        {
        }

        private void BttnYeniKayit_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            //@URLKodu, şimdilik böyle olsun
            try
            {
                if (String.IsNullOrWhiteSpace(TxtMusteriAdi.Text) || String.IsNullOrWhiteSpace(TxtFormNo.Text) || String.IsNullOrWhiteSpace(MsKdTxtTelefon.Text) || String.IsNullOrWhiteSpace(TxtUrunModeli.Text) || String.IsNullOrWhiteSpace(CmbBoxUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtArizaTanimi.Text) || String.IsNullOrWhiteSpace(TxtUrunDurumu.Text) || String.IsNullOrWhiteSpace(TxtUcret.Text) || String.IsNullOrWhiteSpace(TxtAksesuarlar.Text) || String.IsNullOrWhiteSpace(TxtEkBilgiler.Text))
                {
                    MessageBox.Show("Metin Kutuları Boş!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MySqlCommand kaydet = new MySqlCommand("INSERT INTO musteribilgileri (MusteriAdi,FormNo,Telefon,UrunModeli,UrunSeriveImeiKodlari,UrunKodlari,ArizaTanimi,UrunDurumu,UrunTakipNo,Ucret,Aksesuarlar,EkBilgiler,Tarih) VALUES(@MusteriAdi,@FormNo,@Telefon,@UrunModeli,@UrunSeriveImeiKodlari,@UrunKodlari,@ArizaTanimi,@UrunDurumu,@UrunTakipNo,@Ucret,@Aksesuarlar,@EkBilgiler,@Tarih)", SMF.Baglanti);
                kaydet.Parameters.AddWithValue("@MusteriAdi", TxtMusteriAdi.Text);
                kaydet.Parameters.AddWithValue("@FormNo", TxtFormNo.Text);
                kaydet.Parameters.AddWithValue("@Telefon", MsKdTxtTelefon.Text);
                kaydet.Parameters.AddWithValue("@UrunModeli", TxtUrunModeli.Text);
                kaydet.Parameters.AddWithValue("@UrunSeriveImeiKodlari", CmbBoxUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@UrunKodlari", TxtUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@ArizaTanimi", TxtArizaTanimi.Text);
                kaydet.Parameters.AddWithValue("@UrunDurumu", TxtUrunDurumu.Text);
                kaydet.Parameters.AddWithValue("@UrunTakipNo", _rnd.Next(10000, 99999));
                kaydet.Parameters.AddWithValue("@URLKodu", TxtUrunTakipNo.Text);
                kaydet.Parameters.AddWithValue("@Ucret",TxtUcret.Text);
                kaydet.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                kaydet.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                kaydet.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToString()));
                SMF.Baglanti.Open();
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Oluşturduğunuz Kayıt Kaydedilmiştir.");
                SMF.Baglanti.Close();
                _temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void _temizle()
        {
            _takipNo = _rnd.Next(10000, 99999);
            TxtMusteriAdi.Text = "";
            TxtFormNo.Text = "";
            MsKdTxtTelefon.Text = "";
            TxtUrunModeli.Text = "";
            CmbBoxUrunKodlari.Text = "";
            TxtUrunKodlari.Text = "";
            TxtArizaTanimi.Text = "";
            TxtUrunDurumu.Text = "";
            TxtUrunTakipNo.Text = _takipNo.ToString();
            TxtUcret.Text = "";
            TxtAksesuarlar.Text = "";
            TxtEkBilgiler.Text = "";
            LblMusteriNo.Text = "";
        }

        private void CmbBoxUrunKodlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBoxUrunKodlari.Text == "Seri No")
            {
                TxtUrunKodlari.ReadOnly = false;
            }
            else if (CmbBoxUrunKodlari.Text == "Imei No")
            {
                TxtUrunKodlari.ReadOnly = false;
            }
            else if (CmbBoxUrunKodlari.Text == "Diğer")
            {
                TxtUrunKodlari.ReadOnly = false;
            }
            else if (CmbBoxUrunKodlari.Text == "")
            {
                TxtUrunKodlari.ReadOnly = true;
            }
        }

        private void BttnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TxtMusteriAdi.Text) || String.IsNullOrWhiteSpace(TxtFormNo.Text) || String.IsNullOrWhiteSpace(MsKdTxtTelefon.Text) || String.IsNullOrWhiteSpace(TxtUrunModeli.Text) || String.IsNullOrWhiteSpace(CmbBoxUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtArizaTanimi.Text) || String.IsNullOrWhiteSpace(TxtUrunDurumu.Text) || String.IsNullOrWhiteSpace(TxtUcret.Text) || String.IsNullOrWhiteSpace(TxtAksesuarlar.Text) || String.IsNullOrWhiteSpace(TxtEkBilgiler.Text))
                {
                    MessageBox.Show("Metin Kutuları Boş!", Resources.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MySqlCommand guncelle = new MySqlCommand("UPDATE musteribilgileri SET MusteriAdi=@MusteriAdi,FormNo=@FormNo,Telefon=@Telefon,UrunModeli=@UrunModeli,UrunSeriveImeiKodlari=@UrunSeriveImeiKodlari,UrunKodlari=@UrunKodlari,ArizaTanimi=@ArizaTanimi,UrunDurumu=@UrunDurumu,UrunTakipNo=@UrunTakipNo,Ucret=@Ucret,Aksesuarlar=@Aksesuarlar,EkBilgiler=@EkBilgiler,Tarih=@Tarih WHERE Id=@Id", SMF.Baglanti);
                guncelle.Parameters.AddWithValue("@MusteriAdi", TxtMusteriAdi.Text);
                guncelle.Parameters.AddWithValue("@FormNo", TxtFormNo.Text);
                guncelle.Parameters.AddWithValue("@Telefon", MsKdTxtTelefon.Text);
                guncelle.Parameters.AddWithValue("@UrunModeli", TxtUrunModeli.Text);
                guncelle.Parameters.AddWithValue("@UrunSeriveImeiKodlari", CmbBoxUrunKodlari.Text);
                guncelle.Parameters.AddWithValue("@UrunKodlari", TxtUrunKodlari.Text);
                guncelle.Parameters.AddWithValue("@ArizaTanimi", TxtArizaTanimi.Text);
                guncelle.Parameters.AddWithValue("@UrunDurumu", TxtUrunDurumu.Text);
                guncelle.Parameters.AddWithValue("@UrunTakipNo", TxtUrunTakipNo.Text);
                guncelle.Parameters.AddWithValue("@URLKodu", TxtUrunTakipNo.Text);
                guncelle.Parameters.AddWithValue("@Ucret",TxtUcret.Text);
                guncelle.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                guncelle.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                guncelle.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(TlStripTarihSaat.Text));
                guncelle.Parameters.AddWithValue("@Id",LblMusteriNo.Text);
                SMF.Baglanti.Open();
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Güncellenmiştir.");
                SMF.Baglanti.Close();
                _temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        private void TlStrpMenuItemAraclarSil_Click(object sender, EventArgs e)
        {
            FrmKayitlariGoster frmKayitlariGoster = new FrmKayitlariGoster();
            frmKayitlariGoster.Show();
            Hide();
            MessageBox.Show("Lütfen Müşteri Seçiniz");
        }

        private void PcTrBoxProfiliDuzenle_Click(object sender, EventArgs e)
        {
            FrmProfil frmProfil = new FrmProfil();
            frmProfil.Show();
            Hide();
        }

        private void FrmTeknikServisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BttnYeniKayit_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Yeni bir kayıt oluşturur.";
        }

        private void BttnYeniKayit_MouseLeave(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Açıklama";
        }

        private void BttnKaydet_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Müşterileri veritabanımıza kaydeder.";
        }

        private void BttnTemizle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Metin kutularını temizler.";
        }

        private void BttnKayitlariGoster_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Kayıtlı olan müşterileri gösterir";
        }

        private void BttnGuncelle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "kayıt edilen müşterilerin bilgilerini düzenler.";
        }

        private void PcTrBoxProfiliDuzenle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Profil Resminiz";
        }

        private void TlStrpMenuItemAraclarSil_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Seçili olan kayıdı siler.";
        }
    }
}