using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmKayitlariGoster : Form
    {
        private SMF SMF = new SMF();
        private FrmTeknikServisFormu FrmTeknikServisFormu = new FrmTeknikServisFormu();

        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        public void _verilerigetir()
        {
            SMF.Baglanti.Open();
            MySqlDataAdapter verilerigetir = new MySqlDataAdapter("Select * From musteribilgileri", SMF.Baglanti);
            DataTable dt = new DataTable();
            verilerigetir.Fill(dt);
            DtGridViewKayitlariGoster.DataSource = dt;
            SMF.Baglanti.Close();
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            SMF.DilKontrolEt();
            //DilYenile();

            _verilerigetir();
            TimerTarihSaat.Enabled = true;

            if (Settings.Default.LisansliMi)
            {
                TlStrpMenuItemYardimLisansAnahtari.Enabled = false;
            }
        }

        private void TimerTarihSaat_Tick(object sender, EventArgs e)
        {
            TlStripTarihSaat.Text = System.DateTime.Now.ToString();
        }

        private void BttnSil_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sil = new MySqlCommand("DELETE FROM musteribilgileri WHERE Id=@Id", SMF.Baglanti);
                sil.Parameters.AddWithValue("@Id", Convert.ToInt32(DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString()));
                SMF.Baglanti.Open();
                sil.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Silinmiştir.");
                SMF.Baglanti.Close();
                _verilerigetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtGridViewKayitlariGoster_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Seçtiniz Kayıdı Düzenleniyorsunuz");
            FrmTeknikServisFormu.BttnKaydet.Enabled = false;
            FrmTeknikServisFormu.TlStrpMenuItemAraclarKaydet.Enabled = false;
            FrmTeknikServisFormu.LblMusteriNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString();
            FrmTeknikServisFormu.TxtMusteriAdi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[1].Value.ToString();
            FrmTeknikServisFormu.TxtFormNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[2].Value.ToString();
            FrmTeknikServisFormu.MsKdTxtTelefon.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[3].Value.ToString();
            FrmTeknikServisFormu.TxtUrunModeli.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[4].Value.ToString();
            FrmTeknikServisFormu.CmbBoxUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[5].Value.ToString();
            FrmTeknikServisFormu.TxtUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[6].Value.ToString();
            FrmTeknikServisFormu.TxtArizaTanimi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[7].Value.ToString();
            FrmTeknikServisFormu.TxtUrunDurumu.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[8].Value.ToString();
            FrmTeknikServisFormu.TxtUrunTakipNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            //FrmTeknikServisFormu.URLKODU.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[10].Value.ToString();
            FrmTeknikServisFormu.TxtUcret.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[11].Value.ToString();
            FrmTeknikServisFormu.TxtAksesuarlar.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[12].Value.ToString();
            FrmTeknikServisFormu.TxtEkBilgiler.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[13].Value.ToString();
            FrmTeknikServisFormu.Show();
            Hide();
        }

        private void RadioBttnFormNoyaGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBttnFormNoyaGoreAra.Checked)
            {
                TxtArama.ReadOnly = false;
            }
            else if (RadioBttnMusteriIsmineGoreAra.Checked)
            {
                TxtArama.ReadOnly = false;
            }
            else
            {
                TxtArama.ReadOnly = true;
            }
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            if (RadioBttnFormNoyaGoreAra.Checked)
            {
                TxtArama.ReadOnly = false;
                MySqlDataAdapter arama = new MySqlDataAdapter("SELECT * FROM musteribilgileri WHERE FormNo LIKE @Ara", SMF.Baglanti);
                arama.SelectCommand.Parameters.AddWithValue("@Ara", "%" + TxtArama.Text + "%");
                DataSet dataset = new DataSet();
                SMF.Baglanti.Open();
                arama.Fill(dataset, "musteribilgileri");
                DtGridViewKayitlariGoster.DataSource = dataset.Tables["musteribilgileri"];
                SMF.Baglanti.Close();
            }
            else if (RadioBttnMusteriIsmineGoreAra.Checked)
            {
                TxtArama.ReadOnly = false;
                MySqlDataAdapter arama = new MySqlDataAdapter("SELECT * FROM musteribilgileri WHERE MusteriAdi LIKE @Ara", SMF.Baglanti);
                arama.SelectCommand.Parameters.AddWithValue("@Ara", "%" + TxtArama.Text + "%");
                DataSet dataset = new DataSet();
                SMF.Baglanti.Open();
                arama.Fill(dataset, "musteribilgileri");
                DtGridViewKayitlariGoster.DataSource = dataset.Tables["musteribilgileri"];
                SMF.Baglanti.Close();
            }
            else
            {
                TxtArama.ReadOnly = true;
            }
        }

        private void TlStrpMenuItemAraclarYeniKayit_Click(object sender, EventArgs e)
        {
            FrmTeknikServisFormu.Show();
            Hide();
        }

        private void TlStrpMenuItemAraclarGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiniz Kayıdı Düzenleniyorsunuz");
            FrmTeknikServisFormu.BttnKaydet.Enabled = false;
            FrmTeknikServisFormu.TlStrpMenuItemAraclarKaydet.Enabled = false;
            FrmTeknikServisFormu.LblMusteriNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString();
            FrmTeknikServisFormu.TxtMusteriAdi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[1].Value.ToString();
            FrmTeknikServisFormu.TxtFormNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[2].Value.ToString();
            FrmTeknikServisFormu.MsKdTxtTelefon.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[3].Value.ToString();
            FrmTeknikServisFormu.TxtUrunModeli.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[4].Value.ToString();
            FrmTeknikServisFormu.CmbBoxUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[5].Value.ToString();
            FrmTeknikServisFormu.TxtUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[6].Value.ToString();
            FrmTeknikServisFormu.TxtArizaTanimi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[7].Value.ToString();
            FrmTeknikServisFormu.TxtUrunDurumu.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[8].Value.ToString();
            FrmTeknikServisFormu.TxtUrunTakipNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            //FrmTeknikServisFormu.URLKODU.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[10].Value.ToString();
            FrmTeknikServisFormu.TxtUcret.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[11].Value.ToString();
            FrmTeknikServisFormu.TxtAksesuarlar.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[12].Value.ToString();
            FrmTeknikServisFormu.TxtEkBilgiler.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[13].Value.ToString();
            FrmTeknikServisFormu.Show();
            Hide();
        }

        private void FrmKayitlariGoster_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmTeknikServisFormu.Show();
            Hide();
            //Application.Exit();
        }

        private void BttnYazdir_MouseLeave(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Açıklama";
        }

        private void BttnYazdir_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Seçili olan kayıdı yazdırır.";
        }

        private void BttnSil_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = "Seçili olan kayıdı siler.";
        }

        private void TlStrpMenuItemYardimLisansAnahtari_Click(object sender, EventArgs e)
        {
            FrmLisans frm = new FrmLisans();
            frm.ShowDialog();
        }

        private void DtGridViewKayitlariGoster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Seçtiniz Kayıdı Düzenleniyorsunuz");
            FrmTeknikServisFormu.BttnKaydet.Enabled = false;
            FrmTeknikServisFormu.TlStrpMenuItemAraclarKaydet.Enabled = false;
            FrmTeknikServisFormu.LblMusteriNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString();
            FrmTeknikServisFormu.TxtMusteriAdi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[1].Value.ToString();
            FrmTeknikServisFormu.TxtFormNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[2].Value.ToString();
            FrmTeknikServisFormu.MsKdTxtTelefon.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[3].Value.ToString();
            FrmTeknikServisFormu.TxtUrunModeli.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[4].Value.ToString();
            FrmTeknikServisFormu.CmbBoxUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[5].Value.ToString();
            FrmTeknikServisFormu.TxtUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[6].Value.ToString();
            FrmTeknikServisFormu.TxtArizaTanimi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[7].Value.ToString();
            FrmTeknikServisFormu.TxtUrunDurumu.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[8].Value.ToString();
            FrmTeknikServisFormu.TxtUrunTakipNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            //FrmTeknikServisFormu.URLKODU.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[10].Value.ToString();
            FrmTeknikServisFormu.TxtUcret.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[11].Value.ToString();
            FrmTeknikServisFormu.TxtAksesuarlar.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[12].Value.ToString();
            FrmTeknikServisFormu.TxtEkBilgiler.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[13].Value.ToString();
            FrmTeknikServisFormu.Show();
            Hide();
        }
    }
}