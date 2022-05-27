
namespace pansiyonotomasyonu
{
    partial class sifreyenile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_eskisifre = new System.Windows.Forms.TextBox();
            this.textBox_yenisifre = new System.Windows.Forms.TextBox();
            this.textBox_yenisifreonay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_captcha = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gerigitbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_eskisifre
            // 
            this.textBox_eskisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_eskisifre.Location = new System.Drawing.Point(313, 102);
            this.textBox_eskisifre.Name = "textBox_eskisifre";
            this.textBox_eskisifre.Size = new System.Drawing.Size(212, 30);
            this.textBox_eskisifre.TabIndex = 0;
            // 
            // textBox_yenisifre
            // 
            this.textBox_yenisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_yenisifre.Location = new System.Drawing.Point(313, 172);
            this.textBox_yenisifre.Name = "textBox_yenisifre";
            this.textBox_yenisifre.Size = new System.Drawing.Size(212, 30);
            this.textBox_yenisifre.TabIndex = 1;
            // 
            // textBox_yenisifreonay
            // 
            this.textBox_yenisifreonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_yenisifreonay.Location = new System.Drawing.Point(313, 231);
            this.textBox_yenisifreonay.Name = "textBox_yenisifreonay";
            this.textBox_yenisifreonay.Size = new System.Drawing.Size(212, 30);
            this.textBox_yenisifreonay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "eski şifre;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "yeni şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "yeni şifre(tekrar);";
            // 
            // textbox_captcha
            // 
            this.textbox_captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_captcha.Location = new System.Drawing.Point(538, 325);
            this.textbox_captcha.Name = "textbox_captcha";
            this.textbox_captcha.Size = new System.Drawing.Size(100, 30);
            this.textbox_captcha.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(547, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 53);
            this.button3.TabIndex = 19;
            this.button3.Text = "şifre değiştir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(90, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 44);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // gerigitbutton
            // 
            this.gerigitbutton.BackColor = System.Drawing.Color.Purple;
            this.gerigitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerigitbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gerigitbutton.Location = new System.Drawing.Point(81, 475);
            this.gerigitbutton.Name = "gerigitbutton";
            this.gerigitbutton.Size = new System.Drawing.Size(152, 53);
            this.gerigitbutton.TabIndex = 21;
            this.gerigitbutton.Text = "<-------- Geri git";
            this.gerigitbutton.UseVisualStyleBackColor = false;
            this.gerigitbutton.Click += new System.EventHandler(this.gerigitbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(404, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "label4";
            // 
            // textBox_kullaniciadi
            // 
            this.textBox_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciadi.Location = new System.Drawing.Point(313, 49);
            this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            this.textBox_kullaniciadi.Size = new System.Drawing.Size(212, 30);
            this.textBox_kullaniciadi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(147, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "kullanıcı adı:";
            // 
            // sifreyenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_kullaniciadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gerigitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textbox_captcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_yenisifreonay);
            this.Controls.Add(this.textBox_yenisifre);
            this.Controls.Add(this.textBox_eskisifre);
            this.Name = "sifreyenile";
            this.Text = "sifreyenile";
            this.Load += new System.EventHandler(this.sifreyenile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_eskisifre;
        private System.Windows.Forms.TextBox textBox_yenisifre;
        private System.Windows.Forms.TextBox textBox_yenisifreonay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_captcha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button gerigitbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_kullaniciadi;
        private System.Windows.Forms.Label label6;
    }
}