using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10019SelahattinSaylam
{
    public partial class YeniKullanici : MetroForm
    {
        string vv01_str_veritabani_yolu = @"Data Source=.;Initial Catalog=SS_uygulama;Integrated Security=True";
        string vv02_str_komut_yazisi = "";
        SqlConnection vv03_con_baglanti1;
        SqlCommand vv04_cmd_komut1;
        SqlDataReader vv05_rdr_okuyucu1;
        SqlDataAdapter vv06_adp_adaptor1;
        DataTable vv07_tbl_tablo1;

        public YeniKullanici()
        {
            InitializeComponent();
        }


        private void YeniKullanici_Load(object sender, EventArgs e)
        {
            kullanici_DataGridDoldur();

        }
        public void kullanici_DataGridDoldur()//datagrid doldur.
        {

            vv02_str_komut_yazisi = "select " +
                 "ss_id," +
                  "ss_adi," +
                  "ss_soyadi," +
                  "ss_dogum_tarihi," +
                  "ss_kullanici_adi," +
                  "ss_sifre," +
                  "ss_yas,"+
                  "ss_cinsiyet"+
                  " from SS_Kullanici";
                 

            vv03_con_baglanti1 = new SqlConnection(vv01_str_veritabani_yolu);
            vv04_cmd_komut1 = new SqlCommand(vv02_str_komut_yazisi, vv03_con_baglanti1);
            vv06_adp_adaptor1 = new SqlDataAdapter(vv04_cmd_komut1);
            vv07_tbl_tablo1 = new DataTable();
            vv06_adp_adaptor1.Fill(vv07_tbl_tablo1);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            //sql komutumuzu yazdık komutta veritabanındaki giris tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyiçekmesini istedik.
            SqlCommand vv04_cmd_komut1 = new SqlCommand("select * from SS_Kullanici where ss_kullanici_adi='" + metroTextBox4.Text + "' and ss_sifre ='" + metroTextBox5.Text + "'", vv03_con_baglanti1);

            vv03_con_baglanti1.Open();//bağlantıyı açdık
            SqlDataReader vv05_rdr_okuyucu1 = vv04_cmd_komut1.ExecuteReader();//veriyi okutma emrini verdik
            if (vv05_rdr_okuyucu1.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {
                MessageBox.Show("Kullanıcı Zaten Kayıtlı.");
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
                metroTextBox5.Text = "";
                metroTextBox6.Text = "";
            }

             else if (string.IsNullOrEmpty(metroTextBox1.Text) || string.IsNullOrEmpty(metroTextBox2.Text) || string.IsNullOrEmpty(metroTextBox4.Text) || string.IsNullOrEmpty(metroTextBox5.Text) || string.IsNullOrEmpty(metroTextBox6.Text) || string.IsNullOrEmpty(metroDateTime1.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");
                }
            
            else
            {
                sskullanici_islemi aa = new sskullanici_islemi();

                aa.sskullanici_01_adi_str = metroTextBox1.Text;
                aa.sskullanici_02_soyadi_str = metroTextBox2.Text;
                aa.sskullanici_03_dogum_tarihi_dt = metroDateTime1.Value;
                aa.sskullanici_04_kullanici_adi_str = metroTextBox4.Text;
                aa.sskullanici_05_sifre_str = metroTextBox5.Text;
                aa.sskullanici_06_yas_int = Convert.ToInt32(metroTextBox6.Text);
                aa.sskullanici_07_cinsiyet_str = metroTextBox3.Text;

                vv02_str_komut_yazisi = "insert into SS_Kullanici(" +
                  "ss_adi," +
                  "ss_soyadi," +
                  "ss_dogum_tarihi," +
                  "ss_kullanici_adi," +
                  "ss_sifre ," +
                  "ss_yas," +
                  "ss_cinsiyet" +
                  ")" +
                  " values (" +
                  "@ss_adi," +
                  "@ss_soyadi," +
                  "@ss_dogum_tarihi," +
                  "@ss_kullanici_adi," +
                  "@ss_sifre ," +
                  "@ss_yas," +
                  "@ss_cinsiyet" +
                  ")";

                vv03_con_baglanti1 = new SqlConnection(vv01_str_veritabani_yolu);
                vv04_cmd_komut1 = new SqlCommand(vv02_str_komut_yazisi, vv03_con_baglanti1);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_adi", aa.sskullanici_01_adi_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_soyadi", aa.sskullanici_02_soyadi_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_dogum_tarihi", aa.sskullanici_03_dogum_tarihi_dt);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_kullanici_adi", aa.sskullanici_04_kullanici_adi_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_sifre", aa.sskullanici_05_sifre_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_yas", aa.sskullanici_06_yas_int);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_cinsiyet", aa.sskullanici_07_cinsiyet_str);

                vv03_con_baglanti1.Open();
                vv04_cmd_komut1.ExecuteNonQuery();
                vv04_cmd_komut1.Dispose();
                vv03_con_baglanti1.Close();
                kullanici_DataGridDoldur();
                MessageBox.Show("Kullanıcı kayıt edilmiştir.");
            }
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Giris girisekran = new Giris();
            girisekran.Show();
            this.Hide();
        }
    }
}
