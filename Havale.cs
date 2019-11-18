using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }
        mmenu anamenu = new mmenu();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            havale_box.MaxLength = 10;

        }

        private void tamam_buton_Click(object sender, EventArgs e)
        {
            string CommandText = $@"select bakiye from kullaniciBilgi where aktifmi=1";
            SQLiteConnection con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand(con);
            con.Open();
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(CommandText, con);
            da.Fill(ds);
            double mevcutBakiye = Convert.ToDouble(ds.Tables[0].Rows[0]["bakiye"]);
            double yeniBakiye;
            if (mevcutBakiye >= Convert.ToDouble(tutar_box.Text))
            {
                yeniBakiye = mevcutBakiye - Convert.ToDouble(tutar_box.Text);
               
                cmd = new SQLiteCommand($"update kullaniciBilgi set bakiye={yeniBakiye} where aktifmi=1", con);
                cmd.ExecuteNonQuery();
                con.Close();
                anamenu.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Hesapta yeterli bakiye bulunmamaktadır", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tutar_box.Text = string.Empty;
            }
        }

        private void vazgec_buton_Click(object sender, EventArgs e)
        {
            
            anamenu.Show();
            this.Hide();
        }

        private void havale_box_KeyPress(object sender, KeyPressEventArgs e)
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
