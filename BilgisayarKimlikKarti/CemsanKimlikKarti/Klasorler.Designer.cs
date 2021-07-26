namespace CemsanKimlikKarti
{
    partial class Klasorler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klasorler));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_aktar = new System.Windows.Forms.TextBox();
            this.cmbBox_Adi = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_seviye = new System.Windows.Forms.TextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_klasorid = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_klasorGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // txt_aktar
            // 
            this.txt_aktar.Location = new System.Drawing.Point(372, 102);
            this.txt_aktar.Name = "txt_aktar";
            this.txt_aktar.Size = new System.Drawing.Size(42, 20);
            this.txt_aktar.TabIndex = 24;
            this.txt_aktar.Visible = false;
            // 
            // cmbBox_Adi
            // 
            this.cmbBox_Adi.FormattingEnabled = true;
            this.cmbBox_Adi.Location = new System.Drawing.Point(133, 27);
            this.cmbBox_Adi.Name = "cmbBox_Adi";
            this.cmbBox_Adi.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Adi.TabIndex = 23;
            this.cmbBox_Adi.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Adi_SelectedIndexChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(19, 130);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 22;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(133, 94);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(121, 20);
            this.txt_aciklama.TabIndex = 21;
            // 
            // txt_seviye
            // 
            this.txt_seviye.Location = new System.Drawing.Point(133, 58);
            this.txt_seviye.Name = "txt_seviye";
            this.txt_seviye.Size = new System.Drawing.Size(121, 20);
            this.txt_seviye.TabIndex = 20;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(239, 130);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 19;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seviye :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Adı :";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(6, 21);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(91, 23);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Klasör Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_klasorid
            // 
            this.txt_klasorid.Location = new System.Drawing.Point(372, 128);
            this.txt_klasorid.Name = "txt_klasorid";
            this.txt_klasorid.Size = new System.Drawing.Size(42, 20);
            this.txt_klasorid.TabIndex = 25;
            this.txt_klasorid.Visible = false;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(6, 79);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(91, 23);
            this.btn_Sil.TabIndex = 26;
            this.btn_Sil.Text = "Klasör Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(133, 130);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 27;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // btn_klasorGuncelle
            // 
            this.btn_klasorGuncelle.Location = new System.Drawing.Point(6, 50);
            this.btn_klasorGuncelle.Name = "btn_klasorGuncelle";
            this.btn_klasorGuncelle.Size = new System.Drawing.Size(91, 23);
            this.btn_klasorGuncelle.TabIndex = 29;
            this.btn_klasorGuncelle.Text = "Klasör Güncelle";
            this.btn_klasorGuncelle.UseVisualStyleBackColor = true;
            this.btn_klasorGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_güncelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.txt_seviye);
            this.groupBox1.Controls.Add(this.txt_aciklama);
            this.groupBox1.Controls.Add(this.cmbBox_Adi);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 165);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klasör Takip : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_klasorGuncelle);
            this.groupBox2.Controls.Add(this.btn_Ekle);
            this.groupBox2.Controls.Add(this.btn_Sil);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 166);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klasör Durumları :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Klasorler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 183);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_klasorid);
            this.Controls.Add(this.txt_aktar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Klasorler";
            this.Text = "Klasör Ekle ve Kaydet";
            this.Load += new System.EventHandler(this.Klasorler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aktar;
        private System.Windows.Forms.ComboBox cmbBox_Adi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_seviye;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_klasorid;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_klasorGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}