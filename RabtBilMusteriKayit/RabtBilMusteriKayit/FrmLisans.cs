using RabtBilMusteriKayit.Properties;
using System;
using System.Windows.Forms;
using static RabtBilMusteriKayit.Properties.Settings;

namespace RabtBilMusteriKayit
{
    public partial class FrmLisans : Form
    {
        private SMF SMF = new SMF();

        public FrmLisans()
        {
            InitializeComponent();
        }

        private void FrmLisans_Load(object sender, EventArgs e)
        {
            SMF.DilKontrolEt();
            DilYenile();
        }

        private void BttnEtkinlestir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtEposta.Text) || String.IsNullOrWhiteSpace(TxtLisansAnahtari.Text))
            {
                MessageBox.Show(Resources.epostaVeyaLisansAnahtariBos, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SMF.EpostaDogruMu(TxtEposta.Text))
            {
                if (SMF.KontrolEt(TxtEposta.Text, TxtLisansAnahtari.Text))
                {
                    Default.LisansliMi = Convert.ToBoolean(1);
                    Default.Lisans = TxtLisansAnahtari.Text.ToUpper();
                    Default.Save();
                    MessageBox.Show(Resources.lisansBasarili, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    Default.LisansliMi = Convert.ToBoolean(0);
                    Default.Lisans = null;
                    Default.Save();
                    MessageBox.Show(Resources.lisansTekrarDene, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Resources.dogruBirEpostaGirin, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DilYenile()
        {
            Text = Resources.FrmLisans;
            LblEposta.Text = Resources.LblLisansEposta;
            LblLisansAnahtari.Text = Resources.LblLisansAnahtari;
            BttnEtkinlestir.Text = Resources.BttnEtkinlestir;
        }
    }
}