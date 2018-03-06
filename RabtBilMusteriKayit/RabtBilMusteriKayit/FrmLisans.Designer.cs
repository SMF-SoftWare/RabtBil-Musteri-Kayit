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
            this.SuspendLayout();
            // 
            // LblEposta
            // 
            this.LblEposta.AutoSize = true;
            this.LblEposta.Location = new System.Drawing.Point(46, 24);
            this.LblEposta.Name = "LblEposta";
            this.LblEposta.Size = new System.Drawing.Size(90, 22);
            this.LblEposta.TabIndex = 0;
            this.LblEposta.Text = "E-posta:";
            // 
            // TxtEposta
            // 
            this.TxtEposta.Location = new System.Drawing.Point(49, 45);
            this.TxtEposta.MaxLength = 50;
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(252, 29);
            this.TxtEposta.TabIndex = 1;
            // 
            // TxtLisansAnahtari
            // 
            this.TxtLisansAnahtari.Location = new System.Drawing.Point(49, 99);
            this.TxtLisansAnahtari.MaxLength = 50;
            this.TxtLisansAnahtari.Name = "TxtLisansAnahtari";
            this.TxtLisansAnahtari.Size = new System.Drawing.Size(252, 29);
            this.TxtLisansAnahtari.TabIndex = 2;
            // 
            // LblLisansAnahtari
            // 
            this.LblLisansAnahtari.AutoSize = true;
            this.LblLisansAnahtari.Location = new System.Drawing.Point(46, 78);
            this.LblLisansAnahtari.Name = "LblLisansAnahtari";
            this.LblLisansAnahtari.Size = new System.Drawing.Size(200, 22);
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
            this.BttnEtkinlestir.Click += new System.EventHandler(this.BttnEtkinlestir_Click);
            // 
            // FrmLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 188);
            this.Controls.Add(this.BttnEtkinlestir);
            this.Controls.Add(this.LblLisansAnahtari);
            this.Controls.Add(this.TxtLisansAnahtari);
            this.Controls.Add(this.TxtEposta);
            this.Controls.Add(this.LblEposta);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabtBil Müşteri Kayit -> Lisans Anahtarı";
            this.Load += new System.EventHandler(this.FrmLisans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEposta;
        public System.Windows.Forms.TextBox TxtEposta;
        public System.Windows.Forms.TextBox TxtLisansAnahtari;
        private System.Windows.Forms.Label LblLisansAnahtari;
        private System.Windows.Forms.Button BttnEtkinlestir;
    }
}