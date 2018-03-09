using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Drawing;
using System.Globalization;
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

        private void FrmTeknikServisFormu_Load(object sender, EventArgs e)
        {
            SMF.ConfigDosyasiVarMi();
            SMF.DilKontrolEt();
            DilYenile();
            CmbBoxUrunKodlariDoldur();

            TimerTarihSaat.Enabled = true;
            _takipNo = _rnd.Next(10000, 99999);
            TxtUrunTakipNo.Text = _takipNo.ToString();
            CmbBoxUrunKodlari.SelectedIndex = 2;

            if (Settings.Default.LisansliMi && SMF.KontrolEt(Settings.Default.Eposta, Settings.Default.Lisans))
            {
                TlStrpMenuItemYardimLisansAnahtari.Enabled = false;
            }

            try
            {
                PcTrBoxProfiliDuzenle.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
            }
            catch (Exception)
            {
                PcTrBoxProfiliDuzenle.Image = Resources.varsayilanProfilResmi;
            }
        }

        private void BttnKayitlariGoster_Click(object sender, EventArgs e)
        {
            Hide();
            FrmKayitlariGoster frmKayitlariGoster = new FrmKayitlariGoster();
            frmKayitlariGoster.ShowDialog();
        }

        private void BttnQrKoduOlustur_Click(object sender, EventArgs e)
        {
        }

        private void BttnYeniKayit_Click(object sender, EventArgs e)
        {
            Temizle();
            _takipNo = _rnd.Next(10000, 99999);
            TxtUrunTakipNo.Text = _takipNo.ToString();
        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TxtMusteriAdi.Text) || String.IsNullOrWhiteSpace(TxtFormNo.Text) || MsKdTxtTelefon.Text == @"(   )    -" || String.IsNullOrWhiteSpace(TxtUrunModeli.Text) || String.IsNullOrWhiteSpace(CmbBoxUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtArizaTanimi.Text) || String.IsNullOrWhiteSpace(TxtUrunDurumu.Text) || String.IsNullOrWhiteSpace(TxtUcret.Text) || String.IsNullOrWhiteSpace(TxtAksesuarlar.Text) || String.IsNullOrWhiteSpace(TxtEkBilgiler.Text))
                {
                    MessageBox.Show(Resources.metinKutulariBos, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                kaydet.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                kaydet.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                kaydet.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                kaydet.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToString(CultureInfo.CurrentCulture)));
                SMF.Baglanti.Open();
                kaydet.ExecuteNonQuery();
                SMF.Baglanti.Close();
                MessageBox.Show(Resources.kaydedildi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Hata);
            }
        }

        private void BttnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TxtMusteriAdi.Text) || String.IsNullOrWhiteSpace(TxtFormNo.Text) || MsKdTxtTelefon.Text == @"(   )    -" || String.IsNullOrWhiteSpace(TxtUrunModeli.Text) || String.IsNullOrWhiteSpace(CmbBoxUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtUrunKodlari.Text) || String.IsNullOrWhiteSpace(TxtArizaTanimi.Text) || String.IsNullOrWhiteSpace(TxtUrunDurumu.Text) || String.IsNullOrWhiteSpace(TxtUcret.Text) || String.IsNullOrWhiteSpace(TxtAksesuarlar.Text) || String.IsNullOrWhiteSpace(TxtEkBilgiler.Text))
                {
                    MessageBox.Show(Resources.metinKutulariBos, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MySqlCommand komutGuncelle = new MySqlCommand("UPDATE musteribilgileri SET MusteriAdi=@MusteriAdi,FormNo=@FormNo,Telefon=@Telefon,UrunModeli=@UrunModeli,UrunSeriveImeiKodlari=@UrunSeriveImeiKodlari,UrunKodlari=@UrunKodlari,ArizaTanimi=@ArizaTanimi,UrunDurumu=@UrunDurumu,UrunTakipNo=@UrunTakipNo,Ucret=@Ucret,Aksesuarlar=@Aksesuarlar,EkBilgiler=@EkBilgiler,Tarih=@Tarih WHERE Id=@Id", SMF.Baglanti);
                komutGuncelle.Parameters.AddWithValue("@MusteriAdi", TxtMusteriAdi.Text);
                komutGuncelle.Parameters.AddWithValue("@FormNo", TxtFormNo.Text);
                komutGuncelle.Parameters.AddWithValue("@Telefon", MsKdTxtTelefon.Text);
                komutGuncelle.Parameters.AddWithValue("@UrunModeli", TxtUrunModeli.Text);
                komutGuncelle.Parameters.AddWithValue("@UrunSeriveImeiKodlari", CmbBoxUrunKodlari.Text);
                komutGuncelle.Parameters.AddWithValue("@UrunKodlari", TxtUrunKodlari.Text);
                komutGuncelle.Parameters.AddWithValue("@ArizaTanimi", TxtArizaTanimi.Text);
                komutGuncelle.Parameters.AddWithValue("@UrunDurumu", TxtUrunDurumu.Text);
                komutGuncelle.Parameters.AddWithValue("@UrunTakipNo", TxtUrunTakipNo.Text);
                komutGuncelle.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                komutGuncelle.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                komutGuncelle.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                komutGuncelle.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(TlStripTarihSaat.Text));
                komutGuncelle.Parameters.AddWithValue("@Id", LblMusteriNo.Text);
                SMF.Baglanti.Open();
                komutGuncelle.ExecuteNonQuery();
                SMF.Baglanti.Close();
                MessageBox.Show(Resources.guncellendi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Hata);
            }
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void TlStrpMenuItemAraclarSil_Click(object sender, EventArgs e)
        {
            FrmKayitlariGoster frm = new FrmKayitlariGoster();
            frm.Show();
            Hide();
            MessageBox.Show(Resources.musteriSec, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TlStrpMenuItemYardimLisansAnahtari_Click(object sender, EventArgs e)
        {
            FrmLisans frm = new FrmLisans();
            frm.ShowDialog();
        }

        private void PcTrBoxProfiliDuzenle_Click(object sender, EventArgs e)
        {
            FrmProfil frm = new FrmProfil();
            frm.Show();
            Hide();
        }

        private void BttnYeniKayit_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaBttnYeniKayit;
        }

        private void BttnYeniKayit_MouseLeave(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.varsayilanAciklama;
        }

        private void BttnKaydet_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaBttnKaydet;
        }

        private void BttnTemizle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaBttnTemizle;
        }

        private void BttnKayitlariGoster_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaBttnKayitlariGoster;
        }

        private void BttnGuncelle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaBttnGuncelle;
        }

        private void PcTrBoxProfiliDuzenle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaPcTrBoxProfiliDuzenle;
        }

        private void TlStrpMenuItemAraclarSil_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaTlStrpMenuItemAraclarSil;
        }

        private void TimerTarihSaat_Tick(object sender, EventArgs e)
        {
            TlStripTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        public void Temizle()
        {
            TxtMusteriAdi.Clear();
            TxtFormNo.Clear();
            MsKdTxtTelefon.Clear();
            TxtUrunModeli.Clear();
            CmbBoxUrunKodlari.SelectedIndex = 2;
            TxtUrunKodlari.Clear();
            TxtArizaTanimi.Clear();
            TxtUrunDurumu.Clear();
            TxtUcret.Clear();
            TxtAksesuarlar.Clear();
            TxtEkBilgiler.Clear();
            LblMusteriNo.Text = "";
        }

        private void DilYenile()
        {
            Text = Resources.FrmTeknikServisFormu;
            TlStrpMenuItemAraclar.Text = Resources.TlStrpMenuItemAraclar;
            TlStrpMenuItemAraclarYeniKayit.Text = Resources.TlStrpMenuItemAraclarYeniKayit;
            TlStrpMenuItemAraclarKaydet.Text = Resources.TlStrpMenuItemAraclarKaydet;
            TlStrpMenuItemAraclarTemizle.Text = Resources.TlStrpMenuItemAraclarTemizle;
            TlStrpMenuItemAraclarKayitlariGoster.Text = Resources.TlStrpMenuItemAraclarKayitlariGoster;
            TlStrpMenuItemAraclarGuncelle.Text = Resources.TlStrpMenuItemAraclarGuncelle;
            TlStrpMenuItemAraclarSil.Text = Resources.TlStrpMenuItemAraclarSil;
            TlStrpMenuItemAyarlar.Text = Resources.TlStrpMenuItemAyarlar;
            TlStrpMenuItemAyarlarDil.Text = Resources.TlStrpMenuItemAyarlarDil;
            TlStrpMenuItemDilTurkce.Text = Resources.TlStrpMenuItemDilTurkce;
            TlStrpMenuItemDilIngilizce.Text = Resources.TlStrpMenuItemDilIngilizce;
            TlStrpMenuItemAyarlarTema.Text = Resources.TlStrpMenuItemAyarlarTema;
            TlStrpMenuItemYardım.Text = Resources.TlStrpMenuItemYardim;
            TlStrpMenuItemYardimLisansAnahtari.Text = Resources.TlStrpMenuItemYardimLisansAnahtari;
            TlStrpMenuItemYardimHakkinda.Text = Resources.TlStrpMenuItemYardimHakkinda;
            GrpBoxMusteriBilgileri.Text = Resources.GrpBoxMusteriBilgileri;
            LblMusteriAdi.Text = Resources.LblMusteriAdi;
            LblFormNo.Text = Resources.LblFormNo;
            LblTelefon.Text = Resources.LblTelefon;
            GrpBoxAksesuarlar.Text = Resources.GrpBoxAksesuarlar;
            GrpBoxEkBilgiler.Text = Resources.GrpBoxEkBilgiler;
            GrpBoxUrunBilgileri.Text = Resources.GrpBoxUrunBilgileri;
            LblUrunModeli.Text = Resources.LblUrunModeli;
            LblArizaTanimi.Text = Resources.LblArizaTanimi;
            LblUrunDurumu.Text = Resources.LblUrunDurumu;
            LblUrunTakipNo.Text = Resources.LblUrunTakipNo;
            LblMusteriQrKodu.Text = Resources.LblMusteriQrKodu;
            BttnQrKoduOlustur.Text = Resources.BttnQrKoduOlustur;
            LblUcret.Text = Resources.LblUcret;
            BttnYeniKayit.Text = Resources.TlStrpMenuItemAraclarYeniKayit;
            BttnKaydet.Text = Resources.BttnKaydet;
            BttnTemizle.Text = Resources.BttnTemizle;
            BttnKayitlariGoster.Text = Resources.TlStrpMenuItemAraclarKayitlariGoster;
            BttnGuncelle.Text = Resources.TlStrpMenuItemAraclarGuncelle;
            TlStripAcıklama.Text = Resources.varsayilanAciklama;
            CmbBoxUrunKodlariDoldur();
        }

        public void CmbBoxUrunKodlariDoldur()
        {
            CmbBoxUrunKodlari.Items.Clear();
            CmbBoxUrunKodlari.Items.Add(Resources.CmbBoxUrunKodlariSeriNo);
            CmbBoxUrunKodlari.Items.Add(Resources.CmbBoxUrunKodlariImeiNo);
            CmbBoxUrunKodlari.Items.Add(Resources.CmbBoxUrunKodlariDiger);
            //CmbBoxUrunKodlari.SelectedIndex = 2;
        }

        private void FrmTeknikServisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SMF.HerTurluKapat();
        }
    }
}