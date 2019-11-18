namespace WindowsFormsApplication1
{
    partial class SifremiUnuttumcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_gizliSoru = new System.Windows.Forms.TextBox();
            this.textBox_gizliCevap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_bul = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_vazgec = new System.Windows.Forms.Button();
            this.textBox_yeniSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(101, 22);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(137, 20);
            this.textBox_kullaniciAdi.TabIndex = 1;
            // 
            // textBox_gizliSoru
            // 
            this.textBox_gizliSoru.Location = new System.Drawing.Point(101, 49);
            this.textBox_gizliSoru.Name = "textBox_gizliSoru";
            this.textBox_gizliSoru.Size = new System.Drawing.Size(137, 20);
            this.textBox_gizliSoru.TabIndex = 2;
            // 
            // textBox_gizliCevap
            // 
            this.textBox_gizliCevap.Location = new System.Drawing.Point(101, 76);
            this.textBox_gizliCevap.Name = "textBox_gizliCevap";
            this.textBox_gizliCevap.Size = new System.Drawing.Size(137, 20);
            this.textBox_gizliCevap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gizli Soru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cevap:";
            // 
            // button_bul
            // 
            this.button_bul.Location = new System.Drawing.Point(244, 22);
            this.button_bul.Name = "button_bul";
            this.button_bul.Size = new System.Drawing.Size(75, 20);
            this.button_bul.TabIndex = 6;
            this.button_bul.Text = "Bul";
            this.button_bul.UseVisualStyleBackColor = true;
            this.button_bul.Click += new System.EventHandler(this.button_bul_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(101, 155);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(64, 23);
            this.button_kaydet.TabIndex = 7;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_vazgec
            // 
            this.button_vazgec.Location = new System.Drawing.Point(174, 155);
            this.button_vazgec.Name = "button_vazgec";
            this.button_vazgec.Size = new System.Drawing.Size(64, 23);
            this.button_vazgec.TabIndex = 8;
            this.button_vazgec.Text = "Vazgeç";
            this.button_vazgec.UseVisualStyleBackColor = true;
            this.button_vazgec.Click += new System.EventHandler(this.button_vazgec_Click);
            // 
            // textBox_yeniSifre
            // 
            this.textBox_yeniSifre.Location = new System.Drawing.Point(101, 103);
            this.textBox_yeniSifre.Name = "textBox_yeniSifre";
            this.textBox_yeniSifre.Size = new System.Drawing.Size(137, 20);
            this.textBox_yeniSifre.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yeni Şifre:";
            // 
            // textBox_yeniSifreTekrar
            // 
            this.textBox_yeniSifreTekrar.Location = new System.Drawing.Point(101, 129);
            this.textBox_yeniSifreTekrar.Name = "textBox_yeniSifreTekrar";
            this.textBox_yeniSifreTekrar.Size = new System.Drawing.Size(137, 20);
            this.textBox_yeniSifreTekrar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yeni Şifre Tekrar:";
            // 
            // SifremiUnuttumcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 205);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_yeniSifreTekrar);
            this.Controls.Add(this.textBox_yeniSifre);
            this.Controls.Add(this.button_vazgec);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.button_bul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_gizliCevap);
            this.Controls.Add(this.textBox_gizliSoru);
            this.Controls.Add(this.textBox_kullaniciAdi);
            this.Controls.Add(this.label1);
            this.Name = "SifremiUnuttumcs";
            this.Text = "Sifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_gizliSoru;
        private System.Windows.Forms.TextBox textBox_gizliCevap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_bul;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_vazgec;
        private System.Windows.Forms.TextBox textBox_yeniSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_yeniSifreTekrar;
        private System.Windows.Forms.Label label5;
    }
}