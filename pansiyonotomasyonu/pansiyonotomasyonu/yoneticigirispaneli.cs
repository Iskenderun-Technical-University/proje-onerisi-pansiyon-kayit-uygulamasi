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
    public partial class yoneticigirispaneli : Form
    {
        public yoneticigirispaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True");

        private void yoneticigirispaneli_Load(object sender, EventArgs e)
        {

        }

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            anaform anaformm = new anaform();
            anaformm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kullaniciaditextbox1.Text == "" || sifretextbox1.Text == "")
            {
                MessageBox.Show("lutfen gerekli alanlari doldurunuz");
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from yoneticigiristable where kullaniciadii =@NICKNAME AND sifree =@PASSWORD", baglan);
                cmd.Parameters.AddWithValue("NICKNAME", kullaniciaditextbox1.Text);
                cmd.Parameters.AddWithValue("PASSWORD",sifretextbox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    yoneticisayfasi frm = new yoneticisayfasi();
                    frm.Show();
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
