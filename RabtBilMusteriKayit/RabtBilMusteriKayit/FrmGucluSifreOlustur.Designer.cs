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
            this.TxtGucluSifreniz = new System.Windows.Forms.TextBox();
            this.BttnKopyala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrckBarSifreKarakter = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrckBarSifreKarakter)).BeginInit();
            this.SuspendLayout();
            // 
            // ChckBoxKucukHarfler
            // 
            this.ChckBoxKucukHarfler.AutoSize = true;
            this.ChckBoxKucukHarfler.Location = new System.Drawing.Point(311, 12);
            this.ChckBoxKucukHarfler.Name = "ChckBoxKucukHarfler";
            this.ChckBoxKucukHarfler.Size = new System.Drawing.Size(162, 26);
            this.ChckBoxKucukHarfler.TabIndex = 0;
            this.ChckBoxKucukHarfler.Text = "Küçük Harfler";
            this.ChckBoxKucukHarfler.UseVisualStyleBackColor = true;
            // 
            // ChckBoxBuyukHarfler
            // 
            this.ChckBoxBuyukHarfler.AutoSize = true;
            this.ChckBoxBuyukHarfler.Location = new System.Drawing.Point(311, 41);
            this.ChckBoxBuyukHarfler.Name = "ChckBoxBuyukHarfler";
            this.ChckBoxBuyukHarfler.Size = new System.Drawing.Size(162, 26);
            this.ChckBoxBuyukHarfler.TabIndex = 1;
            this.ChckBoxBuyukHarfler.Text = "Büyük Harfler";
            this.ChckBoxBuyukHarfler.UseVisualStyleBackColor = true;
            // 
            // ChckBoxSayılar
            // 
            this.ChckBoxSayılar.AutoSize = true;
            this.ChckBoxSayılar.Location = new System.Drawing.Point(311, 71);
            this.ChckBoxSayılar.Name = "ChckBoxSayılar";
            this.ChckBoxSayılar.Size = new System.Drawing.Size(102, 26);
            this.ChckBoxSayılar.TabIndex = 2;
            this.ChckBoxSayılar.Text = "Sayılar";
            this.ChckBoxSayılar.UseVisualStyleBackColor = true;
            // 
            // ChckSemboller
            // 
            this.ChckSemboller.AutoSize = true;
            this.ChckSemboller.Location = new System.Drawing.Point(311, 102);
            this.ChckSemboller.Name = "ChckSemboller";
            this.ChckSemboller.Size = new System.Drawing.Size(122, 26);
            this.ChckSemboller.TabIndex = 3;
            this.ChckSemboller.Text = "Semboller";
            this.ChckSemboller.UseVisualStyleBackColor = true;
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
            this.BttnKopyala.Location = new System.Drawing.Point(207, 111);
            this.BttnKopyala.Name = "BttnKopyala";
            this.BttnKopyala.Size = new System.Drawing.Size(75, 26);
            this.BttnKopyala.TabIndex = 7;
            this.BttnKopyala.Text = "Kopyala";
            this.BttnKopyala.UseVisualStyleBackColor = true;
            this.BttnKopyala.Click += new System.EventHandler(this.BttnKopyala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifreniz Kaç Karakter Olsun:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Güçlü Parolanız:";
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
            // FrmGucluSifreOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 153);
            this.Controls.Add(this.TrckBarSifreKarakter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnKopyala);
            this.Controls.Add(this.TxtGucluSifreniz);
            this.Controls.Add(this.ChckSemboller);
            this.Controls.Add(this.ChckBoxSayılar);
            this.Controls.Add(this.ChckBoxBuyukHarfler);
            this.Controls.Add(this.ChckBoxKucukHarfler);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(470, 200);
            this.MinimumSize = new System.Drawing.Size(470, 200);
            this.Name = "FrmGucluSifreOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabtBil Müşteri Kayit -> Güçlü Şifre Oluştur";
            this.Load += new System.EventHandler(this.FrmGucluSifreOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrckBarSifreKarakter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChckBoxKucukHarfler;
        private System.Windows.Forms.CheckBox ChckBoxBuyukHarfler;
        private System.Windows.Forms.CheckBox ChckBoxSayılar;
        private System.Windows.Forms.CheckBox ChckSemboller;
        private System.Windows.Forms.TextBox TxtGucluSifreniz;
        private System.Windows.Forms.Button BttnKopyala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TrckBarSifreKarakter;
    }
}