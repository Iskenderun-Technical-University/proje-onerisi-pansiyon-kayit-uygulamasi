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
using System.Data.Sql;

namespace pansiyonotomasyonu
{
    public partial class yenikullanici : Form
    {

        public yenikullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            anaform anaformm = new anaform();
            anaformm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into yenikullanici (ad,soyad,kullaniciadi,sifre,[telefon no],[t.c no]) values('" + adtextbox.Text+"','"+soyadtextbox.Text+"','"+textBox4.Text+"','"+sifretextbox.Text+"','"+numaratextbox.Text+"','"+TCtextBox.Text+"')",baglanti);
            SqlCommand komutt = new SqlCommand("insert into musterigiristable(kullaniciadi,sifre) values('"+textBox4.Text+"','"+sifretextbox.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            komutt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT yapıldı...");
        }
    }
}
