using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonotomasyonu
{
    public partial class Müşteri_Sayfası : Form
    {
        public Müşteri_Sayfası()
        {
            InitializeComponent();
        }

        private void btnOdaBilgileri_Click(object sender, EventArgs e)
        {

        }

        private void btnPansiyonhakkında_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İSTE Pansiyonumuz 15 Odadan oluşup herkes tarafından kullanıma uygundur. Katlara göre fiyatlandırma olup her kattaki odalar aynı olmakla birlikte fiyatları da aynıdır.Müşteri girişleri güvenliğe uygun olup çıkışlarda anahtar teslim edilmekle birlikte kayıtlar silinip odalar boşaltıldığına dair  yönetici hizmetlilere bilgi verildikten sonra oda temizliğine başlanmalı ve sizler için hazır hale gelmektedir .Hizmetli temizliğini bitirdikten sonra pansiyon müdür tarafından kontrol edilip sizler için hazır olup olmadığından emin olunmaktadır.Pansiyonumuzda belirli düzeyde yemek imkanı sunulmaktadır yemekler serpservis olup yemekhanemizde sizler için hazırlanmış masalarda yiyebilsiniz.Pansiyonumuzun sayfasına sizin için verilmiş şifrelerle giriş yapıp gazete okuyabilir radyo dinleyebilirisniz.Şikayetci olduğunuz rahat edemediğiniz takdirde dilek ve arzularınızı pansiyonun yetkili kişilerine bildiriniz.Bizi tercih ettiğiniz için teşşekkürler diler pansiyonumuza yine bekleriz." );

        }

        private void label13_Click(object sender, EventArgs e)
        {
            oda501 oda501 = new oda501();
            oda501.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            oda201 oda201 = new oda201();
            oda201.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            oda203 oda203 = new oda203();
            oda203.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            oda301 oda301 = new oda301();
            oda301.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            oda403 oda403 = new oda403();
            oda403.Show();
        }

        private void btnRadya_Click(object sender, EventArgs e)
        {
            Radyo_Dinle radyo = new Radyo_Dinle();
            radyo.Show();
            this.Show();
        }

        private void btnGazete_Click(object sender, EventArgs e)
        {
            gazeler gazeteler = new gazeler();
            gazeteler.Show();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            oda101 oda101 = new oda101();
            oda101.Show();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            oda103 oda103 = new oda103();
            oda103.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            oda202 oda202 = new oda202();
            oda202.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            oda102 oda102 = new oda102();
            oda102.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            oda302 oda302 = new oda302();
            oda302.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            oda303 oda303 = new oda303();
            oda303.Show();
            

        }

        private void label10_Click(object sender, EventArgs e)
        {
            oda401 oda401 = new  oda401();
            oda401.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            oda402 oda402 = new oda402();
            oda402.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            oda502 oda502 = new oda502();
            oda502.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            oda503 oda503 = new oda503();
            oda503.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEtkinlikveMenü_Click(object sender, EventArgs e)
        {
            etkinlikveMenüler etkinlikveMenüler = new etkinlikveMenüler();
            etkinlikveMenüler.Show();
            this.Hide();
        }

        private void Müşteri_Sayfası_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Oda No", 100);
            listView1.Items.Add("101");
            listView1.Items.Add("102");
            listView1.Items.Add("103");
            listView1.Items.Add("201");
            listView1.Items.Add("202");
            listView1.Items.Add("203");
            listView1.Items.Add("301");
            listView1.Items.Add("302");
            listView1.Items.Add("303");
            listView1.Items.Add("401");
            listView1.Items.Add("402");
            listView1.Items.Add("403");
            listView1.Items.Add("501");
            listView1.Items.Add("502");
            listView1.Items.Add("503");


            listView1.Columns.Add("Tuvalet", 100);
          
            listView1.Columns.Add("Banyo", 100);
            listView1.Columns.Add("Mutfak", 100);
            listView1.Columns.Add("Televizyon", 100);
            listView1.Columns.Add("Balkon", 100);
            listView1.Columns.Add("Masa", 100);


 

            
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
