using RabtBilMusteriKayit.Properties;
using System;
using System.Text;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmGucluSifreOlustur : Form
    {
        private SMF SMF = new SMF();
        private string sifre;

        public FrmGucluSifreOlustur()
        {
            InitializeComponent();
        }

        private void FrmGucluSifreOlustur_Load(object sender, EventArgs e)
        {
            SMF.DilKontrolEt();
            DilYenile();

            ChckBoxKucukHarfler.Checked = true;
            ChckBoxBuyukHarfler.Checked = true;
            lblSifreUzunluguDeger.Text = TrckBarSifreKarakter.Value.ToString();
        }

        private void BttnKopyala_Click(object sender, EventArgs e)
        {
            if (sifre != null) Clipboard.SetText(sifre);
        }

        private void TrckBarSifreKarakter_Scroll(object sender, EventArgs e)
        {
            try
            {
                sifre = GucluSifreOlustur(TrckBarSifreKarakter.Value);
                TxtGucluSifreniz.Text = sifre;
                lblSifreUzunluguDeger.Text = TrckBarSifreKarakter.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Hata);
            }
        }

        private void DilYenile()
        {
            Text = Resources.FrmGucluSifreOlustur;
            lblSifreUzunlugu.Text = Resources.lblSifreUzunlugu;
            lblGucluSifreniz.Text = Resources.lblGucluSifreniz;
            BttnKopyala.Text = Resources.BttnKopyala;
            ChckBoxKucukHarfler.Text = Resources.ChckBoxKucukHarfler;
            ChckBoxBuyukHarfler.Text = Resources.ChckBoxBuyukHarfler;
            ChckBoxSayılar.Text = Resources.ChckBoxSayilar;
            ChckBoxSemboller.Text = Resources.ChckBoxSemboller;
        }

        public string GucluSifreOlustur(int uzunluk)
        {
            const string kucukHarfler = "abcdefghijklmnopqrstuvwxyz";
            const string buyukHarfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string sayilar = "1234567890";
            const string semboller = "@#$&*-+!?%^._:'\\/{}[]=()<>";
            string sifre = "";
            if (ChckBoxKucukHarfler.Checked)
            {
                sifre += kucukHarfler;
            }

            if (ChckBoxBuyukHarfler.Checked)
            {
                sifre += buyukHarfler;
            }

            if (ChckBoxSayılar.Checked)
            {
                sifre += sayilar;
            }

            if (ChckBoxSemboller.Checked)
            {
                sifre += semboller;
            }
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            while (0 < uzunluk--)
            {
                sb.Append(sifre[rnd.Next(sifre.Length)]);
            }
            return sb.ToString();
        }

        private void FrmGucluSifreOlustur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}