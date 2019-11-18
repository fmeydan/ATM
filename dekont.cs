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
    public partial class dekont : Form
    {
        mmenu d1 = new mmenu();
        public dekont()
        {
            InitializeComponent();
        }

        private void evet_buton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen dekontunuzu almayı unutmayınız.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d1.Show();
            this.Hide();
            
        }

        private void hayir_buton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen paranızı almayı unutmayınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d1.Show();
            this.Hide();
        }
    }
}
