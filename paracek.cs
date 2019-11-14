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
    public partial class paracek : Form
    {
        dekont d2 = new dekont();
        mmenu anamenu = new mmenu();
        public paracek()
        {
            InitializeComponent();
        }

        private void buton_cek_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(para_cek_box.Text))
            { 
            if (ekle_form.bakiye >= Convert.ToDouble(para_cek_box.Text))
            {
                ekle_form.bakiye = ekle_form.bakiye - Convert.ToDouble(para_cek_box.Text);
                this.Hide();
                //anamenu.Show();
                d2.Show();
            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                para_cek_box.Text = string.Empty;
            }
           }
            else
            {
                MessageBox.Show("Lütfen Tutar Yazınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void vazgec_Click(object sender, EventArgs e)
        {
            anamenu.Show();
            this.Hide();
        }

        private void para_cek_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void para_cek_box_KeyPress(object sender, KeyPressEventArgs e)
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
