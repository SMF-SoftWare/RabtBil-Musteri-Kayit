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
            this.ChckSemboller = new System.Windows.Forms.CheckBox();
            this.BttnOlustur = new System.Windows.Forms.Button();
            this.TxtGucluSifreniz = new System.Windows.Forms.TextBox();
            this.CmbBoxSifreKarakter = new System.Windows.Forms.ComboBox();
            this.BttnKopyala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChckBoxKucukHarfler
            // 
            this.ChckBoxKucukHarfler.AutoSize = true;
            this.ChckBoxKucukHarfler.Location = new System.Drawing.Point(298, 68);
            this.ChckBoxKucukHarfler.Name = "ChckBoxKucukHarfler";
            this.ChckBoxKucukHarfler.Size = new System.Drawing.Size(131, 22);
            this.ChckBoxKucukHarfler.TabIndex = 0;
            this.ChckBoxKucukHarfler.Text = "Küçük Harfler";
            this.ChckBoxKucukHarfler.UseVisualStyleBackColor = true;
            // 
            // ChckBoxBuyukHarfler
            // 
            this.ChckBoxBuyukHarfler.AutoSize = true;
            this.ChckBoxBuyukHarfler.Location = new System.Drawing.Point(298, 97);
            this.ChckBoxBuyukHarfler.Name = "ChckBoxBuyukHarfler";
            this.ChckBoxBuyukHarfler.Size = new System.Drawing.Size(131, 22);
            this.ChckBoxBuyukHarfler.TabIndex = 1;
            this.ChckBoxBuyukHarfler.Text = "Büyük Harfler";
            this.ChckBoxBuyukHarfler.UseVisualStyleBackColor = true;
            // 
            // ChckBoxSayılar
            // 
            this.ChckBoxSayılar.AutoSize = true;
            this.ChckBoxSayılar.Location = new System.Drawing.Point(298, 127);
            this.ChckBoxSayılar.Name = "ChckBoxSayılar";
            this.ChckBoxSayılar.Size = new System.Drawing.Size(83, 22);
            this.ChckBoxSayılar.TabIndex = 2;
            this.ChckBoxSayılar.Text = "Sayılar";
            this.ChckBoxSayılar.UseVisualStyleBackColor = true;
            // 
            // ChckSemboller
            // 
            this.ChckSemboller.AutoSize = true;
            this.ChckSemboller.Location = new System.Drawing.Point(298, 158);
            this.ChckSemboller.Name = "ChckSemboller";
            this.ChckSemboller.Size = new System.Drawing.Size(99, 22);
            this.ChckSemboller.TabIndex = 3;
            this.ChckSemboller.Text = "Semboller";
            this.ChckSemboller.UseVisualStyleBackColor = true;
            // 
            // BttnOlustur
            // 
            this.BttnOlustur.Location = new System.Drawing.Point(286, 15);
            this.BttnOlustur.Name = "BttnOlustur";
            this.BttnOlustur.Size = new System.Drawing.Size(75, 26);
            this.BttnOlustur.TabIndex = 4;
            this.BttnOlustur.Text = "Oluştur";
            this.BttnOlustur.UseVisualStyleBackColor = true;
            this.BttnOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtGucluSifreniz
            // 
            this.TxtGucluSifreniz.Location = new System.Drawing.Point(12, 90);
            this.TxtGucluSifreniz.MaxLength = 20;
            this.TxtGucluSifreniz.Name = "TxtGucluSifreniz";
            this.TxtGucluSifreniz.ReadOnly = true;
            this.TxtGucluSifreniz.Size = new System.Drawing.Size(174, 25);
            this.TxtGucluSifreniz.TabIndex = 5;
            // 
            // CmbBoxSifreKarakter
            // 
            this.CmbBoxSifreKarakter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxSifreKarakter.FormattingEnabled = true;
            this.CmbBoxSifreKarakter.Location = new System.Drawing.Point(12, 27);
            this.CmbBoxSifreKarakter.Name = "CmbBoxSifreKarakter";
            this.CmbBoxSifreKarakter.Size = new System.Drawing.Size(69, 26);
            this.CmbBoxSifreKarakter.TabIndex = 6;
            // 
            // BttnKopyala
            // 
            this.BttnKopyala.Location = new System.Drawing.Point(367, 15);
            this.BttnKopyala.Name = "BttnKopyala";
            this.BttnKopyala.Size = new System.Drawing.Size(75, 26);
            this.BttnKopyala.TabIndex = 7;
            this.BttnKopyala.Text = "Kopyala";
            this.BttnKopyala.UseVisualStyleBackColor = true;
            this.BttnKopyala.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifreniz Kaç Karakter Olsun:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Güçlü Parolanız:";
            // 
            // FrmGucluSifreOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnKopyala);
            this.Controls.Add(this.CmbBoxSifreKarakter);
            this.Controls.Add(this.TxtGucluSifreniz);
            this.Controls.Add(this.BttnOlustur);
            this.Controls.Add(this.ChckSemboller);
            this.Controls.Add(this.ChckBoxSayılar);
            this.Controls.Add(this.ChckBoxBuyukHarfler);
            this.Controls.Add(this.ChckBoxKucukHarfler);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(470, 240);
            this.MinimumSize = new System.Drawing.Size(470, 240);
            this.Name = "FrmGucluSifreOlustur";
            this.Text = "RabtBil Müşteri Kayit -> Güçlü Şifre Oluştur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGucluSifreOlustur_FormClosing);
            this.Load += new System.EventHandler(this.FrmGucluSifreOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChckBoxKucukHarfler;
        private System.Windows.Forms.CheckBox ChckBoxBuyukHarfler;
        private System.Windows.Forms.CheckBox ChckBoxSayılar;
        private System.Windows.Forms.CheckBox ChckSemboller;
        private System.Windows.Forms.Button BttnOlustur;
        private System.Windows.Forms.TextBox TxtGucluSifreniz;
        private System.Windows.Forms.ComboBox CmbBoxSifreKarakter;
        private System.Windows.Forms.Button BttnKopyala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}