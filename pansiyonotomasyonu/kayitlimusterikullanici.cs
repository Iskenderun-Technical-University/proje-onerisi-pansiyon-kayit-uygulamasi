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
    public partial class kayitlimusterikullanici : Form
    {
        public kayitlimusterikullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True");

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            anaform anaformm = new anaform();
            anaformm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (kullaniciaditextbox.Text == "" || sifretextbox.Text == "")
            {
                MessageBox.Show("lutfen gerekli alanlari doldurunuz");
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from musterigiristable where kullaniciadi = @NICKNAME AND sifre =@PASSWORD", baglan);
                cmd.Parameters.AddWithValue("NICKNAME", kullaniciaditextbox.Text);
                cmd.Parameters.AddWithValue("PASSWORD", sifretextbox.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Müşteri_Sayfası müsterisay = new Müşteri_Sayfası();
                    müsterisay.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("hatali giriş!!");
                }
                baglan.Close();
                
            

            }
        }
    }
}
