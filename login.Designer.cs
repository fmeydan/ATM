namespace WindowsFormsApplication1
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.textbox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.kadi = new System.Windows.Forms.Label();
            this.textbox_sifre = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.checkBox_beniHatirla = new System.Windows.Forms.CheckBox();
            this.sifremi_unuttum = new System.Windows.Forms.LinkLabel();
            this.kayit_ol = new System.Windows.Forms.LinkLabel();
            this.pictureBox_kucukLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox_buyukLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kucukLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buyukLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_kullaniciAdi
            // 
            this.textbox_kullaniciAdi.Location = new System.Drawing.Point(251, 114);
            this.textbox_kullaniciAdi.Name = "textbox_kullaniciAdi";
            this.textbox_kullaniciAdi.Size = new System.Drawing.Size(193, 20);
            this.textbox_kullaniciAdi.TabIndex = 0;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(251, 198);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(92, 37);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // kadi
            // 
            this.kadi.AutoSize = true;
            this.kadi.Location = new System.Drawing.Point(178, 117);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(67, 13);
            this.kadi.TabIndex = 2;
            this.kadi.Text = "Kullanıcı Adı:";
            // 
            // textbox_sifre
            // 
            this.textbox_sifre.Location = new System.Drawing.Point(251, 150);
            this.textbox_sifre.Name = "textbox_sifre";
            this.textbox_sifre.Size = new System.Drawing.Size(193, 20);
            this.textbox_sifre.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(214, 153);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(31, 13);
            this.sifre.TabIndex = 4;
            this.sifre.Text = "Şifre:";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(352, 198);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(92, 37);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // checkBox_beniHatirla
            // 
            this.checkBox_beniHatirla.AutoSize = true;
            this.checkBox_beniHatirla.Location = new System.Drawing.Point(251, 175);
            this.checkBox_beniHatirla.Name = "checkBox_beniHatirla";
            this.checkBox_beniHatirla.Size = new System.Drawing.Size(80, 17);
            this.checkBox_beniHatirla.TabIndex = 3;
            this.checkBox_beniHatirla.Text = "Beni Hatırla";
            this.checkBox_beniHatirla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_beniHatirla.UseVisualStyleBackColor = true;
            // 
            // sifremi_unuttum
            // 
            this.sifremi_unuttum.DisabledLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.sifremi_unuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremi_unuttum.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.sifremi_unuttum.Location = new System.Drawing.Point(12, 198);
            this.sifremi_unuttum.Name = "sifremi_unuttum";
            this.sifremi_unuttum.Size = new System.Drawing.Size(85, 19);
            this.sifremi_unuttum.TabIndex = 6;
            this.sifremi_unuttum.TabStop = true;
            this.sifremi_unuttum.Text = "Şifremi Unuttum";
            // 
            // kayit_ol
            // 
            this.kayit_ol.AutoSize = true;
            this.kayit_ol.BackColor = System.Drawing.SystemColors.Control;
            this.kayit_ol.DisabledLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.kayit_ol.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.kayit_ol.Location = new System.Drawing.Point(12, 175);
            this.kayit_ol.Name = "kayit_ol";
            this.kayit_ol.Size = new System.Drawing.Size(43, 13);
            this.kayit_ol.TabIndex = 8;
            this.kayit_ol.TabStop = true;
            this.kayit_ol.Text = "Kayıt Ol";
            this.kayit_ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kayit_ol_LinkClicked);
            // 
            // pictureBox_kucukLogo
            // 
            this.pictureBox_kucukLogo.Image = global::WindowsFormsApplication1.Properties.Resources.fuat;
            this.pictureBox_kucukLogo.Location = new System.Drawing.Point(181, 12);
            this.pictureBox_kucukLogo.Name = "pictureBox_kucukLogo";
            this.pictureBox_kucukLogo.Size = new System.Drawing.Size(263, 96);
            this.pictureBox_kucukLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_kucukLogo.TabIndex = 9;
            this.pictureBox_kucukLogo.TabStop = false;
            // 
            // pictureBox_buyukLogo
            // 
            this.pictureBox_buyukLogo.Image = global::WindowsFormsApplication1.Properties.Resources.logo2;
            this.pictureBox_buyukLogo.Location = new System.Drawing.Point(9, 12);
            this.pictureBox_buyukLogo.Name = "pictureBox_buyukLogo";
            this.pictureBox_buyukLogo.Size = new System.Drawing.Size(163, 140);
            this.pictureBox_buyukLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_buyukLogo.TabIndex = 6;
            this.pictureBox_buyukLogo.TabStop = false;
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 241);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox_kucukLogo);
            this.Controls.Add(this.kayit_ol);
            this.Controls.Add(this.sifremi_unuttum);
            this.Controls.Add(this.checkBox_beniHatirla);
            this.Controls.Add(this.pictureBox_buyukLogo);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.textbox_sifre);
            this.Controls.Add(this.kadi);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.textbox_kullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankamatik";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kucukLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buyukLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_kullaniciAdi;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label kadi;
        private System.Windows.Forms.TextBox textbox_sifre;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.PictureBox pictureBox_buyukLogo;
        private System.Windows.Forms.CheckBox checkBox_beniHatirla;
        private System.Windows.Forms.LinkLabel sifremi_unuttum;
        private System.Windows.Forms.LinkLabel kayit_ol;
        private System.Windows.Forms.PictureBox pictureBox_kucukLogo;
    }
}

