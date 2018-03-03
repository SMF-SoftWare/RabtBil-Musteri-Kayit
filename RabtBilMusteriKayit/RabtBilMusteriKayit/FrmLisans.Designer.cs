namespace RabtBilMusteriKayit
{
    partial class FrmLisans
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
            this.LblEposta = new System.Windows.Forms.Label();
            this.TxtEposta = new System.Windows.Forms.TextBox();
            this.TxtLisansAnahtari = new System.Windows.Forms.TextBox();
            this.LblLisansAnahtari = new System.Windows.Forms.Label();
            this.BttnEtkinlestir = new System.Windows.Forms.Button();
            this.LblLisansDurumu = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEposta
            // 
            this.LblEposta.AutoSize = true;
            this.LblEposta.Location = new System.Drawing.Point(46, 24);
            this.LblEposta.Name = "LblEposta";
            this.LblEposta.Size = new System.Drawing.Size(72, 18);
            this.LblEposta.TabIndex = 0;
            this.LblEposta.Text = "E-posta:";
            // 
            // TxtEposta
            // 
            this.TxtEposta.Location = new System.Drawing.Point(49, 45);
            this.TxtEposta.MaxLength = 30;
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(252, 25);
            this.TxtEposta.TabIndex = 1;
            // 
            // TxtLisansAnahtari
            // 
            this.TxtLisansAnahtari.Location = new System.Drawing.Point(49, 99);
            this.TxtLisansAnahtari.MaxLength = 30;
            this.TxtLisansAnahtari.Name = "TxtLisansAnahtari";
            this.TxtLisansAnahtari.Size = new System.Drawing.Size(252, 25);
            this.TxtLisansAnahtari.TabIndex = 2;
            // 
            // LblLisansAnahtari
            // 
            this.LblLisansAnahtari.AutoSize = true;
            this.LblLisansAnahtari.Location = new System.Drawing.Point(46, 78);
            this.LblLisansAnahtari.Name = "LblLisansAnahtari";
            this.LblLisansAnahtari.Size = new System.Drawing.Size(160, 18);
            this.LblLisansAnahtari.TabIndex = 3;
            this.LblLisansAnahtari.Text = "Lisans Anahtarınız:";
            // 
            // BttnEtkinlestir
            // 
            this.BttnEtkinlestir.Location = new System.Drawing.Point(74, 130);
            this.BttnEtkinlestir.Name = "BttnEtkinlestir";
            this.BttnEtkinlestir.Size = new System.Drawing.Size(200, 42);
            this.BttnEtkinlestir.TabIndex = 5;
            this.BttnEtkinlestir.Text = "Etkinleştir";
            this.BttnEtkinlestir.UseVisualStyleBackColor = true;
            // 
            // LblLisansDurumu
            // 
            this.LblLisansDurumu.AutoSize = true;
            this.LblLisansDurumu.Location = new System.Drawing.Point(71, 190);
            this.LblLisansDurumu.Name = "LblLisansDurumu";
            this.LblLisansDurumu.Size = new System.Drawing.Size(120, 18);
            this.LblLisansDurumu.TabIndex = 6;
            this.LblLisansDurumu.Text = "Lisans Durumu:";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(197, 190);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(48, 18);
            this.LblDurum.TabIndex = 7;
            this.LblDurum.Text = "Durum";
            // 
            // FrmLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 228);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblLisansDurumu);
            this.Controls.Add(this.BttnEtkinlestir);
            this.Controls.Add(this.LblLisansAnahtari);
            this.Controls.Add(this.TxtLisansAnahtari);
            this.Controls.Add(this.TxtEposta);
            this.Controls.Add(this.LblEposta);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLisans";
            this.Text = "RabtBil Müşteri Kayit -> Lisans Anahtarı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEposta;
        public System.Windows.Forms.TextBox TxtEposta;
        public System.Windows.Forms.TextBox TxtLisansAnahtari;
        private System.Windows.Forms.Label LblLisansAnahtari;
        private System.Windows.Forms.Button BttnEtkinlestir;
        private System.Windows.Forms.Label LblLisansDurumu;
        private System.Windows.Forms.Label LblDurum;
    }
}