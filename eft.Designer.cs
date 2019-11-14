namespace WindowsFormsApplication1
{
    partial class eft
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
            this.hesa_no_box = new System.Windows.Forms.TextBox();
            this.eft_no_box = new System.Windows.Forms.TextBox();
            this.tutar_box = new System.Windows.Forms.TextBox();
            this.hesap_no_label = new System.Windows.Forms.Label();
            this.eft_no_label = new System.Windows.Forms.Label();
            this.eft_tutar = new System.Windows.Forms.Label();
            this.tamam_buton = new System.Windows.Forms.Button();
            this.vazgec_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hesa_no_box
            // 
            this.hesa_no_box.Location = new System.Drawing.Point(274, 26);
            this.hesa_no_box.Name = "hesa_no_box";
            this.hesa_no_box.Size = new System.Drawing.Size(201, 20);
            this.hesa_no_box.TabIndex = 0;
            this.hesa_no_box.TextChanged += new System.EventHandler(this.hesa_no_box_TextChanged);
            this.hesa_no_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hesa_no_box_KeyPress);
            // 
            // eft_no_box
            // 
            this.eft_no_box.Location = new System.Drawing.Point(274, 52);
            this.eft_no_box.Name = "eft_no_box";
            this.eft_no_box.Size = new System.Drawing.Size(201, 20);
            this.eft_no_box.TabIndex = 1;
            this.eft_no_box.TextChanged += new System.EventHandler(this.eft_no_box_TextChanged);
            this.eft_no_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eft_no_box_KeyPress);
            // 
            // tutar_box
            // 
            this.tutar_box.Location = new System.Drawing.Point(274, 77);
            this.tutar_box.Name = "tutar_box";
            this.tutar_box.Size = new System.Drawing.Size(201, 20);
            this.tutar_box.TabIndex = 2;
            this.tutar_box.TextChanged += new System.EventHandler(this.tutar_box_TextChanged);
            this.tutar_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tutar_box_KeyPress);
            // 
            // hesap_no_label
            // 
            this.hesap_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_no_label.Location = new System.Drawing.Point(12, 26);
            this.hesap_no_label.Name = "hesap_no_label";
            this.hesap_no_label.Size = new System.Drawing.Size(256, 20);
            this.hesap_no_label.TabIndex = 3;
            this.hesap_no_label.Text = "EFT Hesap No giriniz:";
            // 
            // eft_no_label
            // 
            this.eft_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eft_no_label.Location = new System.Drawing.Point(12, 52);
            this.eft_no_label.Name = "eft_no_label";
            this.eft_no_label.Size = new System.Drawing.Size(256, 20);
            this.eft_no_label.TabIndex = 4;
            this.eft_no_label.Text = "EFT No giriniz:";
            // 
            // eft_tutar
            // 
            this.eft_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eft_tutar.Location = new System.Drawing.Point(12, 77);
            this.eft_tutar.Name = "eft_tutar";
            this.eft_tutar.Size = new System.Drawing.Size(256, 20);
            this.eft_tutar.TabIndex = 5;
            this.eft_tutar.Text = "EFT tutarını giriniz:";
            this.eft_tutar.Click += new System.EventHandler(this.label3_Click);
            // 
            // tamam_buton
            // 
            this.tamam_buton.Location = new System.Drawing.Point(274, 103);
            this.tamam_buton.Name = "tamam_buton";
            this.tamam_buton.Size = new System.Drawing.Size(75, 23);
            this.tamam_buton.TabIndex = 6;
            this.tamam_buton.Text = "Tamam";
            this.tamam_buton.UseVisualStyleBackColor = true;
            this.tamam_buton.Click += new System.EventHandler(this.tamam_buton_Click);
            // 
            // vazgec_buton
            // 
            this.vazgec_buton.Location = new System.Drawing.Point(400, 103);
            this.vazgec_buton.Name = "vazgec_buton";
            this.vazgec_buton.Size = new System.Drawing.Size(75, 23);
            this.vazgec_buton.TabIndex = 7;
            this.vazgec_buton.Text = "Vazgeç";
            this.vazgec_buton.UseVisualStyleBackColor = true;
            this.vazgec_buton.Click += new System.EventHandler(this.vazgec_buton_Click);
            // 
            // eft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 137);
            this.ControlBox = false;
            this.Controls.Add(this.vazgec_buton);
            this.Controls.Add(this.tamam_buton);
            this.Controls.Add(this.eft_tutar);
            this.Controls.Add(this.eft_no_label);
            this.Controls.Add(this.hesap_no_label);
            this.Controls.Add(this.tutar_box);
            this.Controls.Add(this.eft_no_box);
            this.Controls.Add(this.hesa_no_box);
            this.Name = "eft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EFT";
            this.Load += new System.EventHandler(this.eft_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hesa_no_box;
        private System.Windows.Forms.TextBox eft_no_box;
        private System.Windows.Forms.TextBox tutar_box;
        private System.Windows.Forms.Label hesap_no_label;
        private System.Windows.Forms.Label eft_no_label;
        private System.Windows.Forms.Label eft_tutar;
        private System.Windows.Forms.Button tamam_buton;
        private System.Windows.Forms.Button vazgec_buton;
    }
}