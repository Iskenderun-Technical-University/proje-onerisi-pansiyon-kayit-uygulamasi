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
    
    public partial class sifreyenile : Form
    {
        public int sonuc = 0;
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        public sifreyenile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textbox_captcha.Text==sonuc.ToString())
            {
                if (textBox_yenisifre.Text == textBox_yenisifreonay.Text)
                {
                    eskisifrekontrol();
                    MessageBox.Show("...şifre güncellendi...");
                }
                else
                {
                    label5.Text = "yeni şifre ile yeni şifre(tekrar) uyuşmammaktadır!";
                }

            }
            else
            {
                label5.Text = "captcha hatalı!";
            }
        }
        public void eskisifrekontrol()
        {
            if (kayitlimusterikullanici.kullanicisession == "")
            {
                label5.Text = "lutfen bir önceki sayfaya dönüp kullanıcı adını yazınız!";
            }
            con = new SqlConnection(baglanti);
            string sorgu = "select sifre from yenikullanici where kullaniciadi=@user and sifre=@password";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user",textBox_kullaniciadi.Text);
            cmd.Parameters.AddWithValue("@password", textBox_eskisifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                dr.Close();
                //eğer eski şifre doğruysa
                SqlCommand cmd2;
                cmd2 = new SqlCommand();
                string sqlsorgu = "update yenikullanici set sifre=@password where kullaniciadi=@us ";
    
                cmd2.Parameters.AddWithValue("@us",textBox_kullaniciadi.Text);
                cmd2.Parameters.AddWithValue("@password", textBox_yenisifre.Text);
                cmd2.Connection = con;
                cmd2.CommandText = sqlsorgu;
                cmd2.ExecuteNonQuery();
                
            }
            else
            {
                label5.Text = "eski sifre hatalı!";
            }
            con.Close();
        }

        private void gerigitbutton_Click(object sender, EventArgs e)
        {
            kayitlimusterikullanici a = new kayitlimusterikullanici();
            a.Show();
            this.Hide();
        }

        private void sifreyenile_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int ikinci = r.Next(0,10);
            int ilk = r.Next(0, 10);
            sonuc = ilk + ikinci;
            label4.Text = ilk.ToString() + "+" + ikinci.ToString();
            
        }
    }
}
