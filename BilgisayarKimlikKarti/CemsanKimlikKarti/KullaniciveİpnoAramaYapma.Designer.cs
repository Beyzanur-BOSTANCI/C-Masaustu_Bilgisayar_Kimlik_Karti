namespace CemsanKimlikKarti
{
    partial class KullaniciveİpnoAramaYapma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciveİpnoAramaYapma));
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.dgv_arama = new System.Windows.Forms.DataGridView();
            this.radiobtn_kullanıcı = new System.Windows.Forms.RadioButton();
            this.radiobtn_ip = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arama)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(208, 35);
            this.txt_kullanici.Multiline = true;
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(135, 21);
            this.txt_kullanici.TabIndex = 0;
            this.txt_kullanici.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_arama
            // 
            this.dgv_arama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_arama.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_arama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arama.Location = new System.Drawing.Point(15, 77);
            this.dgv_arama.Name = "dgv_arama";
            this.dgv_arama.Size = new System.Drawing.Size(982, 360);
            this.dgv_arama.TabIndex = 4;
            // 
            // radiobtn_kullanıcı
            // 
            this.radiobtn_kullanıcı.AutoSize = true;
            this.radiobtn_kullanıcı.Location = new System.Drawing.Point(15, 12);
            this.radiobtn_kullanıcı.Name = "radiobtn_kullanıcı";
            this.radiobtn_kullanıcı.Size = new System.Drawing.Size(140, 17);
            this.radiobtn_kullanıcı.TabIndex = 5;
            this.radiobtn_kullanıcı.TabStop = true;
            this.radiobtn_kullanıcı.Text = "Kullanıcıya Göre Arama :";
            this.radiobtn_kullanıcı.UseVisualStyleBackColor = true;
            // 
            // radiobtn_ip
            // 
            this.radiobtn_ip.AutoSize = true;
            this.radiobtn_ip.Location = new System.Drawing.Point(15, 39);
            this.radiobtn_ip.Name = "radiobtn_ip";
            this.radiobtn_ip.Size = new System.Drawing.Size(158, 17);
            this.radiobtn_ip.TabIndex = 6;
            this.radiobtn_ip.TabStop = true;
            this.radiobtn_ip.Text = "Ip Numarasına Göre Arama :";
            this.radiobtn_ip.UseVisualStyleBackColor = true;
            this.radiobtn_ip.CheckedChanged += new System.EventHandler(this.radiobtn_ip_CheckedChanged);
            // 
            // KullaniciveİpnoAramaYapma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 449);
            this.Controls.Add(this.radiobtn_ip);
            this.Controls.Add(this.radiobtn_kullanıcı);
            this.Controls.Add(this.dgv_arama);
            this.Controls.Add(this.txt_kullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciveİpnoAramaYapma";
            this.Text = "Kullanıcı ve Ip Numarsına Göre Arama Yapma";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.DataGridView dgv_arama;
        private System.Windows.Forms.RadioButton radiobtn_kullanıcı;
        private System.Windows.Forms.RadioButton radiobtn_ip;
    }
}