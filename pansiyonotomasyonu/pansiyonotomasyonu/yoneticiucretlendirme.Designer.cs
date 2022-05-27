
namespace pansiyonotomasyonu
{
    partial class yoneticiucretlendirme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonotomasyonDataSet11 = new pansiyonotomasyonu.pansiyonotomasyonDataSet11();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tutarlabel = new System.Windows.Forms.Label();
            this.odendiradioButton = new System.Windows.Forms.RadioButton();
            this.odenmediradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonotomasyonDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Purple;
            this.label6.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(33, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 44);
            this.label6.TabIndex = 25;
            this.label6.Text = " - Fatura Ve Ödemeler-";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.pansiyonotomasyonDataSet11;
            this.bindingSource1.Position = 0;
            // 
            // pansiyonotomasyonDataSet11
            // 
            this.pansiyonotomasyonDataSet11.DataSetName = "pansiyonotomasyonDataSet11";
            this.pansiyonotomasyonDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tutarlabel);
            this.groupBox1.Controls.Add(this.odendiradioButton);
            this.groupBox1.Controls.Add(this.odenmediradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(206, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 139);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HESAP";
            // 
            // tutarlabel
            // 
            this.tutarlabel.AutoSize = true;
            this.tutarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutarlabel.Location = new System.Drawing.Point(36, 54);
            this.tutarlabel.Name = "tutarlabel";
            this.tutarlabel.Size = new System.Drawing.Size(0, 32);
            this.tutarlabel.TabIndex = 28;
            // 
            // odendiradioButton
            // 
            this.odendiradioButton.AutoSize = true;
            this.odendiradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odendiradioButton.ForeColor = System.Drawing.Color.Green;
            this.odendiradioButton.Location = new System.Drawing.Point(184, 43);
            this.odendiradioButton.Name = "odendiradioButton";
            this.odendiradioButton.Size = new System.Drawing.Size(132, 24);
            this.odendiradioButton.TabIndex = 29;
            this.odendiradioButton.TabStop = true;
            this.odendiradioButton.Text = "ödeme yapıldı";
            this.odendiradioButton.UseVisualStyleBackColor = true;
            this.odendiradioButton.CheckedChanged += new System.EventHandler(this.odendiradioButton_CheckedChanged);
            // 
            // odenmediradioButton
            // 
            this.odenmediradioButton.AutoSize = true;
            this.odenmediradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odenmediradioButton.ForeColor = System.Drawing.Color.Red;
            this.odenmediradioButton.Location = new System.Drawing.Point(184, 86);
            this.odenmediradioButton.Name = "odenmediradioButton";
            this.odenmediradioButton.Size = new System.Drawing.Size(155, 24);
            this.odenmediradioButton.TabIndex = 30;
            this.odenmediradioButton.TabStop = true;
            this.odenmediradioButton.Text = "ödeme yapılmadı";
            this.odenmediradioButton.UseVisualStyleBackColor = true;
            this.odenmediradioButton.CheckedChanged += new System.EventHandler(this.odenmediradioButton_CheckedChanged);
            // 
            // yoneticiucretlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "yoneticiucretlendirme";
            this.Text = "yoneticiucretlendirme";
            this.Load += new System.EventHandler(this.yoneticiucretlendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonotomasyonDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pansiyonotomasyonDataSet11 pansiyonotomasyonDataSet11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tutarlabel;
        private System.Windows.Forms.RadioButton odendiradioButton;
        private System.Windows.Forms.RadioButton odenmediradioButton;
    }
}