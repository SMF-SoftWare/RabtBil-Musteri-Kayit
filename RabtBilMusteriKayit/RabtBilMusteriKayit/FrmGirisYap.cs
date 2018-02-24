using System;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Width = 365;
            base.Height = 315;
            TxtYeniKullaniciOluştur.Hide();
            BttnYeniKullaniciOluştur.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {//365; 315  365; 405
            FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
            frm.Show();
            this.Hide();
        }

        private void LinkLblSistemeKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sisteme kayıt olmak için mail adresini giriniz size geçici kullanıcı adı ve şifre gönderilecektir sonrasında değiştirmelisiniz");
            base.Width = 365;
            base.Height = 405;
            TxtYeniKullaniciOluştur.Show();
            BttnYeniKullaniciOluştur.Show();
        }
    }
}