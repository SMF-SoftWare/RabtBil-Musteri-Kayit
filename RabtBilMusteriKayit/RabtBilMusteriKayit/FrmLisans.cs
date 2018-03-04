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
            if (Default.LisansliMi)
            {
                LblDurum.Text = "Lisanslı";
            }
            else
            {
                LblDurum.Text = "Lisanssız";
            }
        }

        private void BttnEtkinlestir_Click(object sender, EventArgs e)
        {
            if (SMF.KontrolEt(TxtEposta.Text, TxtLisansAnahtari.Text))
            {
                Default.LisansliMi = Convert.ToBoolean(1);
                Default.Lisans = TxtLisansAnahtari.Text;
                Default.Save();
                LblDurum.Text = "Lisanslı";
                MessageBox.Show("Programı Satın Aldığınız İçin Teşekkür Ederiz!");
                Application.Restart();
            }
            else
            {
                Default.LisansliMi = Convert.ToBoolean(0);
                Default.Lisans = TxtLisansAnahtari.Text;
                Default.Save();
                LblDurum.Text = "Lisanssız";
                MessageBox.Show("Lisans Kodu Doğru Değil!");
            }
        }
    }
}