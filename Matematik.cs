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
            SSmetroButton1.Enabled= false;
           

          
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

            SSmetroTextBox1.Text = rand_num.ToString();
            SSmetroTextBox2.Text = rand_num2.ToString();
            SSmetroTextBox10.Text = islem.ToString();

            a = Convert.ToInt32(SSmetroTextBox1.Text);
            b = Convert.ToInt32(SSmetroTextBox2.Text);

            if (islem == 1)
            {
                SSmetroTextBox10.Text = "+";
                toplam = a + b;
                SSmetroTextBox13.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                SSmetroTextBox10.Text = "-";
                cıkar = a - b;
                SSmetroTextBox13.Text = cıkar.ToString();
            }
            else if (islem == 3)
            {
                SSmetroTextBox10.Text = "*";
                carp = a * b;
                SSmetroTextBox13.Text = carp.ToString();
            }
            else if (islem == 4)
            {
                SSmetroTextBox10.Text = "/";
                böl = a / b;
                SSmetroTextBox13.Text = böl.ToString();
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

            SSmetroTextBox1.Text = rand_num.ToString();
            SSmetroTextBox2.Text = rand_num2.ToString();
            SSmetroTextBox10.Text = islem.ToString();

            a = Convert.ToInt32(SSmetroTextBox1.Text);
            b = Convert.ToInt32(SSmetroTextBox2.Text);

            if (islem == 1)
            {
                SSmetroTextBox10.Text = "+";
                toplam = a + b;
                SSmetroTextBox13.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                SSmetroTextBox10.Text = "-";
                cıkar = a - b;
                SSmetroTextBox13.Text = cıkar.ToString();
            }
            else if (islem == 3)
            {
                SSmetroTextBox10.Text = "*";
                carp = a * b;
                SSmetroTextBox13.Text = carp.ToString();
            }
            else if (islem == 4)
            {
                SSmetroTextBox10.Text = "/";
                böl = a / b;
                SSmetroTextBox13.Text = böl.ToString();
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

            SSmetroTextBox1.Text = rand_num.ToString();
            SSmetroTextBox2.Text = rand_num2.ToString();
            SSmetroTextBox10.Text = islem.ToString();

            a = Convert.ToInt32(SSmetroTextBox1.Text);
            b = Convert.ToInt32(SSmetroTextBox2.Text);

            if (islem == 1)
            {
                SSmetroTextBox10.Text = "+";
                toplam = a + b;
                SSmetroTextBox13.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                SSmetroTextBox10.Text = "-";
                cıkar = a - b;
                SSmetroTextBox13.Text = cıkar.ToString();
            }
            else if (islem == 3)
            {
                SSmetroTextBox10.Text = "*";
                carp = a * b;
                SSmetroTextBox13.Text = carp.ToString();
            }
            else if (islem == 4)
            {
                SSmetroTextBox10.Text = "/";
                böl = a / b;
                SSmetroTextBox13.Text = böl.ToString();
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SSmetroButton1.Enabled = false;
            SSmetroButton2.Enabled = true;
         
            if (SSmetroTextBox13.Text==SSmetroTextBox9.Text)
            {
                puan =puan + 10;
                SSmetroTextBox11.Text = puan.ToString();
            }
            else
            {
                puan=puan - 10;
                SSmetroTextBox11.Text = puan.ToString();  
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SSmetroButton2.Enabled = false;
            SSmetroButton1.Enabled = true;
            SSmetroTextBox9.Text = "";
            

            if (SSmetroComboBox1.SelectedIndex==0)
            {
                kolay_random_sayi_olustur();

            }
            else if (SSmetroComboBox1.SelectedIndex == 1)
            {
                orta_random_sayi_olustur();

            }
            else if (SSmetroComboBox1.SelectedIndex==2)
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
