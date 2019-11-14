namespace WindowsFormsApplication1
{
    partial class Havale
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
            this.havale_box = new System.Windows.Forms.TextBox();
            this.tamam_buton = new System.Windows.Forms.Button();
            this.vazgec_buton = new System.Windows.Forms.Button();
            this.tutar_box = new System.Windows.Forms.TextBox();
            this.tutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen havale No giriniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // havale_box
            // 
            this.havale_box.Location = new System.Drawing.Point(182, 32);
            this.havale_box.Name = "havale_box";
            this.havale_box.Size = new System.Drawing.Size(201, 20);
            this.havale_box.TabIndex = 1;
            this.havale_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.havale_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.havale_box_KeyPress);
            // 
            // tamam_buton
            // 
            this.tamam_buton.Location = new System.Drawing.Point(182, 141);
            this.tamam_buton.Name = "tamam_buton";
            this.tamam_buton.Size = new System.Drawing.Size(75, 23);
            this.tamam_buton.TabIndex = 2;
            this.tamam_buton.Text = "Tamam";
            this.tamam_buton.UseVisualStyleBackColor = true;
            this.tamam_buton.Click += new System.EventHandler(this.tamam_buton_Click);
            // 
            // vazgec_buton
            // 
            this.vazgec_buton.Location = new System.Drawing.Point(308, 141);
            this.vazgec_buton.Name = "vazgec_buton";
            this.vazgec_buton.Size = new System.Drawing.Size(75, 23);
            this.vazgec_buton.TabIndex = 3;
            this.vazgec_buton.Text = "Vazgeç";
            this.vazgec_buton.UseVisualStyleBackColor = true;
            this.vazgec_buton.Click += new System.EventHandler(this.vazgec_buton_Click);
            // 
            // tutar_box
            // 
            this.tutar_box.Location = new System.Drawing.Point(182, 91);
            this.tutar_box.Name = "tutar_box";
            this.tutar_box.Size = new System.Drawing.Size(201, 20);
            this.tutar_box.TabIndex = 5;
            this.tutar_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tutar_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tutar_box_KeyPress);
            // 
            // tutar
            // 
            this.tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutar.Location = new System.Drawing.Point(6, 90);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(170, 23);
            this.tutar.TabIndex = 4;
            this.tutar.Text = "Lütfen tutar giriniz:";
            this.tutar.Click += new System.EventHandler(this.label2_Click);
            // 
            // Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.ControlBox = false;
            this.Controls.Add(this.tutar_box);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.vazgec_buton);
            this.Controls.Add(this.tamam_buton);
            this.Controls.Add(this.havale_box);
            this.Controls.Add(this.label1);
            this.Name = "Havale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox havale_box;
        private System.Windows.Forms.Button tamam_buton;
        private System.Windows.Forms.Button vazgec_buton;
        private System.Windows.Forms.TextBox tutar_box;
        private System.Windows.Forms.Label tutar;
    }
}