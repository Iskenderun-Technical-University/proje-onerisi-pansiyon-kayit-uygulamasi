using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pansiyonotomasyonu
{
    public partial class anaform : Form
    {
        

        public anaform()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True");

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenikullanici frm = new yenikullanici();
            frm.Show();
            this.Hide();
        }

        private void kayıtlıKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitlimusterikullanici kyt = new kayitlimusterikullanici();
            kyt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yoneticigirispaneli panel = new yoneticigirispaneli();
            panel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hizmetligirispanel hizmetli = new hizmetligirispanel();
            hizmetli.Show();
            this.Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void anaform_Load(object sender, EventArgs e)
        {

        }
    }
}
