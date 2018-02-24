﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RabtBilMusteriKayit
{
    public partial class FrmTeknikServisFormu : Form
    {
        MySqlConnection _baglanti = new MySqlConnection("Server=localhost;Port=3306;Uid=root;password=;Database=rabtbildb");
        public FrmTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void BttnKayitlariGoster_Click(object sender, System.EventArgs e)
        {
            FrmKayitlariGoster frmKayitlariGoster = new FrmKayitlariGoster();
            frmKayitlariGoster.Show();
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