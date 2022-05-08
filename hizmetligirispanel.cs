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
    public partial class hizmetligirispanel : Form
    {
        public hizmetligirispanel()
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (kullaniciaditextbox2.Text == "" || sifretextbox2.Text == "")
            {
                MessageBox.Show("lutfen gerekli alanlari doldurunuz");
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from hizmetligiristable where kullanicad = @NICKNAME AND password=@PASSWORD",baglan);
                cmd.Parameters.AddWithValue("NICKNAME",kullaniciaditextbox2.Text);
                cmd.Parameters.AddWithValue("PASSWORD",sifretextbox2.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    bosform frm = new bosform();
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
