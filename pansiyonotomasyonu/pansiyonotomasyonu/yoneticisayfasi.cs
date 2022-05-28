using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonotomasyonu
{
    public partial class yoneticisayfasi : Form
    {
        public yoneticisayfasi()
        {
            InitializeComponent();
        }

        private void yoneticisayfasi_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yoneticimusteriislemleri islem = new yoneticimusteriislemleri();
            islem.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            etkinlikform formm = new etkinlikform();
            formm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odadurumu frm = new odadurumu();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            yoneticiucretlendirme ac = new yoneticiucretlendirme();
       
            ac.Show();
            this.Hide();
        }
    }
}
