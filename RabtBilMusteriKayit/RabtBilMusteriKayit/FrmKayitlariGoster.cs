using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmKayitlariGoster : Form
    {
        private readonly MySqlConnection _baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        FrmTeknikServisFormu frmTeknikServisFormu = new FrmTeknikServisFormu();

        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        public void _verilerigetir()
        {
            _baglanti.Open();
            MySqlDataAdapter verilerigetir = new MySqlDataAdapter("Select * From musteribilgileri", _baglanti);
            DataTable dt = new DataTable();
            verilerigetir.Fill(dt);
            DtGridViewKayitlariGoster.DataSource = dt;
            _baglanti.Close();
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            _verilerigetir();
            TimerTarihSaat.Enabled = true;
        }

        private void TimerTarihSaat_Tick(object sender, EventArgs e)
        {
            TlStripTarihSaat.Text = System.DateTime.Now.ToString();
        }

        private void BttnSil_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sil = new MySqlCommand("DELETE FROM musteribilgileri WHERE Id=@Id", _baglanti);
                sil.Parameters.AddWithValue("@Id", Convert.ToInt32(DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString()));
                _baglanti.Open();
                sil.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Silinmiştir.");
                _baglanti.Close();
                _verilerigetir();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DtGridViewKayitlariGoster_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Seçtiniz Kayıdı Düzenleniyorsunuz");
            this.frmTeknikServisFormu.BttnKaydet.Enabled = false;
            this.frmTeknikServisFormu.TlStrpMenuItemAraclarKaydet.Enabled = false;
            frmTeknikServisFormu.LblMusteriNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString();
            frmTeknikServisFormu.TxtMusteriAdi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[1].Value.ToString();
            frmTeknikServisFormu.TxtFormNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[2].Value.ToString();
            frmTeknikServisFormu.TxtTelefon.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[3].Value.ToString();
            frmTeknikServisFormu.TxtUrunModeli.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[4].Value.ToString();
            frmTeknikServisFormu.CmbBoxUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[5].Value.ToString();
            frmTeknikServisFormu.TxtUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[6].Value.ToString();
            frmTeknikServisFormu.TxtArizaTanimi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[7].Value.ToString();
            frmTeknikServisFormu.TxtUrunDurumu.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[8].Value.ToString();
            frmTeknikServisFormu.TxtUrunTakipNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            //frmTeknikServisFormu.URLKODU.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            frmTeknikServisFormu.TxtUcret.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[10].Value.ToString();
            frmTeknikServisFormu.TxtAksesuarlar.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[11].Value.ToString();
            frmTeknikServisFormu.TxtEkBilgiler.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[12].Value.ToString();
            frmTeknikServisFormu.Show();
            Hide();
        }
        private void RadioBttnFormNoyaGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBttnFormNoyaGoreAra.Checked == true)
            {
                TxtArama.ReadOnly = false;
            }
            else if (RadioBttnMusteriIsmineGoreAra.Checked == true)
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
            if (RadioBttnFormNoyaGoreAra.Checked == true)
            {
                TxtArama.ReadOnly = false;
                MySqlDataAdapter arama = new MySqlDataAdapter("SELECT * FROM musteribilgileri WHERE FormNo LIKE @Ara", _baglanti);
                arama.SelectCommand.Parameters.AddWithValue("@Ara", "%" + TxtArama.Text + "%");
                DataSet dataset = new DataSet();
                _baglanti.Open();
                arama.Fill(dataset, "musteribilgileri");
                DtGridViewKayitlariGoster.DataSource = dataset.Tables["musteribilgileri"];
                _baglanti.Close();
            }
            else if (RadioBttnMusteriIsmineGoreAra.Checked == true)
            {
                TxtArama.ReadOnly = false;
                MySqlDataAdapter arama = new MySqlDataAdapter("SELECT * FROM musteribilgileri WHERE MusteriAdi LIKE @Ara", _baglanti);
                arama.SelectCommand.Parameters.AddWithValue("@Ara", "%" + TxtArama.Text + "%");
                DataSet dataset = new DataSet();
                _baglanti.Open();
                arama.Fill(dataset, "musteribilgileri");
                DtGridViewKayitlariGoster.DataSource = dataset.Tables["musteribilgileri"];
                _baglanti.Close();
            }
            else
            {
                TxtArama.ReadOnly = true;
            }
        }

        private void TlStrpMenuItemAraclarYeniKayit_Click(object sender, EventArgs e)
        {
            frmTeknikServisFormu.Show();
        }

        private void TlStrpMenuItemAraclarGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiniz Kayıdı Düzenleniyorsunuz");
            this.frmTeknikServisFormu.BttnKaydet.Enabled = false;
            this.frmTeknikServisFormu.TlStrpMenuItemAraclarKaydet.Enabled = false;
            frmTeknikServisFormu.LblMusteriNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[0].Value.ToString();
            frmTeknikServisFormu.TxtMusteriAdi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[1].Value.ToString();
            frmTeknikServisFormu.TxtFormNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[2].Value.ToString();
            frmTeknikServisFormu.TxtTelefon.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[3].Value.ToString();
            frmTeknikServisFormu.TxtUrunModeli.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[4].Value.ToString();
            frmTeknikServisFormu.CmbBoxUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[5].Value.ToString();
            frmTeknikServisFormu.TxtUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[6].Value.ToString();
            frmTeknikServisFormu.TxtArizaTanimi.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[7].Value.ToString();
            frmTeknikServisFormu.TxtUrunDurumu.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[8].Value.ToString();
            frmTeknikServisFormu.TxtUrunTakipNo.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            //frmTeknikServisFormu.URLKODU.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[9].Value.ToString();
            frmTeknikServisFormu.TxtUcret.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[10].Value.ToString();
            frmTeknikServisFormu.TxtAksesuarlar.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[11].Value.ToString();
            frmTeknikServisFormu.TxtEkBilgiler.Text = DtGridViewKayitlariGoster.CurrentRow.Cells[12].Value.ToString();
            frmTeknikServisFormu.Show();
            Hide();
        }
    }
}