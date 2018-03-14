using MySql.Data.MySqlClient;
using RabtBilMusteriKayit.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmKayitlariGoster : Form
    {
        private SMF SMF = new SMF();
        private readonly FrmTeknikServisFormu _frm = new FrmTeknikServisFormu();

        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            SMF.ConfigDosyasiVarMi();
            SMF.DilKontrolEt();
            DilYenile();

            VerileriGetir();
            TimerTarihSaat.Enabled = true;

            if (Settings.Default.LisansliMi && SMF.KontrolEt(Settings.Default.Eposta, Settings.Default.Lisans))
            {
                TlStrpMenuItemYardimLisansAnahtari.Enabled = false;
            }
        }

        private void BttnSil_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sil = new MySqlCommand("DELETE FROM musteribilgileri WHERE Id=@Id", SMF.Baglanti);
                sil.Parameters.AddWithValue("@Id", Convert.ToInt32(DtGridViewKayitlariGoster.CurrentRow?.Cells[0].Value.ToString()));
                SMF.Baglanti.Open();
                sil.ExecuteNonQuery();
                MessageBox.Show(Resources.secilenKayitSilindi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SMF.Baglanti.Close();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Hata);
            }
        }

        private void TlStrpMenuItemYardimLisansAnahtari_Click(object sender, EventArgs e)
        {
            FrmLisans frm = new FrmLisans();
            frm.ShowDialog();
        }

        private void TlStrpMenuItemAraclarYeniKayit_Click(object sender, EventArgs e)
        {
            _frm.Show();
            Hide();
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

        private void TlStrpMenuItemYardimHakkinda_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaHakkinda;
        }

        private void TlStrpMenuItemYardimLisansAnahtari_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaLisansAnahtari;
        }

        private void TlStrpMenuItemAyarlarDil_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaDil;
        }

        private void TlStrpMenuItemAyarlarTema_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaTema;
        }

        private void RadioBttnFormNoyaGoreAra_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.RadioBttnFormNoyaGoreAra;
        }

        private void RadioBttnMusteriIsmineGoreAra_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.RadioBttnMusteriIsmineGoreAra;
        }

        private void TlStrpMenuItemAraclarSil_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaSil;
        }

        private void TlStrpMenuItemAraclarGuncelle_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaGuncelle;
        }

        private void TlStrpMenuItemAraclarYeniKayit_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaYeniKayit;
        }

        private void BttnSil_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaSil;
        }

        private void BttnYazdir_MouseHover(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.aciklamaYazdir;
        }

        private void TlStrpMenuItemAraclarGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void DtGridViewKayitlariGoster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guncelle();
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

        private void TimerTarihSaat_Tick(object sender, EventArgs e)
        {
            TlStripTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private void VarsayilanAciklama(object sender, EventArgs e)
        {
            TlStripAcıklama.Text = Resources.varsayilanAciklama;
        }

        public void VerileriGetir()
        {
            SMF.Baglanti.Open();
            MySqlDataAdapter verileriGetir = new MySqlDataAdapter("Select * From musteribilgileri", SMF.Baglanti);
            DataTable dataTable1 = new DataTable();
            verileriGetir.Fill(dataTable1);
            DtGridViewKayitlariGoster.DataSource = dataTable1;
            SMF.Baglanti.Close();
        }

        public void Guncelle()
        {
            MessageBox.Show(Resources.secilenKaydiDuzenliyorsun, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frm.BttnKaydet.Enabled = false;
            _frm.TlStrpMenuItemAraclarKaydet.Enabled = false;
            _frm.BttnGuncelle.Enabled = true;
            _frm.TlStrpMenuItemAraclarGuncelle.Enabled = true;
            _frm.LblMusteriNo.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[0].Value.ToString();
            _frm.TxtMusteriAdi.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[1].Value.ToString();
            _frm.TxtFormNo.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[2].Value.ToString();
            _frm.MsKdTxtTelefon.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[3].Value.ToString();
            _frm.TxtUrunModeli.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[4].Value.ToString();
            _frm.CmbBoxUrunKodlari.SelectedText = DtGridViewKayitlariGoster.CurrentRow?.Cells[5].Value.ToString();
            _frm.TxtUrunKodlari.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[6].Value.ToString();
            _frm.TxtArizaTanimi.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[7].Value.ToString();
            _frm.TxtUrunDurumu.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[8].Value.ToString();
            _frm.TxtUrunTakipNo.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[9].Value.ToString();
            _frm.TxtUcret.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[10].Value.ToString();
            _frm.TxtAksesuarlar.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[11].Value.ToString();
            _frm.TxtEkBilgiler.Text = DtGridViewKayitlariGoster.CurrentRow?.Cells[12].Value.ToString();
            _frm.Show();
            Hide();
        }

        private void DilYenile()
        {
            Text = Resources.FrmKayitlariGoster;
            TlStrpMenuItemAraclar.Text = Resources.TlStrpMenuItemAraclar;
            TlStrpMenuItemAraclarYeniKayit.Text = Resources.TlStrpMenuItemAraclarYeniKayit;
            TlStrpMenuItemAraclarGuncelle.Text = Resources.TlStrpMenuItemAraclarGuncelle;
            TlStrpMenuItemAraclarSil.Text = Resources.TlStrpMenuItemAraclarSil;
            BttnSil.Text = Resources.BttnSil;
            BttnYazdir.Text = Resources.BttnYazdir;
            GrpBoxArama.Text = Resources.GrpBoxArama;
            RadioBttnFormNoyaGoreAra.Text = Resources.RadioBttnFormNoyaGoreAra;
            RadioBttnMusteriIsmineGoreAra.Text = Resources.RadioBttnMusteriIsmineGoreAra;
            TlStrpMenuItemAyarlar.Text = Resources.TlStrpMenuItemAyarlar;
            TlStrpMenuItemAyarlarDil.Text = Resources.TlStrpMenuItemAyarlarDil;
            TlStrpMenuItemDilTurkce.Text = Resources.TlStrpMenuItemDilTurkce;
            TlStrpMenuItemDilIngilizce.Text = Resources.TlStrpMenuItemDilIngilizce;
            TlStrpMenuItemAyarlarTema.Text = Resources.TlStrpMenuItemAyarlarTema;
            TlStrpMenuItemYardım.Text = Resources.TlStrpMenuItemYardim;
            TlStrpMenuItemYardimLisansAnahtari.Text = Resources.TlStrpMenuItemYardimLisansAnahtari;
            TlStrpMenuItemYardimHakkinda.Text = Resources.TlStrpMenuItemYardimHakkinda;
            TlStripAcıklama.Text = Resources.varsayilanAciklama;
        }

        private void FrmKayitlariGoster_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frm.Show();
            Dispose();
        }

        private void PrntBelge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font YaziFontlari = new Font("Times New Roman", 14, FontStyle.Regular);
            SolidBrush YaziRenk = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.RabtBilYaziciSablonu, 0, 0);
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[1].Value.ToString(), YaziFontlari, YaziRenk, 260, 245);//MusteriAdi
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[2].Value.ToString(), YaziFontlari, YaziRenk, 260, 297);//FormNo
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[3].Value.ToString(), YaziFontlari, YaziRenk, 260, 345);//Telefon
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[4].Value.ToString(), YaziFontlari, YaziRenk, 260, 397);//UrunModeli
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[6].Value.ToString(), YaziFontlari, YaziRenk, 260, 449);//ImeiSeriNo
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[7].Value.ToString(), YaziFontlari, YaziRenk, 260, 496);//ArizaTanimi
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[8].Value.ToString(), YaziFontlari, YaziRenk, 260, 547);//UrunDurumu
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[9].Value.ToString(), YaziFontlari, YaziRenk, 260, 592);//TakipNo
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[12].Value.ToString(), YaziFontlari, YaziRenk, 260, 642);//Aksesuarlar
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[11].Value.ToString() + " ₺", YaziFontlari, YaziRenk, 665, 805);//Ucret
            e.Graphics.DrawString(DtGridViewKayitlariGoster.CurrentRow?.Cells[14].Value.ToString(), YaziFontlari, YaziRenk, 610, 245);//TarihSaat
        }

        private void TlStrpMenuItemBaskiOnizleme_Click(object sender, EventArgs e)
        {
            PrntBaskiOnizleme.ShowDialog();
        }

        private void BttnYazdir_Click(object sender, EventArgs e)
        {
            PrntBelge.Print();
        }

        private void TlStrpMenuItemYardimHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda _frmHakkinda = new FrmHakkinda();
            _frmHakkinda.ShowDialog();
        }
    }
}