namespace WindowsFormsApplication1
{
    partial class paracek
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
            this.para_cek_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buton_cek = new System.Windows.Forms.Button();
            this.vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // para_cek_box
            // 
            this.para_cek_box.Location = new System.Drawing.Point(270, 42);
            this.para_cek_box.Name = "para_cek_box";
            this.para_cek_box.Size = new System.Drawing.Size(190, 20);
            this.para_cek_box.TabIndex = 0;
            this.para_cek_box.TextChanged += new System.EventHandler(this.para_cek_box_TextChanged);
            this.para_cek_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.para_cek_box_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen çekmek istediğiniz tutarı giriniz:";
            // 
            // buton_cek
            // 
            this.buton_cek.Location = new System.Drawing.Point(270, 82);
            this.buton_cek.Name = "buton_cek";
            this.buton_cek.Size = new System.Drawing.Size(75, 23);
            this.buton_cek.TabIndex = 2;
            this.buton_cek.Text = "Tamam";
            this.buton_cek.UseVisualStyleBackColor = true;
            this.buton_cek.Click += new System.EventHandler(this.buton_cek_Click);
            // 
            // vazgec
            // 
            this.vazgec.Location = new System.Drawing.Point(385, 82);
            this.vazgec.Name = "vazgec";
            this.vazgec.Size = new System.Drawing.Size(75, 23);
            this.vazgec.TabIndex = 3;
            this.vazgec.Text = "Vazgeç";
            this.vazgec.UseVisualStyleBackColor = true;
            this.vazgec.Click += new System.EventHandler(this.vazgec_Click);
            // 
            // paracek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 142);
            this.ControlBox = false;
            this.Controls.Add(this.vazgec);
            this.Controls.Add(this.buton_cek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.para_cek_box);
            this.Name = "paracek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Çekme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox para_cek_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buton_cek;
        private System.Windows.Forms.Button vazgec;
    }
}