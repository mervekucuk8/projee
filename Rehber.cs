using MetroFramework.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10019SelahattinSaylam
{
    public partial class Rehber : MetroForm
    {

        string vv01_str_veritabani_yolu = @"Data Source=.;Initial Catalog=SS_uygulama;Integrated Security=True";
        string vv02_str_komut_yazisi = "";
        SqlConnection vv03_con_baglanti1;
        SqlCommand vv04_cmd_komut1;
        SqlDataReader vv05_rdr_okuyucu1;
        SqlDataAdapter vv06_adp_adaptor1;
        DataTable vv07_tbl_tablo1;

     
        public Rehber()
        {
            InitializeComponent();
        }

        private void Rehber_Load(object sender, EventArgs e)
        {
            rehber_DataGridDoldur();
        }
        public void rehber_DataGridDoldur()//datagrid doldur.
        {

            vv02_str_komut_yazisi = "select " +
                 "ss_id," +
                  "ss_ad," +
                  "ss_soyad," +
                  "ss_tel_no," +             
                  "ss_tur" +
                  " from SS_Rehber";


            vv03_con_baglanti1 = new SqlConnection(vv01_str_veritabani_yolu);
            vv04_cmd_komut1 = new SqlCommand(vv02_str_komut_yazisi, vv03_con_baglanti1);
            vv06_adp_adaptor1 = new SqlDataAdapter(vv04_cmd_komut1);
            vv07_tbl_tablo1 = new DataTable();
            vv06_adp_adaptor1.Fill(vv07_tbl_tablo1);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Uygulama uygekran = new Uygulama();
            uygekran.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

      
           
            SqlCommand vv04_cmd_komut1 = new SqlCommand("select * from SS_Rehber where ss_tel_no='" + metroTextBox3.Text+"'", vv03_con_baglanti1);
            vv03_con_baglanti1.Open();//bağlantıyı açdık
            SqlDataReader vv05_rdr_okuyucu1 = vv04_cmd_komut1.ExecuteReader();//veriyi okutma emrini verdik
            if (vv05_rdr_okuyucu1.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {
                MessageBox.Show("Telefon Zaten Kayıtlı.");
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
            }

            else if (string.IsNullOrEmpty(metroTextBox1.Text) || string.IsNullOrEmpty(metroTextBox2.Text) || string.IsNullOrEmpty(metroTextBox3.Text) || string.IsNullOrEmpty(metroTextBox4.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
            }
            else
            {
                ssrehber_islemi aa = new ssrehber_islemi();

                aa.ssrehber_01_ad_str = metroTextBox1.Text;
                aa.ssrehber_02_soyad_str = metroTextBox2.Text;
                aa.ssrehber_03_telefon_str =metroTextBox3.Text;
                aa.ssrehber_04_tur_str = metroTextBox4.Text;
            

                vv02_str_komut_yazisi = "insert into SS_Rehber(" +
                  "ss_ad," +
                  "ss_soyad," +
                  "ss_tel_no," +
                  "ss_tur" +
                  ")" +
                  " values (" +
                  "@ss_ad," +
                  "@ss_soyad," +
                  "@ss_tel_no," +
                  "@ss_tur" +
                  ")";

                vv03_con_baglanti1 = new SqlConnection(vv01_str_veritabani_yolu);
                vv04_cmd_komut1 = new SqlCommand(vv02_str_komut_yazisi, vv03_con_baglanti1);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_ad", aa.ssrehber_01_ad_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_soyad", aa.ssrehber_02_soyad_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_tel_no", aa.ssrehber_03_telefon_str);
                vv04_cmd_komut1.Parameters.AddWithValue("@ss_tur", aa.ssrehber_04_tur_str);
              

                vv03_con_baglanti1.Open();
                vv04_cmd_komut1.ExecuteNonQuery();
                vv04_cmd_komut1.Dispose();
                vv03_con_baglanti1.Close();
                rehber_DataGridDoldur();
                MessageBox.Show("Kayıt edilmiştir.");
               
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string arama_telno = metroTextBox5.Text;

            vv02_str_komut_yazisi = "select " +
                "ss_id,"+
                 "ss_ad," +
                  "ss_soyad," +
                  "ss_tel_no," +
                  "ss_tur" +

                  " from SS_Rehber" +
                  " where ss_tel_no like'%" + arama_telno + "%' " +
                  " order by ss_id ";


            vv03_con_baglanti1 = new SqlConnection(vv01_str_veritabani_yolu);
            vv04_cmd_komut1 = new SqlCommand(vv02_str_komut_yazisi, vv03_con_baglanti1);

            vv04_cmd_komut1.Parameters.AddWithValue("@ss_tel_no", arama_telno);

            vv06_adp_adaptor1 = new SqlDataAdapter(vv04_cmd_komut1);
            vv07_tbl_tablo1 = new DataTable();
            vv06_adp_adaptor1.Fill(vv07_tbl_tablo1);

           
        }
    }
}
