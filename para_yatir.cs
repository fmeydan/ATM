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
    public partial class ekle_form : Form
    {

        public static double bakiye;
        public ekle_form()
        {
            InitializeComponent();
           
        }
        mmenu d1 = new mmenu();


        private void para_yatir_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tamam_Click(object sender, EventArgs e)
        {
            
            bakiye = bakiye + Convert.ToDouble(tutar_box.Text);
            
            this.Hide();
            d1.Show();
        }

        private void vazgec_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            d1.Show();
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
