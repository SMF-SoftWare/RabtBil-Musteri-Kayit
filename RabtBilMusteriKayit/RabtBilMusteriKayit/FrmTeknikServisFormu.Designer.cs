﻿namespace RabtBilMusteriKayit
{
    partial class FrmTeknikServisFormu
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
            this.LblMusteriAdi = new System.Windows.Forms.Label();
            this.TxtMusteriAdi = new System.Windows.Forms.TextBox();
            this.GrpBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.LblFormNo = new System.Windows.Forms.Label();
            this.TxtFormNo = new System.Windows.Forms.TextBox();
            this.GrpBoxAksesuarlar = new System.Windows.Forms.GroupBox();
            this.TxtAksesuarlar = new System.Windows.Forms.TextBox();
            this.GrpBoxEkBilgiler = new System.Windows.Forms.GroupBox();
            this.TxtEkBilgiler = new System.Windows.Forms.TextBox();
            this.GrpBoxUrunBilgileri = new System.Windows.Forms.GroupBox();
            this.BttnQrKoduOlustur = new System.Windows.Forms.Button();
            this.LblUcret = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.PcTrBoxMusteriQrKodu = new System.Windows.Forms.PictureBox();
            this.LblMusteriQrKodu = new System.Windows.Forms.Label();
            this.LblUrunTakipNo = new System.Windows.Forms.Label();
            this.TxtUrunTakipNo = new System.Windows.Forms.TextBox();
            this.LblUrunDurumu = new System.Windows.Forms.Label();
            this.TxtUrunDurumu = new System.Windows.Forms.TextBox();
            this.LblArizaTanimi = new System.Windows.Forms.Label();
            this.TxtArizaTanimi = new System.Windows.Forms.TextBox();
            this.CmbBoxUrunKodlari = new System.Windows.Forms.ComboBox();
            this.TxtUrunKodlari = new System.Windows.Forms.TextBox();
            this.LblUrunModeli = new System.Windows.Forms.Label();
            this.TxtUrunModeli = new System.Windows.Forms.TextBox();
            this.BttnYeniKayit = new System.Windows.Forms.Button();
            this.BttnKaydet = new System.Windows.Forms.Button();
            this.BttnTemizle = new System.Windows.Forms.Button();
            this.BttnKayitlariGoster = new System.Windows.Forms.Button();
            this.BttnGuncelle = new System.Windows.Forms.Button();
            this.PcTrBoxProfiliDuzenle = new System.Windows.Forms.PictureBox();
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
            this.TimerTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.LblMusteriNo = new System.Windows.Forms.Label();
            this.GrpBoxMusteriBilgileri.SuspendLayout();
            this.GrpBoxAksesuarlar.SuspendLayout();
            this.GrpBoxEkBilgiler.SuspendLayout();
            this.GrpBoxUrunBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxMusteriQrKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxProfiliDuzenle)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.TlStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMusteriAdi
            // 
            this.LblMusteriAdi.AutoSize = true;
            this.LblMusteriAdi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMusteriAdi.Location = new System.Drawing.Point(4, 34);
            this.LblMusteriAdi.Name = "LblMusteriAdi";
            this.LblMusteriAdi.Size = new System.Drawing.Size(91, 15);
            this.LblMusteriAdi.TabIndex = 1;
            this.LblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // TxtMusteriAdi
            // 
            this.TxtMusteriAdi.Location = new System.Drawing.Point(96, 27);
            this.TxtMusteriAdi.MaxLength = 30;
            this.TxtMusteriAdi.Name = "TxtMusteriAdi";
            this.TxtMusteriAdi.Size = new System.Drawing.Size(252, 25);
            this.TxtMusteriAdi.TabIndex = 0;
            // 
            // GrpBoxMusteriBilgileri
            // 
            this.GrpBoxMusteriBilgileri.Controls.Add(this.LblTelefon);
            this.GrpBoxMusteriBilgileri.Controls.Add(this.TxtTelefon);
            this.GrpBoxMusteriBilgileri.Controls.Add(this.LblFormNo);
            this.GrpBoxMusteriBilgileri.Controls.Add(this.TxtFormNo);
            this.GrpBoxMusteriBilgileri.Controls.Add(this.LblMusteriAdi);
            this.GrpBoxMusteriBilgileri.Controls.Add(this.TxtMusteriAdi);
            this.GrpBoxMusteriBilgileri.Location = new System.Drawing.Point(12, 29);
            this.GrpBoxMusteriBilgileri.Name = "GrpBoxMusteriBilgileri";
            this.GrpBoxMusteriBilgileri.Size = new System.Drawing.Size(360, 131);
            this.GrpBoxMusteriBilgileri.TabIndex = 3;
            this.GrpBoxMusteriBilgileri.TabStop = false;
            this.GrpBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTelefon.Location = new System.Drawing.Point(30, 96);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(63, 15);
            this.LblTelefon.TabIndex = 5;
            this.LblTelefon.Text = "Telefon:";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(96, 89);
            this.TxtTelefon.MaxLength = 16;
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(252, 25);
            this.TxtTelefon.TabIndex = 4;
            // 
            // LblFormNo
            // 
            this.LblFormNo.AutoSize = true;
            this.LblFormNo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFormNo.Location = new System.Drawing.Point(23, 65);
            this.LblFormNo.Name = "LblFormNo";
            this.LblFormNo.Size = new System.Drawing.Size(63, 15);
            this.LblFormNo.TabIndex = 3;
            this.LblFormNo.Text = "Form No:";
            // 
            // TxtFormNo
            // 
            this.TxtFormNo.Location = new System.Drawing.Point(96, 58);
            this.TxtFormNo.MaxLength = 30;
            this.TxtFormNo.Name = "TxtFormNo";
            this.TxtFormNo.Size = new System.Drawing.Size(252, 25);
            this.TxtFormNo.TabIndex = 2;
            // 
            // GrpBoxAksesuarlar
            // 
            this.GrpBoxAksesuarlar.Controls.Add(this.TxtAksesuarlar);
            this.GrpBoxAksesuarlar.Location = new System.Drawing.Point(12, 166);
            this.GrpBoxAksesuarlar.Name = "GrpBoxAksesuarlar";
            this.GrpBoxAksesuarlar.Size = new System.Drawing.Size(360, 137);
            this.GrpBoxAksesuarlar.TabIndex = 6;
            this.GrpBoxAksesuarlar.TabStop = false;
            this.GrpBoxAksesuarlar.Text = "Aksesuarlar";
            // 
            // TxtAksesuarlar
            // 
            this.TxtAksesuarlar.Location = new System.Drawing.Point(6, 21);
            this.TxtAksesuarlar.MaxLength = 210;
            this.TxtAksesuarlar.Multiline = true;
            this.TxtAksesuarlar.Name = "TxtAksesuarlar";
            this.TxtAksesuarlar.Size = new System.Drawing.Size(350, 110);
            this.TxtAksesuarlar.TabIndex = 20;
            // 
            // GrpBoxEkBilgiler
            // 
            this.GrpBoxEkBilgiler.Controls.Add(this.TxtEkBilgiler);
            this.GrpBoxEkBilgiler.Location = new System.Drawing.Point(12, 309);
            this.GrpBoxEkBilgiler.Name = "GrpBoxEkBilgiler";
            this.GrpBoxEkBilgiler.Size = new System.Drawing.Size(360, 137);
            this.GrpBoxEkBilgiler.TabIndex = 7;
            this.GrpBoxEkBilgiler.TabStop = false;
            this.GrpBoxEkBilgiler.Text = "Ek Bilgiler";
            // 
            // TxtEkBilgiler
            // 
            this.TxtEkBilgiler.Location = new System.Drawing.Point(6, 21);
            this.TxtEkBilgiler.MaxLength = 210;
            this.TxtEkBilgiler.Multiline = true;
            this.TxtEkBilgiler.Name = "TxtEkBilgiler";
            this.TxtEkBilgiler.Size = new System.Drawing.Size(350, 110);
            this.TxtEkBilgiler.TabIndex = 22;
            // 
            // GrpBoxUrunBilgileri
            // 
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblMusteriNo);
            this.GrpBoxUrunBilgileri.Controls.Add(this.BttnQrKoduOlustur);
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblUcret);
            this.GrpBoxUrunBilgileri.Controls.Add(this.TxtUcret);
            this.GrpBoxUrunBilgileri.Controls.Add(this.PcTrBoxMusteriQrKodu);
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblMusteriQrKodu);
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblUrunTakipNo);
            this.GrpBoxUrunBilgileri.Controls.Add(this.TxtUrunTakipNo);
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblUrunDurumu);
            this.GrpBoxUrunBilgileri.Controls.Add(this.TxtUrunDurumu);
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblArizaTanimi);
            this.GrpBoxUrunBilgileri.Controls.Add(this.TxtArizaTanimi);
            this.GrpBoxUrunBilgileri.Controls.Add(this.CmbBoxUrunKodlari);
            this.GrpBoxUrunBilgileri.Controls.Add(this.TxtUrunKodlari);
            this.GrpBoxUrunBilgileri.Controls.Add(this.LblUrunModeli);
            this.GrpBoxUrunBilgileri.Controls.Add(this.TxtUrunModeli);
            this.GrpBoxUrunBilgileri.Location = new System.Drawing.Point(378, 29);
            this.GrpBoxUrunBilgileri.Name = "GrpBoxUrunBilgileri";
            this.GrpBoxUrunBilgileri.Size = new System.Drawing.Size(397, 417);
            this.GrpBoxUrunBilgileri.TabIndex = 8;
            this.GrpBoxUrunBilgileri.TabStop = false;
            this.GrpBoxUrunBilgileri.Text = "Ürün Bilgileri";
            // 
            // BttnQrKoduOlustur
            // 
            this.BttnQrKoduOlustur.Location = new System.Drawing.Point(11, 287);
            this.BttnQrKoduOlustur.Name = "BttnQrKoduOlustur";
            this.BttnQrKoduOlustur.Size = new System.Drawing.Size(128, 45);
            this.BttnQrKoduOlustur.TabIndex = 18;
            this.BttnQrKoduOlustur.Text = "Qr Kodunu Oluştur";
            this.BttnQrKoduOlustur.UseVisualStyleBackColor = true;
            this.BttnQrKoduOlustur.Click += new System.EventHandler(this.BttnQrKoduOlustur_Click);
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUcret.Location = new System.Drawing.Point(87, 370);
            this.LblUcret.Name = "LblUcret";
            this.LblUcret.Size = new System.Drawing.Size(49, 15);
            this.LblUcret.TabIndex = 17;
            this.LblUcret.Text = "Ücret:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(139, 363);
            this.TxtUcret.MaxLength = 30;
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(146, 25);
            this.TxtUcret.TabIndex = 24;
            // 
            // PcTrBoxMusteriQrKodu
            // 
            this.PcTrBoxMusteriQrKodu.Location = new System.Drawing.Point(139, 267);
            this.PcTrBoxMusteriQrKodu.MaximumSize = new System.Drawing.Size(250, 90);
            this.PcTrBoxMusteriQrKodu.MinimumSize = new System.Drawing.Size(250, 90);
            this.PcTrBoxMusteriQrKodu.Name = "PcTrBoxMusteriQrKodu";
            this.PcTrBoxMusteriQrKodu.Size = new System.Drawing.Size(250, 90);
            this.PcTrBoxMusteriQrKodu.TabIndex = 14;
            this.PcTrBoxMusteriQrKodu.TabStop = false;
            // 
            // LblMusteriQrKodu
            // 
            this.LblMusteriQrKodu.AutoSize = true;
            this.LblMusteriQrKodu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMusteriQrKodu.Location = new System.Drawing.Point(17, 270);
            this.LblMusteriQrKodu.Name = "LblMusteriQrKodu";
            this.LblMusteriQrKodu.Size = new System.Drawing.Size(119, 15);
            this.LblMusteriQrKodu.TabIndex = 15;
            this.LblMusteriQrKodu.Text = "Müşteri Qr Kodu:";
            // 
            // LblUrunTakipNo
            // 
            this.LblUrunTakipNo.AutoSize = true;
            this.LblUrunTakipNo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUrunTakipNo.Location = new System.Drawing.Point(31, 243);
            this.LblUrunTakipNo.Name = "LblUrunTakipNo";
            this.LblUrunTakipNo.Size = new System.Drawing.Size(105, 15);
            this.LblUrunTakipNo.TabIndex = 13;
            this.LblUrunTakipNo.Text = "Ürün Takip No:";
            // 
            // TxtUrunTakipNo
            // 
            this.TxtUrunTakipNo.Location = new System.Drawing.Point(139, 236);
            this.TxtUrunTakipNo.MaxLength = 30;
            this.TxtUrunTakipNo.Name = "TxtUrunTakipNo";
            this.TxtUrunTakipNo.ReadOnly = true;
            this.TxtUrunTakipNo.Size = new System.Drawing.Size(252, 25);
            this.TxtUrunTakipNo.TabIndex = 16;
            // 
            // LblUrunDurumu
            // 
            this.LblUrunDurumu.AutoSize = true;
            this.LblUrunDurumu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUrunDurumu.Location = new System.Drawing.Point(45, 208);
            this.LblUrunDurumu.Name = "LblUrunDurumu";
            this.LblUrunDurumu.Size = new System.Drawing.Size(91, 15);
            this.LblUrunDurumu.TabIndex = 11;
            this.LblUrunDurumu.Text = "Ürün Durumu:";
            // 
            // TxtUrunDurumu
            // 
            this.TxtUrunDurumu.Location = new System.Drawing.Point(139, 205);
            this.TxtUrunDurumu.MaxLength = 30;
            this.TxtUrunDurumu.Name = "TxtUrunDurumu";
            this.TxtUrunDurumu.Size = new System.Drawing.Size(252, 25);
            this.TxtUrunDurumu.TabIndex = 14;
            // 
            // LblArizaTanimi
            // 
            this.LblArizaTanimi.AutoSize = true;
            this.LblArizaTanimi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblArizaTanimi.Location = new System.Drawing.Point(38, 92);
            this.LblArizaTanimi.Name = "LblArizaTanimi";
            this.LblArizaTanimi.Size = new System.Drawing.Size(98, 15);
            this.LblArizaTanimi.TabIndex = 9;
            this.LblArizaTanimi.Text = "Arıza Tanımı:";
            // 
            // TxtArizaTanimi
            // 
            this.TxtArizaTanimi.Location = new System.Drawing.Point(139, 89);
            this.TxtArizaTanimi.MaxLength = 145;
            this.TxtArizaTanimi.Multiline = true;
            this.TxtArizaTanimi.Name = "TxtArizaTanimi";
            this.TxtArizaTanimi.Size = new System.Drawing.Size(252, 110);
            this.TxtArizaTanimi.TabIndex = 12;
            // 
            // CmbBoxUrunKodlari
            // 
            this.CmbBoxUrunKodlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxUrunKodlari.FormattingEnabled = true;
            this.CmbBoxUrunKodlari.Items.AddRange(new object[] {
            "",
            "Seri No",
            "Imei No",
            "Diğer"});
            this.CmbBoxUrunKodlari.Location = new System.Drawing.Point(12, 58);
            this.CmbBoxUrunKodlari.Name = "CmbBoxUrunKodlari";
            this.CmbBoxUrunKodlari.Size = new System.Drawing.Size(121, 26);
            this.CmbBoxUrunKodlari.TabIndex = 8;
            this.CmbBoxUrunKodlari.SelectedIndexChanged += new System.EventHandler(this.CmbBoxUrunKodlari_SelectedIndexChanged);
            // 
            // TxtUrunKodlari
            // 
            this.TxtUrunKodlari.Location = new System.Drawing.Point(139, 58);
            this.TxtUrunKodlari.MaxLength = 30;
            this.TxtUrunKodlari.Name = "TxtUrunKodlari";
            this.TxtUrunKodlari.ReadOnly = true;
            this.TxtUrunKodlari.Size = new System.Drawing.Size(252, 25);
            this.TxtUrunKodlari.TabIndex = 10;
            // 
            // LblUrunModeli
            // 
            this.LblUrunModeli.AutoSize = true;
            this.LblUrunModeli.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUrunModeli.Location = new System.Drawing.Point(45, 34);
            this.LblUrunModeli.Name = "LblUrunModeli";
            this.LblUrunModeli.Size = new System.Drawing.Size(91, 15);
            this.LblUrunModeli.TabIndex = 7;
            this.LblUrunModeli.Text = "Ürün Modeli:";
            // 
            // TxtUrunModeli
            // 
            this.TxtUrunModeli.Location = new System.Drawing.Point(139, 27);
            this.TxtUrunModeli.MaxLength = 30;
            this.TxtUrunModeli.Name = "TxtUrunModeli";
            this.TxtUrunModeli.Size = new System.Drawing.Size(252, 25);
            this.TxtUrunModeli.TabIndex = 6;
            // 
            // BttnYeniKayit
            // 
            this.BttnYeniKayit.Location = new System.Drawing.Point(781, 125);
            this.BttnYeniKayit.Name = "BttnYeniKayit";
            this.BttnYeniKayit.Size = new System.Drawing.Size(128, 45);
            this.BttnYeniKayit.TabIndex = 26;
            this.BttnYeniKayit.Text = "Yeni Kayıt";
            this.BttnYeniKayit.UseVisualStyleBackColor = true;
            this.BttnYeniKayit.Click += new System.EventHandler(this.BttnYeniKayit_Click);
            // 
            // BttnKaydet
            // 
            this.BttnKaydet.Location = new System.Drawing.Point(781, 173);
            this.BttnKaydet.Name = "BttnKaydet";
            this.BttnKaydet.Size = new System.Drawing.Size(128, 45);
            this.BttnKaydet.TabIndex = 28;
            this.BttnKaydet.Text = "Kaydet";
            this.BttnKaydet.UseVisualStyleBackColor = true;
            this.BttnKaydet.Click += new System.EventHandler(this.BttnKaydet_Click);
            // 
            // BttnTemizle
            // 
            this.BttnTemizle.Location = new System.Drawing.Point(781, 225);
            this.BttnTemizle.Name = "BttnTemizle";
            this.BttnTemizle.Size = new System.Drawing.Size(128, 45);
            this.BttnTemizle.TabIndex = 30;
            this.BttnTemizle.Text = "Temizle";
            this.BttnTemizle.UseVisualStyleBackColor = true;
            this.BttnTemizle.Click += new System.EventHandler(this.BttnTemizle_Click);
            // 
            // BttnKayitlariGoster
            // 
            this.BttnKayitlariGoster.Location = new System.Drawing.Point(781, 273);
            this.BttnKayitlariGoster.Name = "BttnKayitlariGoster";
            this.BttnKayitlariGoster.Size = new System.Drawing.Size(128, 45);
            this.BttnKayitlariGoster.TabIndex = 32;
            this.BttnKayitlariGoster.Text = "Kayıtları Göster";
            this.BttnKayitlariGoster.UseVisualStyleBackColor = true;
            this.BttnKayitlariGoster.Click += new System.EventHandler(this.BttnKayitlariGoster_Click);
            // 
            // BttnGuncelle
            // 
            this.BttnGuncelle.Location = new System.Drawing.Point(781, 324);
            this.BttnGuncelle.Name = "BttnGuncelle";
            this.BttnGuncelle.Size = new System.Drawing.Size(128, 45);
            this.BttnGuncelle.TabIndex = 34;
            this.BttnGuncelle.Text = "Güncelle";
            this.BttnGuncelle.UseVisualStyleBackColor = true;
            this.BttnGuncelle.Click += new System.EventHandler(this.BttnGuncelle_Click);
            // 
            // PcTrBoxProfiliDuzenle
            // 
            this.PcTrBoxProfiliDuzenle.Location = new System.Drawing.Point(804, 39);
            this.PcTrBoxProfiliDuzenle.Name = "PcTrBoxProfiliDuzenle";
            this.PcTrBoxProfiliDuzenle.Size = new System.Drawing.Size(80, 80);
            this.PcTrBoxProfiliDuzenle.TabIndex = 14;
            this.PcTrBoxProfiliDuzenle.TabStop = false;
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
            this.MenuStrip.TabIndex = 15;
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
            this.TlStrip.TabIndex = 16;
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
            // TimerTarihSaat
            // 
            this.TimerTarihSaat.Tick += new System.EventHandler(this.TimerTarihSaat_Tick);
            // 
            // LblMusteriNo
            // 
            this.LblMusteriNo.AutoSize = true;
            this.LblMusteriNo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMusteriNo.Location = new System.Drawing.Point(224, 396);
            this.LblMusteriNo.Name = "LblMusteriNo";
            this.LblMusteriNo.Size = new System.Drawing.Size(70, 15);
            this.LblMusteriNo.TabIndex = 25;
            this.LblMusteriNo.Text = "MüşteriNo";
            this.LblMusteriNo.Visible = false;
            // 
            // FrmTeknikServisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 476);
            this.Controls.Add(this.TlStrip);
            this.Controls.Add(this.PcTrBoxProfiliDuzenle);
            this.Controls.Add(this.BttnGuncelle);
            this.Controls.Add(this.BttnKayitlariGoster);
            this.Controls.Add(this.BttnTemizle);
            this.Controls.Add(this.BttnKaydet);
            this.Controls.Add(this.BttnYeniKayit);
            this.Controls.Add(this.GrpBoxUrunBilgileri);
            this.Controls.Add(this.GrpBoxEkBilgiler);
            this.Controls.Add(this.GrpBoxAksesuarlar);
            this.Controls.Add(this.GrpBoxMusteriBilgileri);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 515);
            this.MinimumSize = new System.Drawing.Size(940, 515);
            this.Name = "FrmTeknikServisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabtBil Kayıt -> Teknik Servis Formu";
            this.Load += new System.EventHandler(this.FrmTeknikServisFormu_Load);
            this.GrpBoxMusteriBilgileri.ResumeLayout(false);
            this.GrpBoxMusteriBilgileri.PerformLayout();
            this.GrpBoxAksesuarlar.ResumeLayout(false);
            this.GrpBoxAksesuarlar.PerformLayout();
            this.GrpBoxEkBilgiler.ResumeLayout(false);
            this.GrpBoxEkBilgiler.PerformLayout();
            this.GrpBoxUrunBilgileri.ResumeLayout(false);
            this.GrpBoxUrunBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxMusteriQrKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxProfiliDuzenle)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TlStrip.ResumeLayout(false);
            this.TlStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtMusteriAdi;
        public System.Windows.Forms.GroupBox GrpBoxMusteriBilgileri;
        public System.Windows.Forms.Label LblTelefon;
        public System.Windows.Forms.TextBox TxtTelefon;
        public System.Windows.Forms.Label LblFormNo;
        public System.Windows.Forms.TextBox TxtFormNo;
        public System.Windows.Forms.GroupBox GrpBoxAksesuarlar;
        public System.Windows.Forms.GroupBox GrpBoxEkBilgiler;
        public System.Windows.Forms.TextBox TxtEkBilgiler;
        public System.Windows.Forms.GroupBox GrpBoxUrunBilgileri;
        public System.Windows.Forms.Label LblUcret;
        public System.Windows.Forms.TextBox TxtUcret;
        public System.Windows.Forms.PictureBox PcTrBoxMusteriQrKodu;
        public System.Windows.Forms.Label LblMusteriQrKodu;
        public System.Windows.Forms.Label LblUrunTakipNo;
        public System.Windows.Forms.TextBox TxtUrunTakipNo;
        public System.Windows.Forms.Label LblUrunDurumu;
        public System.Windows.Forms.TextBox TxtUrunDurumu;
        public System.Windows.Forms.Label LblArizaTanimi;
        public System.Windows.Forms.ComboBox CmbBoxUrunKodlari;
        public System.Windows.Forms.TextBox TxtUrunKodlari;
        public System.Windows.Forms.Label LblUrunModeli;
        public System.Windows.Forms.TextBox TxtUrunModeli;
        public System.Windows.Forms.Button BttnYeniKayit;
        public System.Windows.Forms.Button BttnKaydet;
        public System.Windows.Forms.Button BttnTemizle;
        public System.Windows.Forms.Button BttnKayitlariGoster;
        public System.Windows.Forms.Button BttnGuncelle;
        public System.Windows.Forms.PictureBox PcTrBoxProfiliDuzenle;
        public System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclar;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarYeniKayit;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarKaydet;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarTemizle;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarKayitlariGoster;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarGuncelle;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlar;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarDil;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilTurkce;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemDilIngilizce;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarGuncellemeleriDenetle;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAyarlarTema;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardım;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimLisansAnahtari;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemYardimHakkinda;
        public System.Windows.Forms.Label LblMusteriAdi;
        public System.Windows.Forms.Button BttnQrKoduOlustur;
        public System.Windows.Forms.ToolStrip TlStrip;
        public System.Windows.Forms.ToolStripLabel TlStripAcıklama;
        public System.Windows.Forms.ToolStripLabel TlStripTarihSaat;
        public System.Windows.Forms.Timer TimerTarihSaat;
        public System.Windows.Forms.ToolStripMenuItem TlStrpMenuItemAraclarSil;
        public System.Windows.Forms.TextBox TxtAksesuarlar;
        public System.Windows.Forms.TextBox TxtArizaTanimi;
        public System.Windows.Forms.Label LblMusteriNo;
    }
}