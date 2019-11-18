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
    public partial class mmenu : Form
    {
        
        
        public mmenu()
        {
            
            InitializeComponent();
            
            
        }
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        DataSet ds = new DataSet(); //ileride veritaanından aldığımız bilgileri tutmak için dataset tanımladık.





        private void mmenu_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            cmd = new SQLiteCommand(con);
            con.Open();
            string CommandText = $@"select bakiye from kullaniciBilgi where aktifmi=1";
            da = new SQLiteDataAdapter(CommandText, con);
            da.Fill(ds); //oluşturduğumuz dataset e veritabnından gelen bilgileri doldurduk.

            label2.Text = ds.Tables[0].Rows[0]["bakiye"].ToString(); //bakiye alanımıza veritabından alıp doldurduğumuz data setten bakiye kolonunda bulunan veriyi atadık.
            con.Close();
        }

        private void para_yatir_Click(object sender, EventArgs e)
        {
            ParaYatir ekle = new ParaYatir();
            ekle.Show();
            this.Hide();
            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void fatura_button_Click(object sender, EventArgs e)
        {
            fatura ode = new fatura();
            ode.Show();
            this.Hide();
        }

        private void para_cek_Click(object sender, EventArgs e)
        {
            paracek cek = new paracek();
            cek.Show();
            this.Hide();
        }

        private void transfer_buton_Click(object sender, EventArgs e)
        {
            transfer gonder = new transfer();
            gonder.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = $@"update kullaniciBilgi set aktifmi=0";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            Application.Exit();
        }



        ~mmenu()  //sınıfımızın yıkıcı metodunu oluşturduk.
        {
            //bu metot sayesinde sınıfın kullanımı bitince veritabanına bağlanıp aktif olan kullanıcının aktifmi kolonunu 0 yapmasını sağladık. böylece ileride giriş yapacak kullanıcı ile bilgileri karışmayacak.
            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = $@"update kullaniciBilgi set aktifmi=0";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    
}
