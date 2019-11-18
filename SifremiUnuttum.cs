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
    public partial class SifremiUnuttumcs : Form
    {
        public SifremiUnuttumcs()
        {
            InitializeComponent();
        }

        string kullanici_adi;
        string sifre;
        string sifreTekrar;
        string gizli_cevap;
        SQLiteConnection con;
        SQLiteCommand cmd;
        
        SQLiteDataAdapter da;
        log_in login = new log_in();

        private void button_bul_Click(object sender, EventArgs e)
        {
            kullanici_adi = textBox_kullaniciAdi.Text;
            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            cmd = new SQLiteCommand(con);
            con.Open();
           
            cmd.CommandText = $@"select count(*) from kullaniciBilgi where kullaniciAdi='{kullanici_adi}'";
            int varmi = Convert.ToInt32(cmd.ExecuteScalar());
            if (varmi != 0)
            {
                DataSet ds = new DataSet();
                string CommandText = $@"select gizliSoru from kullaniciBilgi where kullaniciAdi='{kullanici_adi}'";
                da = new SQLiteDataAdapter(CommandText, con);
                da.Fill(ds);
                textBox_gizliSoru.Text = ds.Tables[0].Rows[0]["gizliSoru"].ToString();
                con.Close();

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
                con.Close();

            }


               





        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sifre = textBox_yeniSifre.Text;
            sifreTekrar = textBox_yeniSifreTekrar.Text;
            gizli_cevap = textBox_gizliCevap.Text;
            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            cmd = new SQLiteCommand(con);
            con.Open();

            cmd.CommandText = $@"select count(*) from kullaniciBilgi where gizliCevap='{gizli_cevap}'";
            int varmi = Convert.ToInt32(cmd.ExecuteScalar());
            if (varmi != 0)
            {
                if (sifre==sifreTekrar)
                {
                    cmd = new SQLiteCommand($"update kullaniciBilgi set sifre='{sifre}' where kullaniciAdi='{kullanici_adi}'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bilgiler Güncellendi");
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Hatalı Cevap");
                con.Close();
            }


        }

        private void button_vazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            login.Show();
        }
    }
}
