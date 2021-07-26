namespace CemsanKimlikKarti
{
    partial class KlasorGetir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlasorGetir));
            this.dgv_klasorGetir = new System.Windows.Forms.DataGridView();
            this.cmbbox_getir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klasorGetir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_klasorGetir
            // 
            this.dgv_klasorGetir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klasorGetir.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_klasorGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klasorGetir.Location = new System.Drawing.Point(7, 28);
            this.dgv_klasorGetir.Name = "dgv_klasorGetir";
            this.dgv_klasorGetir.Size = new System.Drawing.Size(804, 409);
            this.dgv_klasorGetir.TabIndex = 5;
            // 
            // cmbbox_getir
            // 
            this.cmbbox_getir.FormattingEnabled = true;
            this.cmbbox_getir.Location = new System.Drawing.Point(117, 1);
            this.cmbbox_getir.Name = "cmbbox_getir";
            this.cmbbox_getir.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_getir.TabIndex = 4;
            this.cmbbox_getir.SelectedIndexChanged += new System.EventHandler(this.cmbbox_getir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bir Klasör Seçiniz : ";
            // 
            // KlasorGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 449);
            this.Controls.Add(this.dgv_klasorGetir);
            this.Controls.Add(this.cmbbox_getir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlasorGetir";
            this.Text = "Klasör Seçim";
            this.Load += new System.EventHandler(this.KlasorGetir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klasorGetir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_klasorGetir;
        private System.Windows.Forms.ComboBox cmbbox_getir;
        private System.Windows.Forms.Label label1;
    }
}