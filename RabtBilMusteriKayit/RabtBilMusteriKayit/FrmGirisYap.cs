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
            base.Width = 355;
            base.Height = 290;
            TxtYeniKullaniciOluştur.Hide();
            BttnYeniKullaniciOluştur.Hide();
        }

        private void LinkLblSistemeKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sisteme kayıt olmak için mail adresini giriniz size geçici kullanıcı adı ve şifre gönderilecektir sonrasında değiştirmelisiniz");
            base.Width = 355;
            base.Height = 370;
            TxtYeniKullaniciOluştur.Show();
            BttnYeniKullaniciOluştur.Show();
        }

        private void BttnGirisYap_Click(object sender, EventArgs e)
        {
            FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
            frm.Show();
            this.Hide();
        }
    }
}