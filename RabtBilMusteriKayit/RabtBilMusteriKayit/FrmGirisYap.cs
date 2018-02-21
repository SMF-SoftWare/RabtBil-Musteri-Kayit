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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTeknikServisFormu frm = new FrmTeknikServisFormu();
            frm.Show();
            this.Hide();
        }
    }
}