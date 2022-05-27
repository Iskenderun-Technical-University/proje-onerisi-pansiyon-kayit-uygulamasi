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
    public partial class odadurumu : Form
    {
        public odadurumu()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\11.jpg");
            textboxdoldur(button1,100);
        }

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi formm = new yoneticisayfasi();
            this.Close();
            formm.Show();
        }
        public void textboxdoldur(Button button,int odanumarasi)
        {
            con = new SqlConnection(baglanti);
            con.Open();
            cmd = new SqlCommand("select * from odalarTable where odanumarasi=@number", con);
            cmd.Parameters.AddWithValue("@number",odanumarasi);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durumtextbox.Text = dr[1].ToString();
                if (durumtextbox.Text == "temiz")
                {
                    button.BackColor = Color.Green;
                }
                else if (durumtextbox.Text == "kirli")
                {
                    button.BackColor = Color.Red;
                }

                yataksayisitextbox.Text = dr[3].ToString();
                ucretlendirmetextbox.Text = dr[2].ToString();
            }

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\ciftkisilik1.jpg");
            textboxdoldur(button2,101);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\bitenZ3.jpg");
            textboxdoldur(button3, 102);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\indir.jpg");
            textboxdoldur(button4, 200);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\ciftkisilik2.jpg");
            textboxdoldur(button5, 201);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagess.jpg");
            textboxdoldur(button6, 202);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\min.jpg");
            textboxdoldur(button7, 300);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\ciftkisilik3.jpg");
            textboxdoldur(button8,301);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\images.jpg");
            textboxdoldur(button9, 302);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\tekbiryatak.jpg");
            textboxdoldur(button10, 400);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\ciftkisilik4.jpg");
            textboxdoldur(button11, 401);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagess.jpg");
            textboxdoldur(button12,402);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\tekyatak.jpg");
            textboxdoldur(button13, 500);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\ciftkisilik5.jpg");
            textboxdoldur(button14, 501);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\bitenZ3.jpg");
            textboxdoldur(button15, 502);
        }

        private void odadurumu_Load(object sender, EventArgs e)
        {

        }
    }
}
