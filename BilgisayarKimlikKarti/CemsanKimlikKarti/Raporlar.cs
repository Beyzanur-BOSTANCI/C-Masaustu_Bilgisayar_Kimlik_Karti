using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemsanKimlikKarti
{
    public partial class Raporlar : Form
    {

        public Raporlar()
        {
            InitializeComponent();
        }
        Bkk_DB db = new Bkk_DB();
        private void Raporlar_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti1' table. You can move, or remove it, as needed.

            this.tbl_bilgisayarKimlikKarti1TableAdapter.Fill(this.BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti1);
            // TODO: This line of code loads data into the 'BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti2' table. You can move, or remove it, as needed.

            this.tbl_bilgisayarKimlikKarti2TableAdapter.Fill(this.BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti2);

            // TODO: This line of code loads data into the 'BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti3' table. You can move, or remove it, as needed.
            this.tbl_bilgisayarKimlikKarti3TableAdapter.Fill(this.BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti3);
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void enMaliyetliBilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource RDC = new ReportDataSource();
                RDC.Name = "Report1";
                RDC.Value = this.BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti1;
                this.reportViewer1.LocalReport.DataSources.Add(RDC);
                this.reportViewer1.LocalReport.ReportPath = @"C:\Users\asus\Desktop\CemsanKimlikKarti\CemsanKimlikKarti\Report1.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void enÇokZamanHarcanılanBilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                ReportDataSource RDC = new ReportDataSource();
                RDC.Name = "Report2";
                RDC.Value = this.BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti2;
                this.reportViewer1.LocalReport.DataSources.Add(RDC);
                this.reportViewer1.LocalReport.ReportPath = @"C:\Users\asus\Desktop\CemsanKimlikKarti\CemsanKimlikKarti\Report2.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void enÇokArızaYapanBilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                ReportDataSource RDC = new ReportDataSource();
                RDC.Name = "Report3";
                RDC.Value = this.BilgisayarKimlikKartiDataSet.tbl_bilgisayarKimlikKarti3;
                this.reportViewer1.LocalReport.DataSources.Add(RDC);
                this.reportViewer1.LocalReport.ReportPath = @"C:\Users\asus\Desktop\CemsanKimlikKarti\CemsanKimlikKarti\Report3.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }

        }
    }
}
