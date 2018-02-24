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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TlStrpMenuItemAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarDil = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimLisansAnahtari = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.güçlüBirŞifreOluşturunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinkLblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.LinkLblSistemeKayitOl = new System.Windows.Forms.LinkLabel();
            this.TxtYeniKullaniciOluştur = new System.Windows.Forms.TextBox();
            this.BttnYeniKullaniciOluştur = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BttnGirisYap
            // 
            this.BttnGirisYap.Location = new System.Drawing.Point(23, 181);
            this.BttnGirisYap.Name = "BttnGirisYap";
            this.BttnGirisYap.Size = new System.Drawing.Size(288, 36);
            this.BttnGirisYap.TabIndex = 0;
            this.BttnGirisYap.Text = "Giriş Yap";
            this.BttnGirisYap.UseVisualStyleBackColor = true;
            this.BttnGirisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(23, 71);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 2;
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
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle,
            this.TlStrpMenuItemAyarlarTema,
            this.güçlüBirŞifreOluşturunToolStripMenuItem});
            this.TlStrpMenuItemAyarlar.Name = "TlStrpMenuItemAyarlar";
            this.TlStrpMenuItemAyarlar.Size = new System.Drawing.Size(76, 22);
            this.TlStrpMenuItemAyarlar.Text = "Ayarlar";
            // 
            // TlStrpMenuItemAyarlarDil
            // 
            this.TlStrpMenuItemAyarlarDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemDilTurkce,
            this.TlStrpMenuItemDilIngilizce});
            this.TlStrpMenuItemAyarlarDil.Name = "TlStrpMenuItemAyarlarDil";
            this.TlStrpMenuItemAyarlarDil.Size = new System.Drawing.Size(276, 22);
            this.TlStrpMenuItemAyarlarDil.Text = "Dil";
            // 
            // TlStrpMenuItemDilTurkce
            // 
            this.TlStrpMenuItemDilTurkce.Name = "TlStrpMenuItemDilTurkce";
            this.TlStrpMenuItemDilTurkce.Size = new System.Drawing.Size(152, 22);
            this.TlStrpMenuItemDilTurkce.Text = "Tükçe";
            // 
            // TlStrpMenuItemDilIngilizce
            // 
            this.TlStrpMenuItemDilIngilizce.Name = "TlStrpMenuItemDilIngilizce";
            this.TlStrpMenuItemDilIngilizce.Size = new System.Drawing.Size(152, 22);
            this.TlStrpMenuItemDilIngilizce.Text = "İngilizce";
            // 
            // TlStrpMenuItemAyarlarGuncellemeleriDenetle
            // 
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle.Name = "TlStrpMenuItemAyarlarGuncellemeleriDenetle";
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle.Size = new System.Drawing.Size(276, 22);
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle.Text = "Güncellemeleri Denetle";
            // 
            // TlStrpMenuItemAyarlarTema
            // 
            this.TlStrpMenuItemAyarlarTema.Name = "TlStrpMenuItemAyarlarTema";
            this.TlStrpMenuItemAyarlarTema.Size = new System.Drawing.Size(276, 22);
            this.TlStrpMenuItemAyarlarTema.Text = "Tema";
            // 
            // TlStrpMenuItemYardım
            // 
            this.TlStrpMenuItemYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemYardimLisansAnahtari,
            this.TlStrpMenuItemYardimHakkinda});
            this.TlStrpMenuItemYardım.Name = "TlStrpMenuItemYardım";
            this.TlStrpMenuItemYardım.Size = new System.Drawing.Size(68, 22);
            this.TlStrpMenuItemYardım.Text = "Yardım";
            // 
            // TlStrpMenuItemYardimLisansAnahtari
            // 
            this.TlStrpMenuItemYardimLisansAnahtari.Name = "TlStrpMenuItemYardimLisansAnahtari";
            this.TlStrpMenuItemYardimLisansAnahtari.Size = new System.Drawing.Size(196, 22);
            this.TlStrpMenuItemYardimLisansAnahtari.Text = "Lisans Anahtarı";
            // 
            // TlStrpMenuItemYardimHakkinda
            // 
            this.TlStrpMenuItemYardimHakkinda.Name = "TlStrpMenuItemYardimHakkinda";
            this.TlStrpMenuItemYardimHakkinda.Size = new System.Drawing.Size(196, 22);
            this.TlStrpMenuItemYardimHakkinda.Text = "Hakkında";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(23, 149);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 26);
            this.textBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre:";
            // 
            // güçlüBirŞifreOluşturunToolStripMenuItem
            // 
            this.güçlüBirŞifreOluşturunToolStripMenuItem.Name = "güçlüBirŞifreOluşturunToolStripMenuItem";
            this.güçlüBirŞifreOluşturunToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.güçlüBirŞifreOluşturunToolStripMenuItem.Text = "Güçlü Bir Şifre Oluşturun";
            // 
            // LinkLblSifremiUnuttum
            // 
            this.LinkLblSifremiUnuttum.AutoSize = true;
            this.LinkLblSifremiUnuttum.Location = new System.Drawing.Point(89, 220);
            this.LinkLblSifremiUnuttum.Name = "LinkLblSifremiUnuttum";
            this.LinkLblSifremiUnuttum.Size = new System.Drawing.Size(144, 18);
            this.LinkLblSifremiUnuttum.TabIndex = 20;
            this.LinkLblSifremiUnuttum.TabStop = true;
            this.LinkLblSifremiUnuttum.Text = "Şifremi Unuttum ?";
            // 
            // LinkLblSistemeKayitOl
            // 
            this.LinkLblSistemeKayitOl.AutoSize = true;
            this.LinkLblSistemeKayitOl.Location = new System.Drawing.Point(89, 253);
            this.LinkLblSistemeKayitOl.Name = "LinkLblSistemeKayitOl";
            this.LinkLblSistemeKayitOl.Size = new System.Drawing.Size(136, 18);
            this.LinkLblSistemeKayitOl.TabIndex = 21;
            this.LinkLblSistemeKayitOl.TabStop = true;
            this.LinkLblSistemeKayitOl.Text = "Sisteme Kayıt Ol";
            this.LinkLblSistemeKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblSistemeKayitOl_LinkClicked);
            // 
            // TxtYeniKullaniciOluştur
            // 
            this.TxtYeniKullaniciOluştur.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYeniKullaniciOluştur.Location = new System.Drawing.Point(23, 291);
            this.TxtYeniKullaniciOluştur.MaxLength = 30;
            this.TxtYeniKullaniciOluştur.Name = "TxtYeniKullaniciOluştur";
            this.TxtYeniKullaniciOluştur.Size = new System.Drawing.Size(288, 26);
            this.TxtYeniKullaniciOluştur.TabIndex = 22;
            // 
            // BttnYeniKullaniciOluştur
            // 
            this.BttnYeniKullaniciOluştur.Location = new System.Drawing.Point(23, 323);
            this.BttnYeniKullaniciOluştur.Name = "BttnYeniKullaniciOluştur";
            this.BttnYeniKullaniciOluştur.Size = new System.Drawing.Size(288, 36);
            this.BttnYeniKullaniciOluştur.TabIndex = 23;
            this.BttnYeniKullaniciOluştur.Text = "Yeni Kullanıcı Oluştur";
            this.BttnYeniKullaniciOluştur.UseVisualStyleBackColor = true;
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 366);
            this.Controls.Add(this.BttnYeniKullaniciOluştur);
            this.Controls.Add(this.TxtYeniKullaniciOluştur);
            this.Controls.Add(this.LinkLblSistemeKayitOl);
            this.Controls.Add(this.LinkLblSifremiUnuttum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnGirisYap);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Name = "FrmGirisYap";
            this.Text = "FrmGirisYap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlar;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarDil;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilTurkce;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilIngilizce;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarGuncellemeleriDenetle;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarTema;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardım;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimLisansAnahtari;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimHakkinda;
        private System.Windows.Forms.ToolStripMenuItem güçlüBirŞifreOluşturunToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkLblSifremiUnuttum;
        private System.Windows.Forms.LinkLabel LinkLblSistemeKayitOl;
        private System.Windows.Forms.TextBox TxtYeniKullaniciOluştur;
        private System.Windows.Forms.Button BttnYeniKullaniciOluştur;
    }
}

