namespace WindowsFormsApplication1
{
    partial class fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fatura));
            this.kurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatura_tutar = new System.Windows.Forms.TextBox();
            this.ode = new System.Windows.Forms.Button();
            this.vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kurum
            // 
            this.kurum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kurum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.kurum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kurum.FormattingEnabled = true;
            this.kurum.Items.AddRange(new object[] {
            "Elektrik",
            "Su",
            "Doğalgaz",
            "Telefon",
            "İnternet"});
            this.kurum.Location = new System.Drawing.Point(320, 21);
            this.kurum.Name = "kurum";
            this.kurum.Size = new System.Drawing.Size(200, 21);
            this.kurum.TabIndex = 0;
            this.kurum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen ödeme tipi seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen ödemek istediğiniz tutarı giriniz:";
            // 
            // fatura_tutar
            // 
            this.fatura_tutar.Location = new System.Drawing.Point(320, 69);
            this.fatura_tutar.Name = "fatura_tutar";
            this.fatura_tutar.Size = new System.Drawing.Size(200, 20);
            this.fatura_tutar.TabIndex = 3;
            this.fatura_tutar.TextChanged += new System.EventHandler(this.fatura_tutar_TextChanged);
            this.fatura_tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatura_tutar_KeyPress);
            // 
            // ode
            // 
            this.ode.Location = new System.Drawing.Point(320, 95);
            this.ode.Name = "ode";
            this.ode.Size = new System.Drawing.Size(75, 23);
            this.ode.TabIndex = 4;
            this.ode.Text = "Tamam";
            this.ode.UseVisualStyleBackColor = true;
            this.ode.Click += new System.EventHandler(this.ode_Click);
            // 
            // vazgec
            // 
            this.vazgec.Location = new System.Drawing.Point(445, 95);
            this.vazgec.Name = "vazgec";
            this.vazgec.Size = new System.Drawing.Size(75, 23);
            this.vazgec.TabIndex = 5;
            this.vazgec.Text = "Vazgeç";
            this.vazgec.UseVisualStyleBackColor = true;
            this.vazgec.Click += new System.EventHandler(this.vazgec_Click);
            // 
            // fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(558, 123);
            this.ControlBox = false;
            this.Controls.Add(this.vazgec);
            this.Controls.Add(this.ode);
            this.Controls.Add(this.fatura_tutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kurum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fatura";
            this.Load += new System.EventHandler(this.fatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fatura_tutar;
        private System.Windows.Forms.Button ode;
        private System.Windows.Forms.Button vazgec;
    }
}