using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RabtBilMusteriKayit
{
    public partial class FrmTeknikServisFormu : Form
    {
        private readonly MySqlConnection _baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        
        public FrmTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void BttnKayitlariGoster_Click(object sender, System.EventArgs e)
        {
            FrmKayitlariGoster frmKayitlariGoster = new FrmKayitlariGoster();
            frmKayitlariGoster.Show();
          //  base.Hide();
        }

        private void FrmTeknikServisFormu_Load(object sender, System.EventArgs e)
        {
            TimerTarihSaat.Enabled = true;
        }

        private void TimerTarihSaat_Tick(object sender, System.EventArgs e)
        {
            TlStripTarihSaat.Text = System.DateTime.Now.ToString();
        }

        private void BttnQrKoduOlustur_Click(object sender, EventArgs e)
        {
        }

        private void BttnYeniKayit_Click(object sender, EventArgs e)
        {

        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            //@URLKodu, şimdilik böyle olsun
            try
            {
                MySqlCommand kaydet = new MySqlCommand("INSERT INTO musteribilgileri (MusteriAdi,FormNo,Telefon,UrunModeli,UrunSeriveImeiKodlari,UrunKodlari,ArizaTanimi,UrunDurumu,UrunTakipNo,Ucret,Aksesuarlar,EkBilgiler,Tarih) VALUES(@MusteriAdi,@FormNo,@Telefon,@UrunModeli,@UrunSeriveImeiKodlari,@UrunKodlari,@ArizaTanimi,@UrunDurumu,@UrunTakipNo,@Ucret,@Aksesuarlar,@EkBilgiler,@Tarih)", _baglanti);
                kaydet.Parameters.AddWithValue("@MusteriAdi", TxtMusteriAdi.Text);
                kaydet.Parameters.AddWithValue("@FormNo", TxtFormNo.Text);
                kaydet.Parameters.AddWithValue("@Telefon", TxtTelefon.Text);
                kaydet.Parameters.AddWithValue("@UrunModeli", TxtUrunModeli.Text);
                kaydet.Parameters.AddWithValue("@UrunSeriveImeiKodlari", CmbBoxUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@UrunKodlari", TxtUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@ArizaTanimi", TxtArizaTanimi.Text);
                kaydet.Parameters.AddWithValue("@UrunDurumu", TxtUrunDurumu.Text);
                kaydet.Parameters.AddWithValue("@UrunTakipNo", Convert.ToInt32(TxtUrunTakipNo.Text));
                //kaydet.Parameters.AddWithValue("@URLKodu", TxtUrunTakipNo.Text);
                kaydet.Parameters.AddWithValue("@Ucret", Convert.ToInt32(TxtUcret.Text));
                kaydet.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                kaydet.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                kaydet.Parameters.AddWithValue("@Tarih",DateTime.Parse(System.DateTime.Now.ToString()));
                _baglanti.Open();
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Oluşturduğunuz Kayıt Kaydedilmiştir.");
                _baglanti.Close();
                _temizle();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public void _temizle()
        {
            TxtMusteriAdi.Text = "";
            TxtFormNo.Text = "";
            TxtTelefon.Text = "";
            TxtUrunModeli.Text = "";
            CmbBoxUrunKodlari.Text = "";
            TxtUrunKodlari.Text = "";
            TxtArizaTanimi.Text = "";
            TxtUrunDurumu.Text = "";
            TxtUrunTakipNo.Text = "";
            TxtUcret.Text = "";
            TxtAksesuarlar.Text = "";
            TxtEkBilgiler.Text = "";
        }

        private void CmbBoxUrunKodlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBoxUrunKodlari.Text=="Seri No")
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
                MySqlCommand kaydet = new MySqlCommand("INSERT INTO musteribilgileri (MusteriAdi,FormNo,Telefon,UrunModeli,UrunSeriveImeiKodlari,UrunKodlari,ArizaTanimi,UrunDurumu,UrunTakipNo,Ucret,Aksesuarlar,EkBilgiler,Tarih) VALUES(@MusteriAdi,@FormNo,@Telefon,@UrunModeli,@UrunSeriveImeiKodlari,@UrunKodlari,@ArizaTanimi,@UrunDurumu,@UrunTakipNo,@Ucret,@Aksesuarlar,@EkBilgiler,@Tarih)", _baglanti);
                kaydet.Parameters.AddWithValue("@MusteriAdi", TxtMusteriAdi.Text);
                kaydet.Parameters.AddWithValue("@FormNo", TxtFormNo.Text);
                kaydet.Parameters.AddWithValue("@Telefon", TxtTelefon.Text);
                kaydet.Parameters.AddWithValue("@UrunModeli", TxtUrunModeli.Text);
                kaydet.Parameters.AddWithValue("@UrunSeriveImeiKodlari", CmbBoxUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@UrunKodlari", TxtUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@ArizaTanimi", TxtArizaTanimi.Text);
                kaydet.Parameters.AddWithValue("@UrunDurumu", TxtUrunDurumu.Text);
                kaydet.Parameters.AddWithValue("@UrunTakipNo", Convert.ToInt32(TxtUrunTakipNo.Text));
                //kaydet.Parameters.AddWithValue("@URLKodu", TxtUrunTakipNo.Text);
                kaydet.Parameters.AddWithValue("@Ucret", Convert.ToInt32(TxtUcret.Text));
                kaydet.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                kaydet.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                kaydet.Parameters.AddWithValue("@Tarih", DateTime.Parse(System.DateTime.Now.ToString()));
                _baglanti.Open();
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Oluşturduğunuz Kayıt Kaydedilmiştir.");
                _baglanti.Close();
                _temizle();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}