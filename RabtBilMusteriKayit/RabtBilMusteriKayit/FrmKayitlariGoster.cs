using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace RabtBilMusteriKayit
{
    public partial class FrmKayitlariGoster : Form
    {
        private readonly MySqlConnection _baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }
        public void _verilerigetir()
        {
            _baglanti.Open();
            MySqlDataAdapter verilerigetir = new MySqlDataAdapter("Select * From musteribilgileri", _baglanti);
            DataSet dataSet = new DataSet();
            verilerigetir.Fill(dataSet, "musteribilgileri");
            DtGridViewKayitlariGoster.DataSource = dataSet.Tables["musteribilgileri"];
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

        private void DtGridViewKayitlariGoster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmTeknikServisFormu frmTeknikServisFormu = new FrmTeknikServisFormu();
            //    if (DtGridViewKayitlariGoster.CellDoubleClick=true)
            //    {

            //    }
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
        }
    }
}
