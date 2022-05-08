
namespace pansiyonotomasyonu
{
    partial class yoneticigirispaneli
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
            this.sifretextbox1 = new System.Windows.Forms.TextBox();
            this.kullaniciaditextbox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gerigitbutton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sifretextbox1
            // 
            this.sifretextbox1.Location = new System.Drawing.Point(355, 197);
            this.sifretextbox1.Name = "sifretextbox1";
            this.sifretextbox1.PasswordChar = '#';
            this.sifretextbox1.Size = new System.Drawing.Size(193, 22);
            this.sifretextbox1.TabIndex = 9;
            // 
            // kullaniciaditextbox1
            // 
            this.kullaniciaditextbox1.Location = new System.Drawing.Point(355, 120);
            this.kullaniciaditextbox1.Name = "kullaniciaditextbox1";
            this.kullaniciaditextbox1.Size = new System.Drawing.Size(193, 22);
            this.kullaniciaditextbox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(315, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "giriş yap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gerigitbutton
            // 
            this.gerigitbutton.BackColor = System.Drawing.Color.Purple;
            this.gerigitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerigitbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gerigitbutton.Location = new System.Drawing.Point(63, 460);
            this.gerigitbutton.Name = "gerigitbutton";
            this.gerigitbutton.Size = new System.Drawing.Size(152, 53);
            this.gerigitbutton.TabIndex = 16;
            this.gerigitbutton.Text = "<-------- Geri git";
            this.gerigitbutton.UseVisualStyleBackColor = false;
            this.gerigitbutton.Click += new System.EventHandler(this.gerigitbutton_Click);
            // 
            // yoneticigirispaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.gerigitbutton);
            this.Controls.Add(this.sifretextbox1);
            this.Controls.Add(this.kullaniciaditextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "yoneticigirispaneli";
            this.Text = "yoneticigirispaneli";
            this.Load += new System.EventHandler(this.yoneticigirispaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifretextbox1;
        private System.Windows.Forms.TextBox kullaniciaditextbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button gerigitbutton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}