namespace CemsanKimlikKarti
{
    partial class Raporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.tbl_bilgisayarKimlikKarti2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BilgisayarKimlikKartiDataSet = new CemsanKimlikKarti.BilgisayarKimlikKartiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enMaliyetliBilgisayarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokArızaYapanBilgisayarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_bilgisayarKimlikKarti3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_bilgisayarKimlikKarti1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_bilgisayarKimlikKarti1TableAdapter = new CemsanKimlikKarti.BilgisayarKimlikKartiDataSetTableAdapters.tbl_bilgisayarKimlikKarti1TableAdapter();
            this.tbl_bilgisayarKimlikKarti2TableAdapter = new CemsanKimlikKarti.BilgisayarKimlikKartiDataSetTableAdapters.tbl_bilgisayarKimlikKarti2TableAdapter();
            this.tbl_bilgisayarKimlikKarti3TableAdapter = new CemsanKimlikKarti.BilgisayarKimlikKartiDataSetTableAdapters.tbl_bilgisayarKimlikKarti3TableAdapter();
            this.bilgisayarKimlikKartiDataSet1 = new CemsanKimlikKarti.BilgisayarKimlikKartiDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bilgisayarKimlikKarti2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BilgisayarKimlikKartiDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bilgisayarKimlikKarti3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bilgisayarKimlikKarti1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarKimlikKartiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_bilgisayarKimlikKarti2BindingSource
            // 
            this.tbl_bilgisayarKimlikKarti2BindingSource.DataMember = "tbl_bilgisayarKimlikKarti2";
            this.tbl_bilgisayarKimlikKarti2BindingSource.DataSource = this.BilgisayarKimlikKartiDataSet;
            // 
            // BilgisayarKimlikKartiDataSet
            // 
            this.BilgisayarKimlikKartiDataSet.DataSetName = "BilgisayarKimlikKartiDataSet";
            this.BilgisayarKimlikKartiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_bilgisayarKimlikKarti3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CemsanKimlikKarti.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 380);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enMaliyetliBilgisayarToolStripMenuItem,
            this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem,
            this.enÇokArızaYapanBilgisayarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enMaliyetliBilgisayarToolStripMenuItem
            // 
            this.enMaliyetliBilgisayarToolStripMenuItem.Name = "enMaliyetliBilgisayarToolStripMenuItem";
            this.enMaliyetliBilgisayarToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.enMaliyetliBilgisayarToolStripMenuItem.Text = "En Maliyetli Bilgisayar";
            this.enMaliyetliBilgisayarToolStripMenuItem.Click += new System.EventHandler(this.enMaliyetliBilgisayarToolStripMenuItem_Click);
            // 
            // enÇokZamanHarcanılanBilgisayarToolStripMenuItem
            // 
            this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem.Name = "enÇokZamanHarcanılanBilgisayarToolStripMenuItem";
            this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem.Size = new System.Drawing.Size(209, 20);
            this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem.Text = "En Çok Zaman Harcanılan Bilgisayar";
            this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem.Click += new System.EventHandler(this.enÇokZamanHarcanılanBilgisayarToolStripMenuItem_Click);
            // 
            // enÇokArızaYapanBilgisayarToolStripMenuItem
            // 
            this.enÇokArızaYapanBilgisayarToolStripMenuItem.Name = "enÇokArızaYapanBilgisayarToolStripMenuItem";
            this.enÇokArızaYapanBilgisayarToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.enÇokArızaYapanBilgisayarToolStripMenuItem.Text = "En Çok Arıza Yapan Bilgisayar";
            this.enÇokArızaYapanBilgisayarToolStripMenuItem.Click += new System.EventHandler(this.enÇokArızaYapanBilgisayarToolStripMenuItem_Click);
            // 
            // tbl_bilgisayarKimlikKarti3BindingSource
            // 
            this.tbl_bilgisayarKimlikKarti3BindingSource.DataMember = "tbl_bilgisayarKimlikKarti3";
            this.tbl_bilgisayarKimlikKarti3BindingSource.DataSource = this.BilgisayarKimlikKartiDataSet;
            // 
            // tbl_bilgisayarKimlikKarti1BindingSource
            // 
            this.tbl_bilgisayarKimlikKarti1BindingSource.DataMember = "tbl_bilgisayarKimlikKarti1";
            this.tbl_bilgisayarKimlikKarti1BindingSource.DataSource = this.BilgisayarKimlikKartiDataSet;
            // 
            // tbl_bilgisayarKimlikKarti1TableAdapter
            // 
            this.tbl_bilgisayarKimlikKarti1TableAdapter.ClearBeforeFill = true;
            // 
            // tbl_bilgisayarKimlikKarti2TableAdapter
            // 
            this.tbl_bilgisayarKimlikKarti2TableAdapter.ClearBeforeFill = true;
            // 
            // tbl_bilgisayarKimlikKarti3TableAdapter
            // 
            this.tbl_bilgisayarKimlikKarti3TableAdapter.ClearBeforeFill = true;
            // 
            // bilgisayarKimlikKartiDataSet1
            // 
            this.bilgisayarKimlikKartiDataSet1.DataSetName = "BilgisayarKimlikKartiDataSet";
            this.bilgisayarKimlikKartiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 404);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Raporlar";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bilgisayarKimlikKarti2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BilgisayarKimlikKartiDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bilgisayarKimlikKarti3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bilgisayarKimlikKarti1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarKimlikKartiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_bilgisayarKimlikKarti1BindingSource;
        private BilgisayarKimlikKartiDataSet BilgisayarKimlikKartiDataSet;
        private BilgisayarKimlikKartiDataSetTableAdapters.tbl_bilgisayarKimlikKarti1TableAdapter tbl_bilgisayarKimlikKarti1TableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enMaliyetliBilgisayarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokZamanHarcanılanBilgisayarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokArızaYapanBilgisayarToolStripMenuItem;
        private System.Windows.Forms.BindingSource tbl_bilgisayarKimlikKarti2BindingSource;
        private BilgisayarKimlikKartiDataSetTableAdapters.tbl_bilgisayarKimlikKarti2TableAdapter tbl_bilgisayarKimlikKarti2TableAdapter;
        private System.Windows.Forms.BindingSource tbl_bilgisayarKimlikKarti3BindingSource;
        private BilgisayarKimlikKartiDataSetTableAdapters.tbl_bilgisayarKimlikKarti3TableAdapter tbl_bilgisayarKimlikKarti3TableAdapter;
        private BilgisayarKimlikKartiDataSet bilgisayarKimlikKartiDataSet1;
    }
}