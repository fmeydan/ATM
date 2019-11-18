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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
        {
            InitializeComponent();
        }
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        DataSet ds;
        SQLiteDataAdapter da;
        double tutar;
        double bakiye;
        mmenu anamenu = new mmenu();
        private void textBox_tutar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button_vazgeç_Click(object sender, EventArgs e)
        {
            this.Hide();
            anamenu.Show();
        }

        private void button_tamam_Click(object sender, EventArgs e)
        {
            
            
            if (!string.IsNullOrWhiteSpace(textBox_tutar.Text))
            {
                tutar = Convert.ToDouble(textBox_tutar.Text);
                con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
                cmd = new SQLiteCommand(con);
                con.Open();
                ds = new DataSet();
                string CommandText = $@"select * from kullaniciBilgi where aktifmi=1";
                da = new SQLiteDataAdapter(CommandText, con);
                da.Fill(ds);
                bakiye =Convert.ToDouble( ds.Tables[0].Rows[0]["bakiye"]);
                cmd.CommandText = $@"update kullaniciBilgi set bakiye={bakiye}+{tutar} where aktifmi=1";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            anamenu.Show();
            this.Hide();
        }
    }
}
