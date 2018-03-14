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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitlariGoster));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TlStrpMenuItemAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAraclarSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarDil = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemDilIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemAyarlarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimLisansAnahtari = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemYardimHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrpMenuItemBaskiOnizleme = new System.Windows.Forms.ToolStripMenuItem();
            this.TlStrip = new System.Windows.Forms.ToolStrip();
            this.TlStripAcıklama = new System.Windows.Forms.ToolStripLabel();
            this.TlStripTarihSaat = new System.Windows.Forms.ToolStripLabel();
            this.DtGridViewKayitlariGoster = new System.Windows.Forms.DataGridView();
            this.BttnSil = new System.Windows.Forms.Button();
            this.BttnYazdir = new System.Windows.Forms.Button();
            this.TimerTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.GrpBoxArama = new System.Windows.Forms.GroupBox();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.RadioBttnMusteriIsmineGoreAra = new System.Windows.Forms.RadioButton();
            this.RadioBttnFormNoyaGoreAra = new System.Windows.Forms.RadioButton();
            this.PrntBelge = new System.Drawing.Printing.PrintDocument();
            this.PrntBaskiOnizleme = new System.Windows.Forms.PrintPreviewDialog();
            this.MenuStrip.SuspendLayout();
            this.TlStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridViewKayitlariGoster)).BeginInit();
            this.GrpBoxArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAraclar,
            this.TlStrpMenuItemAyarlar,
            this.TlStrpMenuItemYardım,
            this.TlStrpMenuItemBaskiOnizleme});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(924, 24);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // TlStrpMenuItemAraclar
            // 
            this.TlStrpMenuItemAraclar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAraclarYeniKayit,
            this.TlStrpMenuItemAraclarGuncelle,
            this.TlStrpMenuItemAraclarSil});
            this.TlStrpMenuItemAraclar.Name = "TlStrpMenuItemAraclar";
            this.TlStrpMenuItemAraclar.Size = new System.Drawing.Size(68, 20);
            this.TlStrpMenuItemAraclar.Text = "Araçlar";
            // 
            // TlStrpMenuItemAraclarYeniKayit
            // 
            this.TlStrpMenuItemAraclarYeniKayit.Name = "TlStrpMenuItemAraclarYeniKayit";
            this.TlStrpMenuItemAraclarYeniKayit.Size = new System.Drawing.Size(144, 22);
            this.TlStrpMenuItemAraclarYeniKayit.Text = "Yeni Kayıt";
            this.TlStrpMenuItemAraclarYeniKayit.Click += new System.EventHandler(this.TlStrpMenuItemAraclarYeniKayit_Click);
            this.TlStrpMenuItemAraclarYeniKayit.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemAraclarYeniKayit.MouseHover += new System.EventHandler(this.TlStrpMenuItemAraclarYeniKayit_MouseHover);
            // 
            // TlStrpMenuItemAraclarGuncelle
            // 
            this.TlStrpMenuItemAraclarGuncelle.Name = "TlStrpMenuItemAraclarGuncelle";
            this.TlStrpMenuItemAraclarGuncelle.Size = new System.Drawing.Size(144, 22);
            this.TlStrpMenuItemAraclarGuncelle.Text = "Güncelle";
            this.TlStrpMenuItemAraclarGuncelle.Click += new System.EventHandler(this.TlStrpMenuItemAraclarGuncelle_Click);
            this.TlStrpMenuItemAraclarGuncelle.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemAraclarGuncelle.MouseHover += new System.EventHandler(this.TlStrpMenuItemAraclarGuncelle_MouseHover);
            // 
            // TlStrpMenuItemAraclarSil
            // 
            this.TlStrpMenuItemAraclarSil.Name = "TlStrpMenuItemAraclarSil";
            this.TlStrpMenuItemAraclarSil.Size = new System.Drawing.Size(144, 22);
            this.TlStrpMenuItemAraclarSil.Text = "Sil";
            this.TlStrpMenuItemAraclarSil.Click += new System.EventHandler(this.BttnSil_Click);
            this.TlStrpMenuItemAraclarSil.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemAraclarSil.MouseHover += new System.EventHandler(this.TlStrpMenuItemAraclarSil_MouseHover);
            // 
            // TlStrpMenuItemAyarlar
            // 
            this.TlStrpMenuItemAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemAyarlarDil,
            this.TlStrpMenuItemAyarlarTema});
            this.TlStrpMenuItemAyarlar.Name = "TlStrpMenuItemAyarlar";
            this.TlStrpMenuItemAyarlar.Size = new System.Drawing.Size(68, 20);
            this.TlStrpMenuItemAyarlar.Text = "Ayarlar";
            // 
            // TlStrpMenuItemAyarlarDil
            // 
            this.TlStrpMenuItemAyarlarDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemDilTurkce,
            this.TlStrpMenuItemDilIngilizce});
            this.TlStrpMenuItemAyarlarDil.Name = "TlStrpMenuItemAyarlarDil";
            this.TlStrpMenuItemAyarlarDil.Size = new System.Drawing.Size(102, 22);
            this.TlStrpMenuItemAyarlarDil.Text = "Dil";
            this.TlStrpMenuItemAyarlarDil.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemAyarlarDil.MouseHover += new System.EventHandler(this.TlStrpMenuItemAyarlarDil_MouseHover);
            // 
            // TlStrpMenuItemDilTurkce
            // 
            this.TlStrpMenuItemDilTurkce.Name = "TlStrpMenuItemDilTurkce";
            this.TlStrpMenuItemDilTurkce.Size = new System.Drawing.Size(137, 22);
            this.TlStrpMenuItemDilTurkce.Text = "Tükçe";
            this.TlStrpMenuItemDilTurkce.Click += new System.EventHandler(this.TlStrpMenuItemDilTurkce_Click);
            // 
            // TlStrpMenuItemDilIngilizce
            // 
            this.TlStrpMenuItemDilIngilizce.Name = "TlStrpMenuItemDilIngilizce";
            this.TlStrpMenuItemDilIngilizce.Size = new System.Drawing.Size(137, 22);
            this.TlStrpMenuItemDilIngilizce.Text = "İngilizce";
            this.TlStrpMenuItemDilIngilizce.Click += new System.EventHandler(this.TlStrpMenuItemDilIngilizce_Click);
            // 
            // TlStrpMenuItemAyarlarTema
            // 
            this.TlStrpMenuItemAyarlarTema.Name = "TlStrpMenuItemAyarlarTema";
            this.TlStrpMenuItemAyarlarTema.Size = new System.Drawing.Size(102, 22);
            this.TlStrpMenuItemAyarlarTema.Text = "Tema";
            this.TlStrpMenuItemAyarlarTema.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemAyarlarTema.MouseHover += new System.EventHandler(this.TlStrpMenuItemAyarlarTema_MouseHover);
            // 
            // TlStrpMenuItemYardım
            // 
            this.TlStrpMenuItemYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMenuItemYardimLisansAnahtari,
            this.TlStrpMenuItemYardimHakkinda});
            this.TlStrpMenuItemYardım.Name = "TlStrpMenuItemYardım";
            this.TlStrpMenuItemYardım.Size = new System.Drawing.Size(61, 20);
            this.TlStrpMenuItemYardım.Text = "Yardım";
            // 
            // TlStrpMenuItemYardimLisansAnahtari
            // 
            this.TlStrpMenuItemYardimLisansAnahtari.Name = "TlStrpMenuItemYardimLisansAnahtari";
            this.TlStrpMenuItemYardimLisansAnahtari.Size = new System.Drawing.Size(179, 22);
            this.TlStrpMenuItemYardimLisansAnahtari.Text = "Lisans Anahtarı";
            this.TlStrpMenuItemYardimLisansAnahtari.Click += new System.EventHandler(this.TlStrpMenuItemYardimLisansAnahtari_Click);
            this.TlStrpMenuItemYardimLisansAnahtari.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemYardimLisansAnahtari.MouseHover += new System.EventHandler(this.TlStrpMenuItemYardimLisansAnahtari_MouseHover);
            // 
            // TlStrpMenuItemYardimHakkinda
            // 
            this.TlStrpMenuItemYardimHakkinda.Name = "TlStrpMenuItemYardimHakkinda";
            this.TlStrpMenuItemYardimHakkinda.Size = new System.Drawing.Size(179, 22);
            this.TlStrpMenuItemYardimHakkinda.Text = "Hakkında";
            this.TlStrpMenuItemYardimHakkinda.Click += new System.EventHandler(this.TlStrpMenuItemYardimHakkinda_Click);
            this.TlStrpMenuItemYardimHakkinda.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.TlStrpMenuItemYardimHakkinda.MouseHover += new System.EventHandler(this.TlStrpMenuItemYardimHakkinda_MouseHover);
            // 
            // TlStrpMenuItemBaskiOnizleme
            // 
            this.TlStrpMenuItemBaskiOnizleme.Name = "TlStrpMenuItemBaskiOnizleme";
            this.TlStrpMenuItemBaskiOnizleme.Size = new System.Drawing.Size(117, 20);
            this.TlStrpMenuItemBaskiOnizleme.Text = "Baskı Önizleme";
            this.TlStrpMenuItemBaskiOnizleme.Click += new System.EventHandler(this.TlStrpMenuItemBaskiOnizleme_Click);
            // 
            // TlStrip
            // 
            this.TlStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlStrip.Font = new System.Drawing.Font("Consolas", 9.75F);
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
            this.TlStripAcıklama.Size = new System.Drawing.Size(63, 22);
            this.TlStripAcıklama.Text = "Açıklama";
            // 
            // TlStripTarihSaat
            // 
            this.TlStripTarihSaat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TlStripTarihSaat.Name = "TlStripTarihSaat";
            this.TlStripTarihSaat.Size = new System.Drawing.Size(98, 22);
            this.TlStripTarihSaat.Text = "Tarih ve Saat";
            // 
            // DtGridViewKayitlariGoster
            // 
            this.DtGridViewKayitlariGoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DtGridViewKayitlariGoster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtGridViewKayitlariGoster.Location = new System.Drawing.Point(12, 29);
            this.DtGridViewKayitlariGoster.MultiSelect = false;
            this.DtGridViewKayitlariGoster.Name = "DtGridViewKayitlariGoster";
            this.DtGridViewKayitlariGoster.ReadOnly = true;
            this.DtGridViewKayitlariGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGridViewKayitlariGoster.Size = new System.Drawing.Size(900, 349);
            this.DtGridViewKayitlariGoster.TabIndex = 18;
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
            this.BttnSil.Click += new System.EventHandler(this.BttnSil_Click);
            this.BttnSil.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.BttnSil.MouseHover += new System.EventHandler(this.BttnSil_MouseHover);
            // 
            // BttnYazdir
            // 
            this.BttnYazdir.Location = new System.Drawing.Point(147, 398);
            this.BttnYazdir.Name = "BttnYazdir";
            this.BttnYazdir.Size = new System.Drawing.Size(128, 45);
            this.BttnYazdir.TabIndex = 28;
            this.BttnYazdir.Text = "Yazdır";
            this.BttnYazdir.UseVisualStyleBackColor = true;
            this.BttnYazdir.Click += new System.EventHandler(this.BttnYazdir_Click);
            this.BttnYazdir.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.BttnYazdir.MouseHover += new System.EventHandler(this.BttnYazdir_MouseHover);
            // 
            // TimerTarihSaat
            // 
            this.TimerTarihSaat.Tick += new System.EventHandler(this.TimerTarihSaat_Tick);
            // 
            // GrpBoxArama
            // 
            this.GrpBoxArama.Controls.Add(this.TxtArama);
            this.GrpBoxArama.Controls.Add(this.RadioBttnMusteriIsmineGoreAra);
            this.GrpBoxArama.Controls.Add(this.RadioBttnFormNoyaGoreAra);
            this.GrpBoxArama.Location = new System.Drawing.Point(281, 384);
            this.GrpBoxArama.Name = "GrpBoxArama";
            this.GrpBoxArama.Size = new System.Drawing.Size(631, 62);
            this.GrpBoxArama.TabIndex = 29;
            this.GrpBoxArama.TabStop = false;
            this.GrpBoxArama.Text = "Arama";
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(239, 24);
            this.TxtArama.MaxLength = 30;
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.ReadOnly = true;
            this.TxtArama.Size = new System.Drawing.Size(352, 25);
            this.TxtArama.TabIndex = 16;
            this.TxtArama.TextChanged += new System.EventHandler(this.TxtArama_TextChanged);
            // 
            // RadioBttnMusteriIsmineGoreAra
            // 
            this.RadioBttnMusteriIsmineGoreAra.AutoSize = true;
            this.RadioBttnMusteriIsmineGoreAra.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.RadioBttnMusteriIsmineGoreAra.Location = new System.Drawing.Point(4, 36);
            this.RadioBttnMusteriIsmineGoreAra.Name = "RadioBttnMusteriIsmineGoreAra";
            this.RadioBttnMusteriIsmineGoreAra.Size = new System.Drawing.Size(165, 19);
            this.RadioBttnMusteriIsmineGoreAra.TabIndex = 1;
            this.RadioBttnMusteriIsmineGoreAra.TabStop = true;
            this.RadioBttnMusteriIsmineGoreAra.Text = "Müşteri isimine göre";
            this.RadioBttnMusteriIsmineGoreAra.UseVisualStyleBackColor = true;
            this.RadioBttnMusteriIsmineGoreAra.CheckedChanged += new System.EventHandler(this.RadioBttnFormNoyaGoreAra_CheckedChanged);
            this.RadioBttnMusteriIsmineGoreAra.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.RadioBttnMusteriIsmineGoreAra.MouseHover += new System.EventHandler(this.RadioBttnMusteriIsmineGoreAra_MouseHover);
            // 
            // RadioBttnFormNoyaGoreAra
            // 
            this.RadioBttnFormNoyaGoreAra.AutoSize = true;
            this.RadioBttnFormNoyaGoreAra.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.RadioBttnFormNoyaGoreAra.Location = new System.Drawing.Point(4, 16);
            this.RadioBttnFormNoyaGoreAra.Name = "RadioBttnFormNoyaGoreAra";
            this.RadioBttnFormNoyaGoreAra.Size = new System.Drawing.Size(144, 19);
            this.RadioBttnFormNoyaGoreAra.TabIndex = 0;
            this.RadioBttnFormNoyaGoreAra.TabStop = true;
            this.RadioBttnFormNoyaGoreAra.Text = "Form no\'suna göre";
            this.RadioBttnFormNoyaGoreAra.UseVisualStyleBackColor = true;
            this.RadioBttnFormNoyaGoreAra.CheckedChanged += new System.EventHandler(this.RadioBttnFormNoyaGoreAra_CheckedChanged);
            this.RadioBttnFormNoyaGoreAra.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
            this.RadioBttnFormNoyaGoreAra.MouseHover += new System.EventHandler(this.RadioBttnFormNoyaGoreAra_MouseHover);
            // 
            // PrntBelge
            // 
            this.PrntBelge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrntBelge_PrintPage);
            // 
            // PrntBaskiOnizleme
            // 
            this.PrntBaskiOnizleme.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrntBaskiOnizleme.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrntBaskiOnizleme.ClientSize = new System.Drawing.Size(400, 300);
            this.PrntBaskiOnizleme.Document = this.PrntBelge;
            this.PrntBaskiOnizleme.Enabled = true;
            this.PrntBaskiOnizleme.Icon = ((System.Drawing.Icon)(resources.GetObject("PrntBaskiOnizleme.Icon")));
            this.PrntBaskiOnizleme.Name = "PrntBaskiOnizleme";
            this.PrntBaskiOnizleme.Visible = false;
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
            this.Text = "RabtBil Müşteri Kayit -> Kayıtları Göster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKayitlariGoster_FormClosing);
            this.Load += new System.EventHandler(this.FrmKayitlariGoster_Load);
            this.MouseLeave += new System.EventHandler(this.VarsayilanAciklama);
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

        public System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclar;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarYeniKayit;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarGuncelle;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarSil;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlar;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarDil;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilTurkce;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilIngilizce;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarTema;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardım;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimLisansAnahtari;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimHakkinda;
        public System.Windows.Forms.ToolStrip TlStrip;
        public System.Windows.Forms.ToolStripLabel TlStripAcıklama;
        public System.Windows.Forms.ToolStripLabel TlStripTarihSaat;
        public System.Windows.Forms.DataGridView DtGridViewKayitlariGoster;
        public System.Windows.Forms.Button BttnSil;
        public System.Windows.Forms.Button BttnYazdir;
        public System.Windows.Forms.Timer TimerTarihSaat;
        public System.Windows.Forms.GroupBox GrpBoxArama;
        public System.Windows.Forms.RadioButton RadioBttnMusteriIsmineGoreAra;
        public System.Windows.Forms.RadioButton RadioBttnFormNoyaGoreAra;
        public System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemBaskiOnizleme;
        private System.Drawing.Printing.PrintDocument PrntBelge;
        private System.Windows.Forms.PrintPreviewDialog PrntBaskiOnizleme;
    }
}