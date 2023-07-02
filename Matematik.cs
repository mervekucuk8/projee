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
    public partial class Matematik : MetroForm
    {
  
        int puan=0;
        public Matematik()
        {
            InitializeComponent();
        }

        private void Matematik_Load(object sender, EventArgs e)
        {
            metroButton1.Enabled= false;
           

          
        }
 
        private void metroLink1_Click(object sender, EventArgs e)
        {
            Uygulama uygekran = new Uygulama();
            uygekran.Show();
            this.Hide();
        }

        private void metroButton2_Click()
        {
            kolay_random_sayi_olustur();
        }
       

        public void kolay_random_sayi_olustur()
        {
            Random rastgele = new Random();
            int rand_num = rastgele.Next(1, 99);
            int rand_num2 = rastgele.Next(1, 9);
            int islem = rastgele.Next(1, 5);
            int toplam, cıkar, carp, böl;
            int a, b;

            metroTextBox1.Text = rand_num.ToString();
            metroTextBox2.Text = rand_num2.ToString();
            metroTextBox10.Text = islem.ToString();

            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);

            if (islem == 1)
            {
                metroTextBox10.Text = "+";
                toplam = a + b;
                metroTextBox13.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                metroTextBox10.Text = "-";
                cıkar = a - b;
                metroTextBox13.Text = cıkar.ToString();
            }
            else if (islem == 3)
            {
                metroTextBox10.Text = "*";
                carp = a * b;
                metroTextBox13.Text = carp.ToString();
            }
            else if (islem == 4)
            {
                metroTextBox10.Text = "/";
                böl = a / b;
                metroTextBox13.Text = böl.ToString();
            }
        }
        public void orta_random_sayi_olustur()
        {
            Random rastgele = new Random();
            int rand_num = rastgele.Next(1, 999);
            int rand_num2=rastgele.Next(1,999);
            int islem = rastgele.Next(1, 5);
            int toplam, cıkar, carp, böl;
            int a, b;

            metroTextBox1.Text = rand_num.ToString();
            metroTextBox2.Text = rand_num2.ToString();
            metroTextBox10.Text = islem.ToString();

            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);

            if (islem == 1)
            {
                metroTextBox10.Text = "+";
                toplam = a + b;
                metroTextBox13.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                metroTextBox10.Text = "-";
                cıkar = a - b;
                metroTextBox13.Text = cıkar.ToString();
            }
            else if (islem == 3)
            {
                metroTextBox10.Text = "*";
                carp = a * b;
                metroTextBox13.Text = carp.ToString();
            }
            else if (islem == 4)
            {
                metroTextBox10.Text = "/";
                böl = a / b;
                metroTextBox13.Text = böl.ToString();
            }

        }
        public void zor_random_sayi_olustur()
        {

            Random rastgele = new Random();
            int rand_num = rastgele.Next(1, 9999);
            int rand_num2 = rastgele.Next(1, 9999);
            int islem = rastgele.Next(1, 5);
            int toplam, cıkar, carp, böl;
            int a, b;

            metroTextBox1.Text = rand_num.ToString();
            metroTextBox2.Text = rand_num2.ToString();
            metroTextBox10.Text = islem.ToString();

            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);

            if (islem == 1)
            {
                metroTextBox10.Text = "+";
                toplam = a + b;
                metroTextBox13.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                metroTextBox10.Text = "-";
                cıkar = a - b;
                metroTextBox13.Text = cıkar.ToString();
            }
            else if (islem == 3)
            {
                metroTextBox10.Text = "*";
                carp = a * b;
                metroTextBox13.Text = carp.ToString();
            }
            else if (islem == 4)
            {
                metroTextBox10.Text = "/";
                böl = a / b;
                metroTextBox13.Text = böl.ToString();
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
            metroButton2.Enabled = true;
         
            if (metroTextBox13.Text==metroTextBox9.Text)
            {
                puan =puan + 10;
                metroTextBox11.Text = puan.ToString();
            }
            else
            {
                puan=puan - 10;
                metroTextBox11.Text = puan.ToString();  
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroButton2.Enabled = false;
            metroButton1.Enabled = true;
            metroTextBox9.Text = "";
            

            if (metroComboBox1.SelectedIndex==0)
            {
                kolay_random_sayi_olustur();

            }
            else if (metroComboBox1.SelectedIndex == 1)
            {
                orta_random_sayi_olustur();

            }
            else if (metroComboBox1.SelectedIndex==2)
            {
                zor_random_sayi_olustur();
            }
            else
            {
                MessageBox.Show("Geçerli bir seviye seçin");
            }
            
        }
    }
}
