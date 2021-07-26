namespace CemsanKimlikKarti
{
    partial class ProgramlariGetir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramlariGetir));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbox_getir = new System.Windows.Forms.ComboBox();
            this.dgv_ProgGetir = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProgGetir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Program Seçiniz : ";
            // 
            // cmbbox_getir
            // 
            this.cmbbox_getir.FormattingEnabled = true;
            this.cmbbox_getir.Location = new System.Drawing.Point(125, 10);
            this.cmbbox_getir.Name = "cmbbox_getir";
            this.cmbbox_getir.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_getir.TabIndex = 1;
            this.cmbbox_getir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgv_ProgGetir
            // 
            this.dgv_ProgGetir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProgGetir.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ProgGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProgGetir.Location = new System.Drawing.Point(5, 37);
            this.dgv_ProgGetir.Name = "dgv_ProgGetir";
            this.dgv_ProgGetir.Size = new System.Drawing.Size(816, 375);
            this.dgv_ProgGetir.TabIndex = 2;
            this.dgv_ProgGetir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ProgGetir_CellContentClick);
            // 
            // ProgramlariGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 424);
            this.Controls.Add(this.dgv_ProgGetir);
            this.Controls.Add(this.cmbbox_getir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramlariGetir";
            this.Text = "Program Seçim";
            this.Load += new System.EventHandler(this.ProgramlariGetir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProgGetir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbox_getir;
        private System.Windows.Forms.DataGridView dgv_ProgGetir;
    }
}