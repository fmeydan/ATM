using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class eft : Form
    {
        public eft()
        {
            InitializeComponent();
        }
        mmenu anamenu = new mmenu();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hesa_no_box_TextChanged(object sender, EventArgs e)
        {
            hesa_no_box.MaxLength = 14;
        }

        private void eft_no_box_TextChanged(object sender, EventArgs e)
        {
            eft_no_box.MaxLength = 24;
        }

        private void tutar_box_TextChanged(object sender, EventArgs e)
        {
    
          }

        private void tamam_buton_Click(object sender, EventArgs e)
        {
            if (ekle_form.bakiye >= Convert.ToDouble(tutar_box.Text))
            {
                ekle_form.bakiye = ekle_form.bakiye - Convert.ToDouble(tutar_box.Text);
                this.Hide();
                anamenu.Show();
            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tutar_box.Text = string.Empty;
            }
    }

        private void vazgec_buton_Click(object sender, EventArgs e)
        {
            
            anamenu.Show();
            this.Hide();
        }

        private void eft_Load(object sender, EventArgs e)
        {

        }

        private void hesa_no_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void eft_no_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tutar_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
