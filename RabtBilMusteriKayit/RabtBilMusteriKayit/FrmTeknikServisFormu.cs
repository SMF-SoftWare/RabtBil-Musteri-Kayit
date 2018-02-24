using System;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmTeknikServisFormu : Form
    {
        public FrmTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BttnKayitlariGoster_Click(object sender, System.EventArgs e)
        {
            FrmKayitlariGoster FrmKayitlariGoster = new FrmKayitlariGoster();
            FrmKayitlariGoster.Show();
            base.Hide();
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
    }
}