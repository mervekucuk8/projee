using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10019SelahattinSaylam
{
    struct sskullanici_islemi
    {
        public int sskullanici_00_id_int;
        public string sskullanici_01_adi_str;
        public string sskullanici_02_soyadi_str;
        public DateTime sskullanici_03_dogum_tarihi_dt;
        public string sskullanici_04_kullanici_adi_str;
        public string sskullanici_05_sifre_str;
        public int sskullanici_06_yas_int;
        public string sskullanici_07_cinsiyet_str;
    }
    struct ssrehber_islemi
    {
        public int ssrehber_00_id_int;
        public string ssrehber_01_ad_str;
        public string ssrehber_02_soyad_str;
        public string ssrehber_03_telefon_str;
        public string ssrehber_04_tur_str;

    }
    struct ssmat_islemi
    {
        public int ssrehber_00_id_int;
        public int ssmat_01_puan_int;
        
    }

    public partial class Giris : MetroForm
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            metroTextBox2.PasswordChar = '*';

            Random rastgele = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz0123456789*#!><,.";
            string uret = "";
            for (int i = 0; i < 9; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            metroLabel4.Text=uret;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection vv03_con_baglanti1 = new SqlConnection(@"Data Source=.;Initial Catalog=SS_uygulama;Integrated Security=True");
            //sql bağlantıyı sağladık
            SqlCommand vv04_cmd_komut1 = new SqlCommand("select * from SS_Kullanici where ss_kullanici_adi='" + metroTextBox1.Text + "' and ss_sifre ='" + metroTextBox2.Text + "'", vv03_con_baglanti1);
            //sql komutumuzu yazdık komutta veritabanındaki giris tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyi
            // çekmesini istedik
            vv03_con_baglanti1.Open();//bağlantıyı açdık

            SqlDataReader vv05_rdr_okuyucu1 = vv04_cmd_komut1.ExecuteReader();//veriyi okutma emrini verdik
            if (vv05_rdr_okuyucu1.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {
                if (metroTextBox3.Text==metroLabel4.Text )
                {
                    MessageBox.Show("Giriş Başarılı !");//giriş başarılı diye uyari verir
                    vv03_con_baglanti1.Close();//bağlantıyı kapar
                    Uygulama menuu = new Uygulama();
                    menuu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Güvenlik kodu aynı değil !");//güvenlik kodu yanlış uyarısı verir.
                }
 
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış !");//hayır veri okuyamadıysa uyarı verir
                metroTextBox1.Text = "";//verileri temizler
                metroTextBox2.Text = "";//verileri temizler
                metroTextBox3.Text = "";//verileri temizler
                metroLabel4.Text = "";

                Random rastgele = new Random();
                string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz0123456789*#!><,.";
                string uret = "";
                for (int i = 0; i < 9; i++)
                {
                    uret += harfler[rastgele.Next(harfler.Length)];
                }
                metroLabel4.Text = uret;
            }
        }

       
        private void metroButton2_Click(object sender, EventArgs e)
        {
            YeniKullanici menu = new YeniKullanici();//yeni bir menü sayfası oluşturur.
            menu.Show();//menü sayfasını açar.
            this.Hide();//mevcut sayfayı kapatır.
        }
    }
}
