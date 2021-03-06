﻿using System;
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
    public partial class fatura : Form
    {

        mmenu anamenu = new mmenu();
        public fatura()
        {
            InitializeComponent();
        }

        private void fatura_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fatura_tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void ode_Click(object sender, EventArgs e)
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

            if (!string.IsNullOrEmpty(kurum.Text))
            {



                if (!string.IsNullOrEmpty(fatura_tutar.Text))
                {

                    if (mevcutBakiye >= Convert.ToDouble(fatura_tutar.Text))
                    {
                        yeniBakiye = mevcutBakiye - Convert.ToDouble(fatura_tutar.Text);
                        cmd = new SQLiteCommand($"update kullaniciBilgi set bakiye={yeniBakiye} where aktifmi=1", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        anamenu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Hesapta yeterli bakiye bulunmamaktadır", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fatura_tutar.Text = string.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Tutar Yazınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Lütfen Kurum Seçiniz.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



        }

        private void vazgec_Click(object sender, EventArgs e)
        {

            this.Hide();
            anamenu.Show();
        }

        private void fatura_tutar_KeyPress(object sender, KeyPressEventArgs e)
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
