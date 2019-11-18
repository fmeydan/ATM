namespace WindowsFormsApplication1
{
    partial class sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_in));
            this.tamam_buton = new System.Windows.Forms.Button();
            this.vazgec_buton = new System.Windows.Forms.Button();
            this.kAdi_box = new System.Windows.Forms.TextBox();
            this.sifre_box = new System.Windows.Forms.TextBox();
            this.kullanici_adi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.textBox_gizliSoru = new System.Windows.Forms.TextBox();
            this.textBox_gizliCevap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tamam_buton
            // 
            this.tamam_buton.Location = new System.Drawing.Point(89, 116);
            this.tamam_buton.Name = "tamam_buton";
            this.tamam_buton.Size = new System.Drawing.Size(75, 23);
            this.tamam_buton.TabIndex = 5;
            this.tamam_buton.Text = "Tamam";
            this.tamam_buton.UseVisualStyleBackColor = true;
            this.tamam_buton.Click += new System.EventHandler(this.tamam_buton_Click);
            // 
            // vazgec_buton
            // 
            this.vazgec_buton.Location = new System.Drawing.Point(199, 116);
            this.vazgec_buton.Name = "vazgec_buton";
            this.vazgec_buton.Size = new System.Drawing.Size(75, 23);
            this.vazgec_buton.TabIndex = 6;
            this.vazgec_buton.Text = "Vazgeç";
            this.vazgec_buton.UseVisualStyleBackColor = true;
            this.vazgec_buton.Click += new System.EventHandler(this.vazgec_buton_Click);
            // 
            // kAdi_box
            // 
            this.kAdi_box.Location = new System.Drawing.Point(89, 12);
            this.kAdi_box.Name = "kAdi_box";
            this.kAdi_box.Size = new System.Drawing.Size(185, 20);
            this.kAdi_box.TabIndex = 1;
            // 
            // sifre_box
            // 
            this.sifre_box.Location = new System.Drawing.Point(89, 38);
            this.sifre_box.Name = "sifre_box";
            this.sifre_box.PasswordChar = '*';
            this.sifre_box.Size = new System.Drawing.Size(185, 20);
            this.sifre_box.TabIndex = 2;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.AutoSize = true;
            this.kullanici_adi.Location = new System.Drawing.Point(16, 15);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(67, 13);
            this.kullanici_adi.TabIndex = 4;
            this.kullanici_adi.Text = "Kullanıcı Adı:";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(52, 41);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(31, 13);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre:";
            // 
            // textBox_gizliSoru
            // 
            this.textBox_gizliSoru.Location = new System.Drawing.Point(89, 64);
            this.textBox_gizliSoru.Name = "textBox_gizliSoru";
            this.textBox_gizliSoru.Size = new System.Drawing.Size(185, 20);
            this.textBox_gizliSoru.TabIndex = 3;
            // 
            // textBox_gizliCevap
            // 
            this.textBox_gizliCevap.Location = new System.Drawing.Point(89, 90);
            this.textBox_gizliCevap.Name = "textBox_gizliCevap";
            this.textBox_gizliCevap.PasswordChar = '*';
            this.textBox_gizliCevap.Size = new System.Drawing.Size(185, 20);
            this.textBox_gizliCevap.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gizli Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cevap:";
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 155);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.textBox_gizliCevap);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.textBox_gizliSoru);
            this.Controls.Add(this.sifre_box);
            this.Controls.Add(this.kAdi_box);
            this.Controls.Add(this.vazgec_buton);
            this.Controls.Add(this.tamam_buton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.sign_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tamam_buton;
        private System.Windows.Forms.Button vazgec_buton;
        private System.Windows.Forms.TextBox kAdi_box;
        private System.Windows.Forms.TextBox sifre_box;
        private System.Windows.Forms.Label kullanici_adi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox textBox_gizliSoru;
        private System.Windows.Forms.TextBox textBox_gizliCevap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}