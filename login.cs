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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            textbox_sifre.PasswordChar = '*';
            
           
        }
        sign_in kayit = new sign_in();
        
        SQLiteConnection con;
        SQLiteCommand cmd;
        private String _kullaniciAdi { get; set; }
        public string kullaniciAdi
        {
            get { return _kullaniciAdi; }
            set
            {
                if (value.Contains("@") || value.Contains("=") || value.Contains("!") || value.Contains(" ") || string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Özel karekter kullanmayınız");
                }
                else
                {
                    _kullaniciAdi = value;
                }
            }
        }
        private String _sifreiste { get; set; }
        public string sifreiste
        {
            get { return _sifreiste; }
            set
            {
                if (value.Contains("@") || value.Contains("=") || value.Contains("!") || value.Contains(" ") || string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Özel karekter kullanmayınız");
                }
                else
                {
                    _sifreiste = value;
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ayar==true)
            {
                textbox_kullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
                textbox_sifre.Text = Properties.Settings.Default.sifre;
                checkBox_beniHatirla.Checked = true;
            }
        }

        private void kayit_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayit.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            kullaniciAdi = textbox_kullaniciAdi.Text;
            sifreiste = textbox_sifre.Text;
            con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = $@"select count(*) from kullaniciBilgi where kullaniciAdi='{kullaniciAdi}' and sifre='{sifreiste}'";
            
            int varmi = Convert.ToInt32(cmd.ExecuteScalar());
            if (varmi!=0)
            {
                cmd.CommandText = $@"update kullaniciBilgi set aktifmi=1 where kullaniciAdi='{kullaniciAdi}'";
                cmd.ExecuteNonQuery();
                if (checkBox_beniHatirla.Checked)
                {
                    Properties.Settings.Default.kullaniciAdi = _kullaniciAdi;
                    Properties.Settings.Default.sifre = _sifreiste;
                    Properties.Settings.Default.ayar = true;

                    Properties.Settings.Default.Save();

                }
                else
                {
                    Properties.Settings.Default.kullaniciAdi=null;
                    Properties.Settings.Default.sifre = null;
                    Properties.Settings.Default.ayar = false;
                    Properties.Settings.Default.Save();


                }
                mmenu anamenu = new mmenu();
                anamenu.Show();
                con.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre uyuşmuyor");
                con.Close();
            }

        }
    }
}
