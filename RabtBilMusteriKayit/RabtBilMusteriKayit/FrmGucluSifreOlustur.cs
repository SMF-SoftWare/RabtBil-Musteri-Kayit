using System;
using System.Text;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmGucluSifreOlustur : Form
    {
        private string sifre = "";

        public FrmGucluSifreOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifre = GucluSifreOlustur(Convert.ToInt32(comboBox1.Text));
            textBox1.Text = sifre;
        }

        public string GucluSifreOlustur(int uzunluk)
        {
            const string kucukHarfler = "abcdefghijklmnopqrstuvwxyz";
            const string buyukHarfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string sayilar = "1234567890";
            const string semboller = "@#$&*-+!?%^._:'\\/{}[]=()<>";
            string sifre = "";
            if (checkBox1.Checked)
            {
                sifre += kucukHarfler;
            }

            if (checkBox2.Checked)
            {
                sifre += buyukHarfler;
            }

            if (checkBox3.Checked)
            {
                sifre += sayilar;
            }

            if (checkBox4.Checked)
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

        private void FrmGucluSifreOlustur_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                comboBox1.Items.Add(i + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProfil frm = new FrmProfil();
            frm.TxtSifreniz.Text = sifre;
            frm.TxtSifreniziOnaylayın.Text = sifre;
            if (sifre != null) Clipboard.SetText(sifre);  
            Hide();
        }

        private void FrmGucluSifreOlustur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}