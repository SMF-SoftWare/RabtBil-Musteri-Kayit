using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmTeknikServisFormu : Form
    {
        private readonly MySqlConnection _baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        private Random Rnd = new Random();
        private int takipNo;

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
            takipNo = Rnd.Next(10000, 99999);
            TxtUrunTakipNo.Text = takipNo.ToString();
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
            _temizle();
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
                kaydet.Parameters.AddWithValue("@UrunTakipNo", Convert.ToInt32(takipNo = Rnd.Next(10000, 99999)));
                //kaydet.Parameters.AddWithValue("@URLKodu", TxtUrunTakipNo.Text);
                kaydet.Parameters.AddWithValue("@Ucret", Convert.ToInt32(TxtUcret.Text));
                kaydet.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                kaydet.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                kaydet.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(System.DateTime.Now.ToString()));
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
            takipNo = Rnd.Next(10000, 99999);
            TxtMusteriAdi.Text = "";
            TxtFormNo.Text = "";
            TxtTelefon.Text = "";
            TxtUrunModeli.Text = "";
            CmbBoxUrunKodlari.Text = "";
            TxtUrunKodlari.Text = "";
            TxtArizaTanimi.Text = "";
            TxtUrunDurumu.Text = "";
            TxtUrunTakipNo.Text = takipNo.ToString();
            TxtUcret.Text = "";
            TxtAksesuarlar.Text = "";
            TxtEkBilgiler.Text = "";
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
                MySqlCommand guncelle = new MySqlCommand("UPDATE musteribilgileri SET MusteriAdi=@MusteriAdi,FormNo=@FormNo,Telefon=@Telefon,UrunModeli=@UrunModeli,UrunSeriveImeiKodlari=@UrunSeriveImeiKodlari,UrunKodlari=@UrunKodlari,ArizaTanimi=@ArizaTanimi,UrunDurumu=@UrunDurumu,UrunTakipNo=@UrunTakipNo,Ucret=@Ucret,Aksesuarlar=@Aksesuarlar,EkBilgiler=@EkBilgiler,Tarih=@Tarih WHERE Id=@Id", _baglanti);
                guncelle.Parameters.AddWithValue("@MusteriAdi", TxtMusteriAdi.Text);
                guncelle.Parameters.AddWithValue("@FormNo", TxtFormNo.Text);
                guncelle.Parameters.AddWithValue("@Telefon", TxtTelefon.Text);
                guncelle.Parameters.AddWithValue("@UrunModeli", TxtUrunModeli.Text);
                guncelle.Parameters.AddWithValue("@UrunSeriveImeiKodlari", CmbBoxUrunKodlari.Text);
                guncelle.Parameters.AddWithValue("@UrunKodlari", TxtUrunKodlari.Text);
                guncelle.Parameters.AddWithValue("@ArizaTanimi", TxtArizaTanimi.Text);
                guncelle.Parameters.AddWithValue("@UrunDurumu", TxtUrunDurumu.Text);
                guncelle.Parameters.AddWithValue("@UrunTakipNo", Convert.ToInt32(TxtUrunTakipNo.Text));
                //guncelle.Parameters.AddWithValue("@URLKodu", TxtUrunTakipNo.Text);
                guncelle.Parameters.AddWithValue("@Ucret", Convert.ToInt32(TxtUcret.Text));
                guncelle.Parameters.AddWithValue("@Aksesuarlar", TxtAksesuarlar.Text);
                guncelle.Parameters.AddWithValue("@EkBilgiler", TxtEkBilgiler.Text);
                guncelle.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(TlStripTarihSaat.Text));
                guncelle.Parameters.AddWithValue("@Id", Convert.ToInt32(LblMusteriNo.Text));
                _baglanti.Open();
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Güncellenmiştir.");
                _baglanti.Close();
                _temizle();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            _temizle();
        }
    }
}