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
    public partial class yoneticiucretlendirme : Form
    {
        public yoneticiucretlendirme()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        
        SqlCommand cmd;
        DataSet ds;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=pansiyonotomasyon;Integrated Security=True";
        private void yoneticiucretlendirme_Load(object sender, EventArgs e)
        {
            griddoldur();
           
        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter("select * from rezervasyonucretlendirmeTable", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "rezervasyonucretlendirmeTable");
            dataGridView1.DataSource = ds.Tables["rezervasyonucretlendirmeTable"];
            con.Close();

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            tutarlabel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          
        }

        public void guncelle(RadioButton rdbutton)
        {
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            string sorgu = "update rezervasyonucretlendirmeTable set ödemedurumu=@durum where toplamtutar=@tutar";
            cmd.Parameters.AddWithValue("@durum",rdbutton.Text);
            cmd.Parameters.AddWithValue("@tutar", tutarlabel.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
            

        }

        
        private void odendiradioButton_CheckedChanged(object sender, EventArgs e)
        {
            guncelle(odendiradioButton);
            griddoldur();
           
        }

        private void odenmediradioButton_CheckedChanged(object sender, EventArgs e)
        {
            guncelle(odenmediradioButton);
            
            griddoldur();
        }
    }
}
