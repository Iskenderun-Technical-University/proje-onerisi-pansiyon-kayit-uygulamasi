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
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
        }
        public static string musteribaglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        public static string rezervasyonbaglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        public static string odabaglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        int toplamtutar;
        int odano;
        private void rezervasyon_Load(object sender, EventArgs e)
        {
            textboxdoldur();
            string sorgu = "select odanumarasi from odalarTable";
            con = new SqlConnection(odabaglanti);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["odanumarasi"]);
            }
            con.Close();

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tutar(comboBox1);
            toplamtutarlabel.Text =Convert.ToString(toplamtutar);
        }
       
        
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(comboBox1.Text);
        }

        public void tutar(ComboBox cmbbox)
        {
            if (odano == 100 || odano == 200 || odano == 300||odano==400||odano==500)
            {
                toplamtutar = 100 * Convert.ToInt32(textBox3.Text);
            }
            if(odano == 101 || odano == 201 || odano == 301 || odano == 401 || odano == 501)
            {
                toplamtutar = 200 * Convert.ToInt32(textBox3.Text);
            }
            if(odano == 102 || odano == 202 || odano == 302 || odano == 402 || odano == 502)
            {
                toplamtutar = 300 * Convert.ToInt32(textBox3.Text);
            }
        }
        public void insert()
        {
            //con = new SqlConnection(rezervasyonbaglanti);
            cmd = new SqlCommand();
            string baglan = "insert into rezervasyonucretlendirmeTable(musteriadi,musteritc,sectigiodanumarasi,kalacagigecesayisi,toplamtutar,ödemedurumu) values(@adi,@tc,@odano,@gecesayi,@toplamtutar,@durum)";
            cmd.Parameters.AddWithValue("@adi",textBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox2.Text);
            cmd.Parameters.AddWithValue("@odano", comboBox1.Text);
            cmd.Parameters.AddWithValue("@gecesayi", textBox3.Text);
            cmd.Parameters.AddWithValue("@toplamtutar", toplamtutarlabel.Text);
            cmd.Parameters.AddWithValue("@durum", "ödenmedi");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = baglan;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rezervasyon Yapıldı :) Bizi tercih ettiğiniz için teşekkür ederiz.");
        }
        public void textboxdoldur()
        {
            string metin = "select ad,[t.c no] from yenikullanici";
            
            con = new SqlConnection(musteribaglanti);
            con.Open();
            cmd = new SqlCommand(metin, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["ad"].ToString();
                textBox2.Text = dr["t.c no"].ToString();
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insert();
        }
    }
    }

