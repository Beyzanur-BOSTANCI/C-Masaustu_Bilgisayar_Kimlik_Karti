namespace CemsanKimlikKarti
{
    partial class yazilimekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yazilimekle));
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_lisansNo = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cmbBox_Adi = new System.Windows.Forms.ComboBox();
            this.txt_aktar = new System.Windows.Forms.TextBox();
            this.txt_yazilimid = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_progGüncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(16, 28);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(105, 23);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Program Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklaması :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lisans Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(201, 138);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 7;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(121, 65);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(121, 20);
            this.txt_aciklama.TabIndex = 9;
            // 
            // txt_lisansNo
            // 
            this.txt_lisansNo.Location = new System.Drawing.Point(121, 102);
            this.txt_lisansNo.Name = "txt_lisansNo";
            this.txt_lisansNo.Size = new System.Drawing.Size(121, 20);
            this.txt_lisansNo.TabIndex = 10;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(9, 138);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cmbBox_Adi
            // 
            this.cmbBox_Adi.FormattingEnabled = true;
            this.cmbBox_Adi.Location = new System.Drawing.Point(121, 32);
            this.cmbBox_Adi.Name = "cmbBox_Adi";
            this.cmbBox_Adi.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Adi.TabIndex = 12;
            this.cmbBox_Adi.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Adi_SelectedIndexChanged);
            // 
            // txt_aktar
            // 
            this.txt_aktar.Location = new System.Drawing.Point(354, 90);
            this.txt_aktar.Name = "txt_aktar";
            this.txt_aktar.Size = new System.Drawing.Size(41, 20);
            this.txt_aktar.TabIndex = 13;
            this.txt_aktar.Visible = false;
            // 
            // txt_yazilimid
            // 
            this.txt_yazilimid.Location = new System.Drawing.Point(354, 116);
            this.txt_yazilimid.Name = "txt_yazilimid";
            this.txt_yazilimid.Size = new System.Drawing.Size(41, 20);
            this.txt_yazilimid.TabIndex = 14;
            this.txt_yazilimid.Visible = false;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(16, 90);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(105, 23);
            this.btn_sil.TabIndex = 16;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(110, 138);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 17;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btn_progGüncelle
            // 
            this.btn_progGüncelle.Location = new System.Drawing.Point(16, 59);
            this.btn_progGüncelle.Name = "btn_progGüncelle";
            this.btn_progGüncelle.Size = new System.Drawing.Size(105, 23);
            this.btn_progGüncelle.TabIndex = 19;
            this.btn_progGüncelle.Text = "Program Güncelle";
            this.btn_progGüncelle.UseVisualStyleBackColor = true;
            this.btn_progGüncelle.Click += new System.EventHandler(this.btn_progGüncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_güncelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.txt_aciklama);
            this.groupBox1.Controls.Add(this.cmbBox_Adi);
            this.groupBox1.Controls.Add(this.txt_lisansNo);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 170);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Takip :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Ekle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_progGüncelle);
            this.groupBox2.Location = new System.Drawing.Point(317, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 164);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program Durum :";
            // 
            // yazilimekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 194);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_yazilimid);
            this.Controls.Add(this.txt_aktar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yazilimekle";
            this.Text = "Program Ekle ve Kaydet";
            this.Load += new System.EventHandler(this.yazilimekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_lisansNo;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox cmbBox_Adi;
        private System.Windows.Forms.TextBox txt_aktar;
        private System.Windows.Forms.TextBox txt_yazilimid;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_progGüncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}