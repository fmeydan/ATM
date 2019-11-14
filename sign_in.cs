using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SQLite;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class sign_in : Form
    {

        public sign_in()
        {
            InitializeComponent();

        }
        SQLiteCommand cmd;
        SQLiteConnection con;
       

        private void vazgec_buton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tamam_buton_Click(object sender, EventArgs e)
        {

            string kullanciAdi = kAdi_box.Text;
            string sifre = sifre_box.Text;


            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            con.Open();

            try
            {

                cmd = new SQLiteCommand(con);
                cmd.CommandText = $@"select count(*) from kullaniciBilgi where kullaniciAdi='{kullanciAdi}'";
                int varmi = Convert.ToInt32(cmd.ExecuteScalar());
                if (varmi == 0)
                {
                    cmd.CommandText = $@"insert into kullaniciBilgi (kullaniciAdi,sifre) values ('{kullanciAdi}','{sifre}')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kişi eklendi");
                    kAdi_box.Clear();
                    sifre_box.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu kişi kayıtlı");
                    con.Close();
                }


                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }


        private void sign_in_Load(object sender, EventArgs e)
        {
            if (!File.Exists("kullanicilar.db"))
            {
                SQLiteConnection.CreateFile("kullanicilar.db");

                string sql = @"CREATE TABLE kullaniciBilgi(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT ,
                               kullaniciAdi           TEXT      NOT NULL,
                               sifre            TEXT       NOT NULL
                            );";
                con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
