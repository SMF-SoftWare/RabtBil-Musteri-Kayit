namespace RabtBilMusteriKayit
{
    partial class FrmKayitlariGoster
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TlStrpMenuItemAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarKayitlariGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarDil = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimLisansAnahtari = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrip = new System.Windows.Forms.ToolStrip();
            this.TlStripAcıklama = new System.Windows.Forms.ToolStripLabel();
            this.TlStripTarihSaat = new System.Windows.Forms.ToolStripLabel();
            this.DtGridViewKayitlariGoster = new System.Windows.Forms.DataGridView();
            this.BttnSil = new System.Windows.Forms.Button();
            this.BttnYazdir = new System.Windows.Forms.Button();
            this.TimerTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.GrpBoxArama = new System.Windows.Forms.GroupBox();
            this.BttnBul = new System.Windows.Forms.Button();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.RadioBttnMusteriIsmineGoreAra = new System.Windows.Forms.RadioButton();
            this.RadioBttnNoyaGoreAra = new System.Windows.Forms.RadioButton();
            this.MenuStrip.SuspendLayout();
            this.TlStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridViewKayitlariGoster)).BeginInit();
            this.GrpBoxArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAraclar,
            this.TlStrpMenuItemAyarlar,
            this.TlStrpMenuItemYardım});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(924, 26);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // TlStrpMenuItemAraclar
            // 
            this.TlStrpMenuItemAraclar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAraclarYeniKayit,
            this.TlStrpMenuItemAraclarKaydet,
            this.TlStrpMenuItemAraclarTemizle,
            this.TlStrpMenuItemAraclarKayitlariGoster,
            this.TlStrpMenuItemAraclarGuncelle,
            this.TlStrpMenuItemAraclarSil});
            this.TlStrpMenuItemAraclar.Name = "TlStrpMenuItemAraclar";
            this.TlStrpMenuItemAraclar.Size = new System.Drawing.Size(76, 22);
            this.TlStrpMenuItemAraclar.Text = "Araçlar";
            // 
            // TlStrpMenuItemAraclarYeniKayit
            // 
            this.TlStrpMenuItemAraclarYeniKayit.Name = "TlStrpMenuItemAraclarYeniKayit";
            this.TlStrpMenuItemAraclarYeniKayit.Size = new System.Drawing.Size(204, 22);
            this.TlStrpMenuItemAraclarYeniKayit.Text = "Yeni Kayıt";
            // 
            // TlStrpMenuItemAraclarKaydet
            // 
            this.TlStrpMenuItemAraclarKaydet.Name = "TlStrpMenuItemAraclarKaydet";
            this.TlStrpMenuItemAraclarKaydet.Size = new System.Drawing.Size(204, 22);
            this.TlStrpMenuItemAraclarKaydet.Text = "Kaydet";
            // 
            // TlStrpMenuItemAraclarTemizle
            // 
            this.TlStrpMenuItemAraclarTemizle.Name = "TlStrpMenuItemAraclarTemizle";
            this.TlStrpMenuItemAraclarTemizle.Size = new System.Drawing.Size(204, 22);
            this.TlStrpMenuItemAraclarTemizle.Text = "Temizle";
            // 
            // TlStrpMenuItemAraclarKayitlariGoster
            // 
            this.TlStrpMenuItemAraclarKayitlariGoster.Name = "TlStrpMenuItemAraclarKayitlariGoster";
            this.TlStrpMenuItemAraclarKayitlariGoster.Size = new System.Drawing.Size(204, 22);
            this.TlStrpMenuItemAraclarKayitlariGoster.Text = "Kayıtları Göster";
            // 
            // TlStrpMenuItemAraclarGuncelle
            // 
            this.TlStrpMenuItemAraclarGuncelle.Name = "TlStrpMenuItemAraclarGuncelle";
            this.TlStrpMenuItemAraclarGuncelle.Size = new System.Drawing.Size(204, 22);
            this.TlStrpMenuItemAraclarGuncelle.Text = "Güncelle";
            // 
            // TlStrpMenuItemAraclarSil
            // 
            this.TlStrpMenuItemAraclarSil.Name = "TlStrpMenuItemAraclarSil";
            this.TlStrpMenuItemAraclarSil.Size = new System.Drawing.Size(204, 22);
            this.TlStrpMenuItemAraclarSil.Text = "Sil";
            // 
            // TlStrpMenuItemAyarlar
            // 
            this.TlStrpMenuItemAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAyarlarDil,
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle,
            this.TlStrpMenuItemAyarlarTema});
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
            this.TlStrpMenuItemAyarlarDil.Size = new System.Drawing.Size(252, 22);
            this.TlStrpMenuItemAyarlarDil.Text = "Dil";
            // 
            // TlStrpMenuItemDilTurkce
            // 
            this.TlStrpMenuItemDilTurkce.Name = "TlStrpMenuItemDilTurkce";
            this.TlStrpMenuItemDilTurkce.Size = new System.Drawing.Size(148, 22);
            this.TlStrpMenuItemDilTurkce.Text = "Tükçe";
            // 
            // TlStrpMenuItemDilIngilizce
            // 
            this.TlStrpMenuItemDilIngilizce.Name = "TlStrpMenuItemDilIngilizce";
            this.TlStrpMenuItemDilIngilizce.Size = new System.Drawing.Size(148, 22);
            this.TlStrpMenuItemDilIngilizce.Text = "İngilizce";
            // 
            // TlStrpMenuItemAyarlarGuncellemeleriDenetle
            // 
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle.Name = "TlStrpMenuItemAyarlarGuncellemeleriDenetle";
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle.Size = new System.Drawing.Size(252, 22);
            this.TlStrpMenuItemAyarlarGuncellemeleriDenetle.Text = "Güncellemeleri Denetle";
            // 
            // TlStrpMenuItemAyarlarTema
            // 
            this.TlStrpMenuItemAyarlarTema.Name = "TlStrpMenuItemAyarlarTema";
            this.TlStrpMenuItemAyarlarTema.Size = new System.Drawing.Size(252, 22);
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
            // TlStrip
            // 
            this.TlStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlStrip.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.TlStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStripAcıklama,
            this.TlStripTarihSaat});
            this.TlStrip.Location = new System.Drawing.Point(0, 451);
            this.TlStrip.Name = "TlStrip";
            this.TlStrip.Size = new System.Drawing.Size(924, 25);
            this.TlStrip.TabIndex = 17;
            this.TlStrip.Text = "toolStrip1";
            // 
            // TlStripAcıklama
            // 
            this.TlStripAcıklama.Name = "TlStripAcıklama";
            this.TlStripAcıklama.Size = new System.Drawing.Size(72, 22);
            this.TlStripAcıklama.Text = "Açıklama";
            // 
            // TlStripTarihSaat
            // 
            this.TlStripTarihSaat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TlStripTarihSaat.Name = "TlStripTarihSaat";
            this.TlStripTarihSaat.Size = new System.Drawing.Size(112, 22);
            this.TlStripTarihSaat.Text = "Tarih ve Saat";
            // 
            // DtGridViewKayitlariGoster
            // 
            this.DtGridViewKayitlariGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridViewKayitlariGoster.Location = new System.Drawing.Point(12, 29);
            this.DtGridViewKayitlariGoster.Name = "DtGridViewKayitlariGoster";
            this.DtGridViewKayitlariGoster.Size = new System.Drawing.Size(900, 349);
            this.DtGridViewKayitlariGoster.TabIndex = 18;
            this.DtGridViewKayitlariGoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridViewKayitlariGoster_CellDoubleClick);
            this.DtGridViewKayitlariGoster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridViewKayitlariGoster_CellDoubleClick);
            // 
            // BttnSil
            // 
            this.BttnSil.Location = new System.Drawing.Point(12, 398);
            this.BttnSil.Name = "BttnSil";
            this.BttnSil.Size = new System.Drawing.Size(128, 45);
            this.BttnSil.TabIndex = 27;
            this.BttnSil.Text = "Sil";
            this.BttnSil.UseVisualStyleBackColor = true;
            // 
            // BttnYazdir
            // 
            this.BttnYazdir.Location = new System.Drawing.Point(147, 398);
            this.BttnYazdir.Name = "BttnYazdir";
            this.BttnYazdir.Size = new System.Drawing.Size(128, 45);
            this.BttnYazdir.TabIndex = 28;
            this.BttnYazdir.Text = "Yazdır";
            this.BttnYazdir.UseVisualStyleBackColor = true;
            // 
            // TimerTarihSaat
            // 
            this.TimerTarihSaat.Tick += new System.EventHandler(this.TimerTarihSaat_Tick);
            // 
            // GrpBoxArama
            // 
            this.GrpBoxArama.Controls.Add(this.BttnBul);
            this.GrpBoxArama.Controls.Add(this.TxtArama);
            this.GrpBoxArama.Controls.Add(this.RadioBttnMusteriIsmineGoreAra);
            this.GrpBoxArama.Controls.Add(this.RadioBttnNoyaGoreAra);
            this.GrpBoxArama.Location = new System.Drawing.Point(281, 384);
            this.GrpBoxArama.Name = "GrpBoxArama";
            this.GrpBoxArama.Size = new System.Drawing.Size(631, 62);
            this.GrpBoxArama.TabIndex = 29;
            this.GrpBoxArama.TabStop = false;
            this.GrpBoxArama.Text = "Arama";
            // 
            // BttnBul
            // 
            this.BttnBul.Location = new System.Drawing.Point(497, 16);
            this.BttnBul.Name = "BttnBul";
            this.BttnBul.Size = new System.Drawing.Size(128, 35);
            this.BttnBul.TabIndex = 29;
            this.BttnBul.Text = "Bul";
            this.BttnBul.UseVisualStyleBackColor = true;
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(196, 24);
            this.TxtArama.MaxLength = 30;
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.ReadOnly = true;
            this.TxtArama.Size = new System.Drawing.Size(281, 25);
            this.TxtArama.TabIndex = 16;
            // 
            // RadioBttnMusteriIsmineGoreAra
            // 
            this.RadioBttnMusteriIsmineGoreAra.AutoSize = true;
            this.RadioBttnMusteriIsmineGoreAra.Location = new System.Drawing.Point(4, 36);
            this.RadioBttnMusteriIsmineGoreAra.Name = "RadioBttnMusteriIsmineGoreAra";
            this.RadioBttnMusteriIsmineGoreAra.Size = new System.Drawing.Size(186, 22);
            this.RadioBttnMusteriIsmineGoreAra.TabIndex = 1;
            this.RadioBttnMusteriIsmineGoreAra.TabStop = true;
            this.RadioBttnMusteriIsmineGoreAra.Text = "Müşteri isimine göre";
            this.RadioBttnMusteriIsmineGoreAra.UseVisualStyleBackColor = true;
            // 
            // RadioBttnNoyaGoreAra
            // 
            this.RadioBttnNoyaGoreAra.AutoSize = true;
            this.RadioBttnNoyaGoreAra.Location = new System.Drawing.Point(4, 16);
            this.RadioBttnNoyaGoreAra.Name = "RadioBttnNoyaGoreAra";
            this.RadioBttnNoyaGoreAra.Size = new System.Drawing.Size(162, 22);
            this.RadioBttnNoyaGoreAra.TabIndex = 0;
            this.RadioBttnNoyaGoreAra.TabStop = true;
            this.RadioBttnNoyaGoreAra.Text = "Form no\'suna göre";
            this.RadioBttnNoyaGoreAra.UseVisualStyleBackColor = true;
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 476);
            this.Controls.Add(this.GrpBoxArama);
            this.Controls.Add(this.BttnYazdir);
            this.Controls.Add(this.BttnSil);
            this.Controls.Add(this.DtGridViewKayitlariGoster);
            this.Controls.Add(this.TlStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(940, 515);
            this.MinimumSize = new System.Drawing.Size(940, 515);
            this.Name = "FrmKayitlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabtBil Kayıt -> Kayıtları Göster";
            this.Load += new System.EventHandler(this.FrmKayitlariGoster_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TlStrip.ResumeLayout(false);
            this.TlStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridViewKayitlariGoster)).EndInit();
            this.GrpBoxArama.ResumeLayout(false);
            this.GrpBoxArama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclar;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarYeniKayit;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarKaydet;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarTemizle;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarKayitlariGoster;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarGuncelle;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarSil;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlar;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarDil;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilTurkce;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilIngilizce;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarGuncellemeleriDenetle;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarTema;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardım;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimLisansAnahtari;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimHakkinda;
        private System.Windows.Forms.ToolStrip TlStrip;
        private System.Windows.Forms.ToolStripLabel TlStripAcıklama;
        private System.Windows.Forms.ToolStripLabel TlStripTarihSaat;
        private System.Windows.Forms.DataGridView DtGridViewKayitlariGoster;
        private System.Windows.Forms.Button BttnSil;
        private System.Windows.Forms.Button BttnYazdir;
        private System.Windows.Forms.Timer TimerTarihSaat;
        private System.Windows.Forms.GroupBox GrpBoxArama;
        private System.Windows.Forms.RadioButton RadioBttnMusteriIsmineGoreAra;
        private System.Windows.Forms.RadioButton RadioBttnNoyaGoreAra;
        private System.Windows.Forms.Button BttnBul;
        private System.Windows.Forms.TextBox TxtArama;
    }
}