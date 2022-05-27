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
    public partial class yoneticimusteriislemleri : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        public yoneticimusteriislemleri()
        {
            InitializeComponent();
        }

        private void yoneticimusteriislemleri_Load(object sender, EventArgs e)
        {
            
            griddoldur(dataGridView1);
        }
        public void griddoldur(DataGridView gridin)
        {
            con = new SqlConnection(baglanti);
            ds = new DataSet();
            // string sorgu = "select * from yenikullanici";
            da = new SqlDataAdapter("select*from yenikullanici", con);
            con.Open();
            da.Fill(ds, "yenikullanici");
            gridin.DataSource = ds.Tables["yenikullanici"];
            con.Close();

        }
        public void deletekullanici()
        {
          
            cmd = new SqlCommand();
            string sorgu = "delete from yenikullanici where kullaniciadi=@user AND sifre=@pass";
            cmd.Parameters.AddWithValue("@user", kullaniciaditextbox.Text);
            cmd.Parameters.AddWithValue("@pass", sifretextbox.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dataGridView1);
            adtextbox.Clear();
            soyadtextbox.Clear();
            kullaniciaditextbox.Clear();
            sifretextbox.Clear();
            TCtextBox.Clear();
            telnotextBox.Clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adtextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadtextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kullaniciaditextbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sifretextbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            telnotextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TCtextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            deletekullanici();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adtextbox.Clear();
            soyadtextbox.Clear();
            kullaniciaditextbox.Clear();
            sifretextbox.Clear();
            TCtextBox.Clear();
            telnotextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriekle();
        }
        public void musteriekle()
        {
            string sorgu = "insert into yenikullanici(ad,soyad,kullaniciadi,sifre,[telefon no],[t.c no]) values(@name,@surname,@nickname,@password,@no,@tc)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@name",adtextbox.Text);
            cmd.Parameters.AddWithValue("@surname", soyadtextbox.Text);
            cmd.Parameters.AddWithValue("@nickname", kullaniciaditextbox.Text);
            cmd.Parameters.AddWithValue("@password", sifretextbox.Text);
            cmd.Parameters.AddWithValue("@no", telnotextBox.Text);
            cmd.Parameters.AddWithValue("@tc", TCtextBox.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncelle();
        }
        public void guncelle()
        {
            cmd = new SqlCommand();
            string select = "update yenikullanici set kullaniciadi=@nickname,sifre=@password,[telefon no]=@no,[t.c no]=@tc where ad=@name AND soyad=@surname";
            cmd.Parameters.AddWithValue("@name", adtextbox.Text);
            cmd.Parameters.AddWithValue("@surname", soyadtextbox.Text);
            cmd.Parameters.AddWithValue("@nickname", kullaniciaditextbox.Text);
            cmd.Parameters.AddWithValue("@password", sifretextbox.Text);
            cmd.Parameters.AddWithValue("@no", telnotextBox.Text);
            cmd.Parameters.AddWithValue("@tc", TCtextBox.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = select;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dataGridView1);
        }

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi formm = new yoneticisayfasi();
            this.Close();
            formm.Show();
        }
    }

    }
