using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10019SelahattinSaylam
{
    public partial class Matematik : MetroForm
    {
        public Matematik()
        {
            InitializeComponent();
        }

        private void Matematik_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Uygulama uygekran = new Uygulama();
            uygekran.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            kolay_random_sayi_olustur();
        }

        public void kolay_random_sayi_olustur()
        {
            Random rastgele = new Random();
            int rand_num = rastgele.Next(1, 99);
          

        }
        public void orta_random_sayi_olustur(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int rand_num = rastgele.Next(1, 999);
        }
        public void zor_random_sayi_olustur(object sender, EventArgs e)
        {

            Random rastgele = new Random();
            int rand_num = rastgele.Next(1, 9999);
        }
    }
}
