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
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
        }

        private void havale_buton_Click(object sender, EventArgs e)
        {
            Havale havale = new Havale();
            havale.Show();
            this.Hide();
        }

        private void eft_buton_Click(object sender, EventArgs e)
        {
            eft eft = new eft();
            eft.Show();
            this.Hide();
        }
    }
}
