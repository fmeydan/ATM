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
            textbox_sifre.PasswordChar = '*';// şifre girilen kutuda girilen karekterleri gizleme için * simgesini ayarladık.


        }
        sign_in kayit = new sign_in();

        SQLiteConnection con;
        SQLiteCommand cmd;
        private String _kullaniciAdi { get; set; }
        public string kullaniciAdi
        {
            /*
           kullanıcı adı  ve şifre kısmını oop nin temellerinden encapsulation ile kapsülledik. bu sayede SqlInjection dan korunma sağladık.

           Kullanıcı adı girildiğinde kullanıma alınmadan önce public kullanıcı adı değişkenine gelir 
           ve bu değişkenin setter ında kontorller yapılır. SqlInjection için en çok kullanılan karakterleri engelleyerek kullanıcaya mesaj verdik. 
           Daha sonra kullanıcı kurallara uygun bir kullanıcı adı seçtiyse bu private olarak tanımladığımız _kullaniciAdi na gönderilir.

           Aynı şeyler şifre içinde geçerli.
       */
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
            if (Properties.Settings.Default.ayar == true) //FOrm ekranı ilk açılırken uygulamamızın hafızasındaki  özelliklerinden (propertie) ayar kısmına bakar. Eğer ayar özelliği true ise kullanıcı adını ve şifresiyi gerekli bölümlere otomatik doldurur. böylece beni hatıla özelliği çalışmış olur.
            {
                textbox_kullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
                textbox_sifre.Text = Properties.Settings.Default.sifre;
                checkBox_beniHatirla.Checked = true;
            }
        }

        private void kayit_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //kullanıcı kayıt ol linkine tıkladıysa kayıt olma sayfasına yönlendirilir.
            kayit.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            //giriş butonuna tıklandıysa uygulama sırasıyla şunları yapar.
            if (string.IsNullOrWhiteSpace(textbox_kullaniciAdi.Text) || string.IsNullOrWhiteSpace(textbox_sifre.Text))
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
            else
            {
                kullaniciAdi = textbox_kullaniciAdi.Text; //kullaniciAdi değişkenine textboxta bulunan veriyi gönderir.

                sifreiste = textbox_sifre.Text;//yukarıdaki işlemin aynısı şifre içinde yapılır.

                con = new SQLiteConnection("Data Source=kullanicilar.db;Version=3;");//sqlite ın connection classının kurucu metoduna hangi veritabanına bağlanacağını gösteren string gönderilerek örnekleme(instance) alınır.

                con.Open(); //veritabanı ile bağlantıyı sqliteconncetion dan aldığımız örneğin open metoduyla açtık.

                cmd = new SQLiteCommand(con); // Sqlite ın SQliteCommand classından kurucu metoduna SqliteConnection dan aldığımız örneği göndererek örnek aldık.

                cmd.CommandText = $@"select count(*) from kullaniciBilgi where kullaniciAdi='{kullaniciAdi}' and sifre='{sifreiste}'"; //SqliteCommand dan aldığımız örneğin CommandTextine sql sorgu stringini atadık.Bu string veritabanında girilen kullanıcı adı ve şifreyle uyumla olan satır sayısını döndürmek üzere oluşturuldu. 

                int varmi = Convert.ToInt32(cmd.ExecuteScalar());//var mi olarak bir değişken tanımladık ve SqliteCommanddan aldığımız örneğin ExecuteScalar metodunu çalıştırarak gelen değeri tür dönüşümü(casting) yaparak atadık. bu metot cmd.CommandText teki sorguyu çalıştırır ve sonucunda kaç satır oluşuyorsa onu sayısal olarak geri döndürür.

                if (varmi != 0) //Gelen satır sayısının sıfırdan farklı olup olmadığına baktık. eğer 0 dan farklıysa böyle bir kullanıcı kayıtlıdır. eğer değilse böyle bir kullanıcı henüz veritabanına kayıt edilmemiştir demek.
                {

                    cmd.CommandText = $@"update kullaniciBilgi set aktifmi=1 where kullaniciAdi='{kullaniciAdi}'";//veritabanına şu anda kim giriş yaptıysa onun aktifmi kısmını 1 yapmasını sağlayan sorguyu göndermek üzere hazırladık.
                    cmd.ExecuteNonQuery(); //hazırladığımız sorguyu veritabanına gönderdik.

                    if (checkBox_beniHatirla.Checked) // beni hatırla seçeneği seçili ise aşağıdaki kodlar çalışacaktır.
                    {
                        //uygulamamızın properties kısmından ön tanımlı alanlar oluşturduk.
                        //bunlardan biri kullanıcı adı, diğeri şifre ve son olarak beni hatırla özelliğinin açık mı kapalı mı olduğunu kaydetmek için ayar adında boolean tipinde bir alan oluşturduk.

                        Properties.Settings.Default.kullaniciAdi = _kullaniciAdi; //Kullanıcı adı kısmına girilen kullanıcı adını gönderdik.

                        Properties.Settings.Default.sifre = _sifreiste;//şifre kısmına girilen şifreyi gönderdik.

                        Properties.Settings.Default.ayar = true; //Bilgileri hatırlaması için ayar kısmını true yaptık.

                        Properties.Settings.Default.Save();//bilgileri kaydettik.

                    }
                    else
                    {
                        //işaret seçili değilse alanları boşalttık ve ayar kısmını false yaptık.
                        //böylece beni hatırla seçimi kaldırıldığında uygulama hafızasında veriler tutulmayacak.
                        Properties.Settings.Default.kullaniciAdi = null;
                        Properties.Settings.Default.sifre = null;
                        Properties.Settings.Default.ayar = false;
                        Properties.Settings.Default.Save();


                    }
                    mmenu anamenu = new mmenu();//ana menümüz olan formdan örnek aldık.
                    anamenu.Show();//aldığımız örneğin show metoduyla ekrana gelmesini sağladık.
                    con.Close();//yukarıda açtığımız bağlantıyı burda kapatıyoruz.
                    this.Hide();//login sayfamızla işimiz olmadığı için gizliyoruz.

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve şifre uyuşmuyor");
                    con.Close();
                }

            }
        }
        private void sifremi_unuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttumcs sifreYenile = new SifremiUnuttumcs();
            sifreYenile.Show();
            this.Hide();
        }
    }
}
