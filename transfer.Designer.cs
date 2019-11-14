namespace WindowsFormsApplication1
{
    partial class transfer
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
            this.havale_buton = new System.Windows.Forms.Button();
            this.eft_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen işlem tipini seçin:";
            // 
            // havale_buton
            // 
            this.havale_buton.Location = new System.Drawing.Point(71, 59);
            this.havale_buton.Name = "havale_buton";
            this.havale_buton.Size = new System.Drawing.Size(119, 33);
            this.havale_buton.TabIndex = 1;
            this.havale_buton.Text = "Havale";
            this.havale_buton.UseVisualStyleBackColor = true;
            this.havale_buton.Click += new System.EventHandler(this.havale_buton_Click);
            // 
            // eft_buton
            // 
            this.eft_buton.Location = new System.Drawing.Point(240, 59);
            this.eft_buton.Name = "eft_buton";
            this.eft_buton.Size = new System.Drawing.Size(119, 33);
            this.eft_buton.TabIndex = 2;
            this.eft_buton.Text = "EFT";
            this.eft_buton.UseVisualStyleBackColor = true;
            this.eft_buton.Click += new System.EventHandler(this.eft_buton_Click);
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 126);
            this.ControlBox = false;
            this.Controls.Add(this.eft_buton);
            this.Controls.Add(this.havale_buton);
            this.Controls.Add(this.label1);
            this.Name = "transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transfer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button havale_buton;
        private System.Windows.Forms.Button eft_buton;
    }
}