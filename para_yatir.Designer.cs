namespace WindowsFormsApplication1
{
    partial class ekle_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle_form));
            this.tutar_box = new System.Windows.Forms.TextBox();
            this.tutar = new System.Windows.Forms.Label();
            this.tamam = new System.Windows.Forms.Button();
            this.vazgec_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tutar_box
            // 
            this.tutar_box.Location = new System.Drawing.Point(138, 35);
            this.tutar_box.Name = "tutar_box";
            this.tutar_box.Size = new System.Drawing.Size(253, 20);
            this.tutar_box.TabIndex = 0;
            this.tutar_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tutar_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tutar_box_KeyPress);
            // 
            // tutar
            // 
            this.tutar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tutar.Location = new System.Drawing.Point(29, 38);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(103, 20);
            this.tutar.TabIndex = 1;
            this.tutar.Text = "Lütfen Tutarı Giriniz:";
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(138, 70);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(100, 23);
            this.tamam.TabIndex = 2;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // vazgec_buton
            // 
            this.vazgec_buton.Location = new System.Drawing.Point(291, 70);
            this.vazgec_buton.Name = "vazgec_buton";
            this.vazgec_buton.Size = new System.Drawing.Size(100, 23);
            this.vazgec_buton.TabIndex = 3;
            this.vazgec_buton.Text = "Vazgeç";
            this.vazgec_buton.UseVisualStyleBackColor = true;
            this.vazgec_buton.Click += new System.EventHandler(this.vazgec_buton_Click);
            // 
            // ekle_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 105);
            this.Controls.Add(this.vazgec_buton);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.tutar_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ekle_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Yatırma";
            this.Load += new System.EventHandler(this.para_yatir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tutar_box;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.Button vazgec_buton;
    }
}