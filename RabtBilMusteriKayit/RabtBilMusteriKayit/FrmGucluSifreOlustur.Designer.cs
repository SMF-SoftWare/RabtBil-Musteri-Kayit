namespace RabtBilMusteriKayit
{
    partial class FrmGucluSifreOlustur
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
            this.ChckBoxKucukHarfler = new System.Windows.Forms.CheckBox();
            this.ChckBoxBuyukHarfler = new System.Windows.Forms.CheckBox();
            this.ChckBoxSayılar = new System.Windows.Forms.CheckBox();
            this.ChckBoxSemboller = new System.Windows.Forms.CheckBox();
            this.TxtGucluSifreniz = new System.Windows.Forms.TextBox();
            this.BttnKopyala = new System.Windows.Forms.Button();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.lblGucluSifreniz = new System.Windows.Forms.Label();
            this.TrckBarSifreKarakter = new System.Windows.Forms.TrackBar();
            this.lblSifreUzunluguDeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrckBarSifreKarakter)).BeginInit();
            this.SuspendLayout();
            // 
            // ChckBoxKucukHarfler
            // 
            this.ChckBoxKucukHarfler.AutoSize = true;
            this.ChckBoxKucukHarfler.Location = new System.Drawing.Point(293, 12);
            this.ChckBoxKucukHarfler.Name = "ChckBoxKucukHarfler";
            this.ChckBoxKucukHarfler.Size = new System.Drawing.Size(162, 26);
            this.ChckBoxKucukHarfler.TabIndex = 0;
            this.ChckBoxKucukHarfler.Text = "Küçük Harfler";
            this.ChckBoxKucukHarfler.UseVisualStyleBackColor = true;
            // 
            // ChckBoxBuyukHarfler
            // 
            this.ChckBoxBuyukHarfler.AutoSize = true;
            this.ChckBoxBuyukHarfler.Location = new System.Drawing.Point(293, 41);
            this.ChckBoxBuyukHarfler.Name = "ChckBoxBuyukHarfler";
            this.ChckBoxBuyukHarfler.Size = new System.Drawing.Size(162, 26);
            this.ChckBoxBuyukHarfler.TabIndex = 1;
            this.ChckBoxBuyukHarfler.Text = "Büyük Harfler";
            this.ChckBoxBuyukHarfler.UseVisualStyleBackColor = true;
            // 
            // ChckBoxSayılar
            // 
            this.ChckBoxSayılar.AutoSize = true;
            this.ChckBoxSayılar.Location = new System.Drawing.Point(293, 71);
            this.ChckBoxSayılar.Name = "ChckBoxSayılar";
            this.ChckBoxSayılar.Size = new System.Drawing.Size(102, 26);
            this.ChckBoxSayılar.TabIndex = 2;
            this.ChckBoxSayılar.Text = "Sayılar";
            this.ChckBoxSayılar.UseVisualStyleBackColor = true;
            // 
            // ChckBoxSemboller
            // 
            this.ChckBoxSemboller.AutoSize = true;
            this.ChckBoxSemboller.Location = new System.Drawing.Point(293, 102);
            this.ChckBoxSemboller.Name = "ChckBoxSemboller";
            this.ChckBoxSemboller.Size = new System.Drawing.Size(122, 26);
            this.ChckBoxSemboller.TabIndex = 3;
            this.ChckBoxSemboller.Text = "Semboller";
            this.ChckBoxSemboller.UseVisualStyleBackColor = true;
            // 
            // TxtGucluSifreniz
            // 
            this.TxtGucluSifreniz.Location = new System.Drawing.Point(12, 111);
            this.TxtGucluSifreniz.MaxLength = 20;
            this.TxtGucluSifreniz.Name = "TxtGucluSifreniz";
            this.TxtGucluSifreniz.ReadOnly = true;
            this.TxtGucluSifreniz.Size = new System.Drawing.Size(174, 29);
            this.TxtGucluSifreniz.TabIndex = 5;
            // 
            // BttnKopyala
            // 
            this.BttnKopyala.Location = new System.Drawing.Point(193, 111);
            this.BttnKopyala.Name = "BttnKopyala";
            this.BttnKopyala.Size = new System.Drawing.Size(75, 26);
            this.BttnKopyala.TabIndex = 7;
            this.BttnKopyala.Text = "Kopyala";
            this.BttnKopyala.UseVisualStyleBackColor = true;
            this.BttnKopyala.Click += new System.EventHandler(this.BttnKopyala_Click);
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(12, 9);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(144, 20);
            this.lblSifreUzunlugu.TabIndex = 8;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu:";
            // 
            // lblGucluSifreniz
            // 
            this.lblGucluSifreniz.AutoSize = true;
            this.lblGucluSifreniz.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblGucluSifreniz.Location = new System.Drawing.Point(12, 93);
            this.lblGucluSifreniz.Name = "lblGucluSifreniz";
            this.lblGucluSifreniz.Size = new System.Drawing.Size(153, 20);
            this.lblGucluSifreniz.TabIndex = 9;
            this.lblGucluSifreniz.Text = "Güçlü Parolanız:";
            // 
            // TrckBarSifreKarakter
            // 
            this.TrckBarSifreKarakter.Location = new System.Drawing.Point(12, 27);
            this.TrckBarSifreKarakter.Maximum = 20;
            this.TrckBarSifreKarakter.Minimum = 4;
            this.TrckBarSifreKarakter.Name = "TrckBarSifreKarakter";
            this.TrckBarSifreKarakter.Size = new System.Drawing.Size(257, 56);
            this.TrckBarSifreKarakter.TabIndex = 10;
            this.TrckBarSifreKarakter.Value = 4;
            this.TrckBarSifreKarakter.Scroll += new System.EventHandler(this.TrckBarSifreKarakter_Scroll);
            // 
            // lblSifreUzunluguDeger
            // 
            this.lblSifreUzunluguDeger.AutoSize = true;
            this.lblSifreUzunluguDeger.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblSifreUzunluguDeger.Location = new System.Drawing.Point(129, 9);
            this.lblSifreUzunluguDeger.Name = "lblSifreUzunluguDeger";
            this.lblSifreUzunluguDeger.Size = new System.Drawing.Size(18, 20);
            this.lblSifreUzunluguDeger.TabIndex = 11;
            this.lblSifreUzunluguDeger.Text = "0";
            // 
            // FrmGucluSifreOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 153);
            this.Controls.Add(this.lblSifreUzunluguDeger);
            this.Controls.Add(this.TrckBarSifreKarakter);
            this.Controls.Add(this.lblGucluSifreniz);
            this.Controls.Add(this.lblSifreUzunlugu);
            this.Controls.Add(this.BttnKopyala);
            this.Controls.Add(this.TxtGucluSifreniz);
            this.Controls.Add(this.ChckBoxSemboller);
            this.Controls.Add(this.ChckBoxSayılar);
            this.Controls.Add(this.ChckBoxBuyukHarfler);
            this.Controls.Add(this.ChckBoxKucukHarfler);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(470, 200);
            this.MinimumSize = new System.Drawing.Size(470, 200);
            this.Name = "FrmGucluSifreOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabtBil Müşteri Kayit -> Güçlü Şifre Oluştur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGucluSifreOlustur_FormClosing);
            this.Load += new System.EventHandler(this.FrmGucluSifreOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrckBarSifreKarakter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChckBoxKucukHarfler;
        private System.Windows.Forms.CheckBox ChckBoxBuyukHarfler;
        private System.Windows.Forms.CheckBox ChckBoxSayılar;
        private System.Windows.Forms.CheckBox ChckBoxSemboller;
        private System.Windows.Forms.TextBox TxtGucluSifreniz;
        private System.Windows.Forms.Button BttnKopyala;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.Label lblGucluSifreniz;
        private System.Windows.Forms.TrackBar TrckBarSifreKarakter;
        private System.Windows.Forms.Label lblSifreUzunluguDeger;
    }
}