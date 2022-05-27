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
    public partial class etkinlikform : Form
    {
        public etkinlikform()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into menuveetkinlikTable(kahvaltımenu,aksamyemegimenu,etkinlik,saati) values(@sabahyemegi,@aksamyemegi,@etkinlik,@saati)";
            SqlConnection con = new SqlConnection(baglanti);
            SqlCommand cmd = new SqlCommand();
            
            cmd.Parameters.AddWithValue("@sabahyemegi", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@aksamyemegi", richTextBox2.Text);
            cmd.Parameters.AddWithValue("@etkinlik", richTextBox3.Text);
            cmd.Parameters.AddWithValue("@saati", richTextBox4.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();

             richTextBox1.Clear();
             richTextBox2.Clear();
             richTextBox3.Clear();
             richTextBox4.Clear();
             con.Close();
             MessageBox.Show("menu ve etkinlikler kaydoldu");
             griddoldur();

        }

        private void etkinlikform_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter("select * from menuveetkinlikTable", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "menuveetkinlikTable");
            dataGridView1.DataSource = ds.Tables["menuveetkinlikTable"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sql = "delete from menuveetkinlikTable";
            cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@id", textBox2.Text);
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();//yukarıdaki sorguyu çalıştırır.
            con.Close();
            griddoldur();

        }

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi formm = new yoneticisayfasi();
            this.Close();
            formm.Show();
        }
    }
}
