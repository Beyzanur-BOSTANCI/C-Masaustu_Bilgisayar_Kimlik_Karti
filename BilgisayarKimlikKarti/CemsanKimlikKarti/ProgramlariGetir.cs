using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemsanKimlikKarti
{
    public partial class ProgramlariGetir : Form
    {
        public ProgramlariGetir()
        {
            InitializeComponent();
        }
        Bkk_DB db = new Bkk_DB();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.baglanti.Open();
           SqlDataAdapter adtr = new SqlDataAdapter("Select tbl_bilgisayarKimlikKarti.sistemno, tbl_bilgisayarKimlikKarti.departman, tbl_bilgisayarKimlikKarti.kullanici,tbl_software.adi,tbl_bilgisayarSoftware.aciklama,tbl_bilgisayarSoftware.lisansno from tbl_bilgisayarKimlikKarti, tbl_bilgisayarSoftware, tbl_software where tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarSoftware.bilgisayarid and tbl_bilgisayarSoftware.softwareid=tbl_software.id and adi='" + cmbbox_getir.Text + "'", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_software");
            dgv_ProgGetir.DataSource = ds.Tables["tbl_software"];
            adtr.Dispose();
            db.baglanti.Close();
        }

        private void ProgramlariGetir_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_software ORDER BY adi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbox_getir.Items.Add(dr["adi"]);

            }
            con.Close();
        }

        private void dataGridView_ProgGetir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
