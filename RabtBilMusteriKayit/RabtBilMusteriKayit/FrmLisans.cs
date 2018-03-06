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
            //DilYenile();
        }

        private void BttnEtkinlestir_Click(object sender, EventArgs e)
        {
            if (SMF.KontrolEt(TxtEposta.Text, TxtLisansAnahtari.Text))
            {
                Default.LisansliMi = Convert.ToBoolean(1);
                Default.Lisans = TxtLisansAnahtari.Text.ToUpper();
                Default.Save();
                MessageBox.Show("Programı Satın Aldığınız İçin Teşekkür Ederiz!");
            }
            else
            {
                Default.LisansliMi = Convert.ToBoolean(0);
                Default.Lisans = null;
                Default.Save();
                MessageBox.Show("Lisans Kodu Doğru Değil!");
            }
        }
    }
}