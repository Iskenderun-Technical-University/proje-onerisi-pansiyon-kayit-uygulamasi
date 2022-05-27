
namespace pansiyonotomasyonu
{
    partial class kayitlimusterikullanici
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciaditextbox = new System.Windows.Forms.TextBox();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.gerigitbutton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonotomasyonDataSet5 = new pansiyonotomasyonu.pansiyonotomasyonDataSet5();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonotomasyonDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(274, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "giriş yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // kullaniciaditextbox
            // 
            this.kullaniciaditextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciaditextbox.Location = new System.Drawing.Point(314, 131);
            this.kullaniciaditextbox.Name = "kullaniciaditextbox";
            this.kullaniciaditextbox.Size = new System.Drawing.Size(193, 30);
            this.kullaniciaditextbox.TabIndex = 3;
            // 
            // sifretextbox
            // 
            this.sifretextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretextbox.Location = new System.Drawing.Point(314, 208);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '#';
            this.sifretextbox.Size = new System.Drawing.Size(193, 30);
            this.sifretextbox.TabIndex = 4;
            // 
            // gerigitbutton
            // 
            this.gerigitbutton.BackColor = System.Drawing.Color.Purple;
            this.gerigitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerigitbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gerigitbutton.Location = new System.Drawing.Point(39, 434);
            this.gerigitbutton.Name = "gerigitbutton";
            this.gerigitbutton.Size = new System.Drawing.Size(152, 53);
            this.gerigitbutton.TabIndex = 16;
            this.gerigitbutton.Text = "<-------- Geri git";
            this.gerigitbutton.UseVisualStyleBackColor = false;
            this.gerigitbutton.Click += new System.EventHandler(this.gerigitbutton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.pansiyonotomasyonDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // pansiyonotomasyonDataSet5
            // 
            this.pansiyonotomasyonDataSet5.DataSetName = "pansiyonotomasyonDataSet5";
            this.pansiyonotomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(558, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 53);
            this.button3.TabIndex = 18;
            this.button3.Text = "şifre yenile";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kayitlimusterikullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gerigitbutton);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.kullaniciaditextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "kayitlimusterikullanici";
            this.Text = "kayitlikullanici";
            this.Load += new System.EventHandler(this.kayitlimusterikullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonotomasyonDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gerigitbutton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pansiyonotomasyonDataSet5 pansiyonotomasyonDataSet5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox kullaniciaditextbox;
        public System.Windows.Forms.TextBox sifretextbox;
    }
}