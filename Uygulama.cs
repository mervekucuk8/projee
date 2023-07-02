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
    public partial class Uygulama : MetroForm
    {
        public Uygulama()
        {
            InitializeComponent();
        }

        private void Uygulama_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Rehber rehekran = new Rehber();
            rehekran.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Matematik matekran = new Matematik();
            matekran.Show();
            this.Hide();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Giris girisekran = new Giris();
            girisekran.Show();
            this.Hide();
        }
    }
}
