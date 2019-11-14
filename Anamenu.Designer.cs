namespace WindowsFormsApplication1
{
    partial class mmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mmenu));
            this.para_yatir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatura_button = new System.Windows.Forms.Button();
            this.para_cek = new System.Windows.Forms.Button();
            this.transfer_buton = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // para_yatir
            // 
            this.para_yatir.Location = new System.Drawing.Point(42, 133);
            this.para_yatir.Name = "para_yatir";
            this.para_yatir.Size = new System.Drawing.Size(341, 32);
            this.para_yatir.TabIndex = 0;
            this.para_yatir.Text = "Para Yatırma";
            this.para_yatir.UseVisualStyleBackColor = true;
            this.para_yatir.Click += new System.EventHandler(this.para_yatir_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bakiyeniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(376, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 71);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fatura_button
            // 
            this.fatura_button.Location = new System.Drawing.Point(518, 133);
            this.fatura_button.Name = "fatura_button";
            this.fatura_button.Size = new System.Drawing.Size(288, 32);
            this.fatura_button.TabIndex = 4;
            this.fatura_button.Text = "Fatura Ödeme";
            this.fatura_button.UseVisualStyleBackColor = true;
            this.fatura_button.Click += new System.EventHandler(this.fatura_button_Click);
            // 
            // para_cek
            // 
            this.para_cek.Location = new System.Drawing.Point(42, 188);
            this.para_cek.Name = "para_cek";
            this.para_cek.Size = new System.Drawing.Size(341, 35);
            this.para_cek.TabIndex = 5;
            this.para_cek.Text = "Para Çekme";
            this.para_cek.UseVisualStyleBackColor = true;
            this.para_cek.Click += new System.EventHandler(this.para_cek_Click);
            // 
            // transfer_buton
            // 
            this.transfer_buton.Location = new System.Drawing.Point(518, 188);
            this.transfer_buton.Name = "transfer_buton";
            this.transfer_buton.Size = new System.Drawing.Size(288, 35);
            this.transfer_buton.TabIndex = 6;
            this.transfer_buton.Text = "Para Transferi";
            this.transfer_buton.UseVisualStyleBackColor = true;
            this.transfer_buton.Click += new System.EventHandler(this.transfer_buton_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(376, 279);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(146, 66);
            this.cikis.TabIndex = 7;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(812, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "TL";
            // 
            // mmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(882, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.transfer_buton);
            this.Controls.Add(this.para_cek);
            this.Controls.Add(this.fatura_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.para_yatir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankamatik";
            this.Load += new System.EventHandler(this.mmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button para_yatir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fatura_button;
        private System.Windows.Forms.Button para_cek;
        private System.Windows.Forms.Button transfer_buton;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label3;
    }
}