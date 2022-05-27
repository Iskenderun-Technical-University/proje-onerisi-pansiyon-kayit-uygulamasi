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
        public static string kullanicisession;
        SqlCommand cmd;
        SqlConnection con;
        public static string baglan = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        public kayitlimusterikullanici()
        {
            InitializeComponent();
        }
        
        
        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            
            anaform anaformm = new anaform();
            anaformm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection(baglan);
            
            if (kullaniciaditextbox.Text == "" || sifretextbox.Text == "")
            {
                MessageBox.Show("lutfen gerekli alanlari doldurunuz");
            }
            else
            {
                
                string select = "select * from yenikullanici where kullaniciadi=@user and sifre= @password";
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@user", kullaniciaditextbox.Text);
                cmd.Parameters.AddWithValue("@password", sifretextbox.Text);
                con.Open();
                cmd.CommandText = select;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                
                
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kullanicisession = kullaniciaditextbox.Text;
                    bosform frm = new bosform();
                    frm.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("hatali giriş!!");
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sifreyenile sifreyenilee = new sifreyenile();
            sifreyenilee.Show();
            this.Hide();
            
        }

        private void kayitlimusterikullanici_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
