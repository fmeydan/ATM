namespace WindowsFormsApplication1
{
    partial class dekont
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
            this.evet_buton = new System.Windows.Forms.Button();
            this.hayir_buton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // evet_buton
            // 
            this.evet_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.evet_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evet_buton.Location = new System.Drawing.Point(87, 147);
            this.evet_buton.Name = "evet_buton";
            this.evet_buton.Size = new System.Drawing.Size(130, 72);
            this.evet_buton.TabIndex = 0;
            this.evet_buton.Text = "Evet";
            this.evet_buton.UseVisualStyleBackColor = false;
            this.evet_buton.Click += new System.EventHandler(this.evet_buton_Click);
            // 
            // hayir_buton
            // 
            this.hayir_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hayir_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayir_buton.Location = new System.Drawing.Point(280, 147);
            this.hayir_buton.Name = "hayir_buton";
            this.hayir_buton.Size = new System.Drawing.Size(130, 72);
            this.hayir_buton.TabIndex = 1;
            this.hayir_buton.Text = "Hayır";
            this.hayir_buton.UseVisualStyleBackColor = false;
            this.hayir_buton.Click += new System.EventHandler(this.hayir_buton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dekont almak ister misiniz?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dekont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(463, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hayir_buton);
            this.Controls.Add(this.evet_buton);
            this.Name = "dekont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankamatik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button evet_buton;
        private System.Windows.Forms.Button hayir_buton;
        private System.Windows.Forms.Label label1;
    }
}