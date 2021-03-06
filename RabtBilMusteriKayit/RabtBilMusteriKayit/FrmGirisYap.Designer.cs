﻿using RabtBilMusteriKayit.Properties;


namespace RabtBilMusteriKayit
{
    partial class FrmGirisYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BttnGirisYap = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TlStrpMenuItemAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarDil = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimLisansAnahtari = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LinkLblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.TxtEposta = new System.Windows.Forms.TextBox();
            this.BttnYeniKullaniciOluştur = new System.Windows.Forms.Button();
            this.LblEposta = new System.Windows.Forms.Label();
            this.PcTrBoxEye = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnGirisYap
            // 
            this.BttnGirisYap.Location = new System.Drawing.Point(23, 162);
            this.BttnGirisYap.Name = "BttnGirisYap";
            this.BttnGirisYap.Size = new System.Drawing.Size(288, 36);
            this.BttnGirisYap.TabIndex = 0;
            this.BttnGirisYap.Text = global::RabtBilMusteriKayit.Properties.Resources.BttnGirisYap;
            this.BttnGirisYap.UseVisualStyleBackColor = true;
            this.BttnGirisYap.Click += new System.EventHandler(this.BttnGirisYap_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 50);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(105, 15);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(23, 71);
            this.TxtKullaniciAdi.MaxLength = 30;
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(288, 26);
            this.TxtKullaniciAdi.TabIndex = 2;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAyarlar,
            this.TlStrpMenuItemYardım});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(349, 26);
            this.MenuStrip.TabIndex = 17;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // TlStrpMenuItemAyarlar
            // 
            this.TlStrpMenuItemAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAyarlarDil,
            this.TlStrpMenuItemAyarlarTema});
            this.TlStrpMenuItemAyarlar.Name = "TlStrpMenuItemAyarlar";
            this.TlStrpMenuItemAyarlar.Size = new System.Drawing.Size(76, 22);
            this.TlStrpMenuItemAyarlar.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemAyarlar;
            // 
            // TlStrpMenuItemAyarlarDil
            // 
            this.TlStrpMenuItemAyarlarDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemDilTurkce,
            this.TlStrpMenuItemDilIngilizce});
            this.TlStrpMenuItemAyarlarDil.Name = "TlStrpMenuItemAyarlarDil";
            this.TlStrpMenuItemAyarlarDil.Size = new System.Drawing.Size(108, 22);
            this.TlStrpMenuItemAyarlarDil.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemAyarlarDil;
            // 
            // TlStrpMenuItemDilTurkce
            // 
            this.TlStrpMenuItemDilTurkce.Name = "TlStrpMenuItemDilTurkce";
            this.TlStrpMenuItemDilTurkce.Size = new System.Drawing.Size(148, 22);
            this.TlStrpMenuItemDilTurkce.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemDilTurkce;
            this.TlStrpMenuItemDilTurkce.Click += new System.EventHandler(this.TlStrpMenuItemDilTurkce_Click);
            // 
            // TlStrpMenuItemDilIngilizce
            // 
            this.TlStrpMenuItemDilIngilizce.Name = "TlStrpMenuItemDilIngilizce";
            this.TlStrpMenuItemDilIngilizce.Size = new System.Drawing.Size(148, 22);
            this.TlStrpMenuItemDilIngilizce.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemDilIngilizce;
            this.TlStrpMenuItemDilIngilizce.Click += new System.EventHandler(this.TlStrpMenuItemDilIngilizce_Click);
            // 
            // TlStrpMenuItemAyarlarTema
            // 
            this.TlStrpMenuItemAyarlarTema.Name = "TlStrpMenuItemAyarlarTema";
            this.TlStrpMenuItemAyarlarTema.Size = new System.Drawing.Size(108, 22);
            this.TlStrpMenuItemAyarlarTema.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemAyarlarTema;
            // 
            // TlStrpMenuItemYardım
            // 
            this.TlStrpMenuItemYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemYardimLisansAnahtari,
            this.TlStrpMenuItemYardimHakkinda});
            this.TlStrpMenuItemYardım.Name = "TlStrpMenuItemYardım";
            this.TlStrpMenuItemYardım.Size = new System.Drawing.Size(68, 22);
            this.TlStrpMenuItemYardım.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemYardim;
            // 
            // TlStrpMenuItemYardimLisansAnahtari
            // 
            this.TlStrpMenuItemYardimLisansAnahtari.Name = "TlStrpMenuItemYardimLisansAnahtari";
            this.TlStrpMenuItemYardimLisansAnahtari.Size = new System.Drawing.Size(196, 22);
            this.TlStrpMenuItemYardimLisansAnahtari.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemYardimLisansAnahtari;
            this.TlStrpMenuItemYardimLisansAnahtari.Click += new System.EventHandler(this.TlStrpMenuItemYardimLisansAnahtari_Click);
            // 
            // TlStrpMenuItemYardimHakkinda
            // 
            this.TlStrpMenuItemYardimHakkinda.Name = "TlStrpMenuItemYardimHakkinda";
            this.TlStrpMenuItemYardimHakkinda.Size = new System.Drawing.Size(196, 22);
            this.TlStrpMenuItemYardimHakkinda.Text = global::RabtBilMusteriKayit.Properties.Resources.TlStrpMenuItemYardimHakkinda;
            this.TlStrpMenuItemYardimHakkinda.Click += new System.EventHandler(this.TlStrpMenuItemYardimHakkinda_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(23, 130);
            this.TxtSifre.MaxLength = 20;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(288, 26);
            this.TxtSifre.TabIndex = 19;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.LblSifre.Location = new System.Drawing.Point(20, 112);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(49, 15);
            this.LblSifre.TabIndex = 18;
            this.LblSifre.Text = "Şifre:";
            // 
            // LinkLblSifremiUnuttum
            // 
            this.LinkLblSifremiUnuttum.AutoSize = true;
            this.LinkLblSifremiUnuttum.Location = new System.Drawing.Point(164, 201);
            this.LinkLblSifremiUnuttum.Name = "LinkLblSifremiUnuttum";
            this.LinkLblSifremiUnuttum.Size = new System.Drawing.Size(136, 18);
            this.LinkLblSifremiUnuttum.TabIndex = 20;
            this.LinkLblSifremiUnuttum.TabStop = true;
            this.LinkLblSifremiUnuttum.Text = "Şifremi Unuttum?";
            this.LinkLblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblSifremiUnuttum_LinkClicked);
            // 
            // TxtEposta
            // 
            this.TxtEposta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEposta.Location = new System.Drawing.Point(23, 252);
            this.TxtEposta.MaxLength = 30;
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(288, 26);
            this.TxtEposta.TabIndex = 22;
            // 
            // BttnYeniKullaniciOluştur
            // 
            this.BttnYeniKullaniciOluştur.Location = new System.Drawing.Point(23, 287);
            this.BttnYeniKullaniciOluştur.Name = "BttnYeniKullaniciOluştur";
            this.BttnYeniKullaniciOluştur.Size = new System.Drawing.Size(288, 36);
            this.BttnYeniKullaniciOluştur.TabIndex = 23;
            this.BttnYeniKullaniciOluştur.Text = global::RabtBilMusteriKayit.Properties.Resources.BttnYeniKullaniciOluştur;
            this.BttnYeniKullaniciOluştur.UseVisualStyleBackColor = true;
            this.BttnYeniKullaniciOluştur.Click += new System.EventHandler(this.BttnYeniKullaniciOluştur_Click);
            // 
            // LblEposta
            // 
            this.LblEposta.AutoSize = true;
            this.LblEposta.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.LblEposta.Location = new System.Drawing.Point(20, 234);
            this.LblEposta.Name = "LblEposta";
            this.LblEposta.Size = new System.Drawing.Size(63, 15);
            this.LblEposta.TabIndex = 24;
            this.LblEposta.Text = "E-posta:";
            // 
            // PcTrBoxEye
            // 
            this.PcTrBoxEye.Image = global::RabtBilMusteriKayit.Properties.Resources.eye;
            this.PcTrBoxEye.Location = new System.Drawing.Point(287, 132);
            this.PcTrBoxEye.Name = "PcTrBoxEye";
            this.PcTrBoxEye.Size = new System.Drawing.Size(22, 22);
            this.PcTrBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcTrBoxEye.TabIndex = 25;
            this.PcTrBoxEye.TabStop = false;
            this.PcTrBoxEye.Click += new System.EventHandler(this.PcTrBoxEyeOn_Click);
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 331);
            this.Controls.Add(this.PcTrBoxEye);
            this.Controls.Add(this.LblEposta);
            this.Controls.Add(this.BttnYeniKullaniciOluştur);
            this.Controls.Add(this.TxtEposta);
            this.Controls.Add(this.LinkLblSifremiUnuttum);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.BttnGirisYap);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Name = "FrmGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGirisYap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnGirisYap;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlar;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarDil;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilTurkce;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilIngilizce;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarTema;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardım;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimLisansAnahtari;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimHakkinda;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.LinkLabel LinkLblSifremiUnuttum;
        private System.Windows.Forms.TextBox TxtEposta;
        private System.Windows.Forms.Button BttnYeniKullaniciOluştur;
        private System.Windows.Forms.Label LblEposta;
        private System.Windows.Forms.PictureBox PcTrBoxEye;
    }
}

