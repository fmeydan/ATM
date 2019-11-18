namespace WindowsFormsApplication1
{
    partial class ParaYatir
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
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.button_tamam = new System.Windows.Forms.Button();
            this.button_vazgeç = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yatırmak istenilen tutarı giriniz:";
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Location = new System.Drawing.Point(185, 52);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(197, 20);
            this.textBox_tutar.TabIndex = 1;
            // 
            // button_tamam
            // 
            this.button_tamam.Location = new System.Drawing.Point(185, 97);
            this.button_tamam.Name = "button_tamam";
            this.button_tamam.Size = new System.Drawing.Size(88, 23);
            this.button_tamam.TabIndex = 2;
            this.button_tamam.Text = "Tamam";
            this.button_tamam.UseVisualStyleBackColor = true;
            this.button_tamam.Click += new System.EventHandler(this.button_tamam_Click);
            // 
            // button_vazgeç
            // 
            this.button_vazgeç.Location = new System.Drawing.Point(294, 97);
            this.button_vazgeç.Name = "button_vazgeç";
            this.button_vazgeç.Size = new System.Drawing.Size(88, 23);
            this.button_vazgeç.TabIndex = 3;
            this.button_vazgeç.Text = "Vazgeç";
            this.button_vazgeç.UseVisualStyleBackColor = true;
            this.button_vazgeç.Click += new System.EventHandler(this.button_vazgeç_Click);
            // 
            // ParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 152);
            this.Controls.Add(this.button_vazgeç);
            this.Controls.Add(this.button_tamam);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.label1);
            this.Name = "ParaYatir";
            this.Text = "ParaYatir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.Button button_tamam;
        private System.Windows.Forms.Button button_vazgeç;
    }
}