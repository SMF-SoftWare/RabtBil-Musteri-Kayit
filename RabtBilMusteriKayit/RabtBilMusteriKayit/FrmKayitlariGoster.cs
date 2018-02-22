using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabtBilMusteriKayit
{
    public partial class FrmKayitlariGoster : Form
    {
        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            TimerTarihSaat.Enabled = true;
        }

        private void TimerTarihSaat_Tick(object sender, EventArgs e)
        {
            TlStripTarihSaat.Text = System.DateTime.Now.ToString();
        }
    }
}
