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
            string CommandText = $@"select bakiye from kullaniciBilgi where aktifmi=1";
            SQLiteConnection con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand(con);
            con.Open();
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(CommandText,con);
            da.Fill(ds);
            double mevcutBakiye = Convert.ToDouble(ds.Tables[0].Rows[0]["bakiye"]); //veritabanından sorgulayıp çektiğimiz bilgilerle doldurduğumuz datasette bulunan bakiye bölümünü mevcut bakiye diye oluşturduğumuz değişkene atadık.
            double yeniBakiye;





            if (!string.IsNullOrEmpty(para_cek_box.Text))
            { 

            if (mevcutBakiye >= Convert.ToDouble(para_cek_box.Text))
            {
                    
                    yeniBakiye = mevcutBakiye - Convert.ToDouble(para_cek_box.Text);//oluşturduğumuz yeni bakiye değişkenine mevcut bakiyeden çekilmek istenen tutarı çıkarıp kalanı atadık.
                    cmd = new SQLiteCommand($"update kullaniciBilgi set bakiye={yeniBakiye} where aktifmi=1",con); // burada SqliteCommand sınıfından örnek alırkn kurucu metoduna veritabanı komut stringini ve hangi veritabanına bağlanacağımızı belirterek oluşturduğumuz bağlantı örneğini gönderdik. böylece cmd.CommandText diye komutu hazırlamak zorunda kalmadık.
                    cmd.ExecuteNonQuery(); //komutumuzu örnek alırken kurucu metoduna yolladığımız için direk komutu çalıştırdık.
                    con.Close();
                    this.Hide();
               
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
                e.Handled = true; //burada para çekme textbox ına sadece sayısal veri girilmesi için bir özellik yazdık.
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; //burada textbox a sadece 1 kere nokta koyulabilsei için bir özellik yazdık.
            }
        }
    }
}
