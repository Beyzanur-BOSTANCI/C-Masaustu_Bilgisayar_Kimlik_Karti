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
    public partial class KlasorGetir : Form
    {
        public KlasorGetir()
        {
            InitializeComponent();
        }
        Bkk_DB db = new Bkk_DB();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void KlasorGetir_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_klasor ORDER BY adi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbox_getir.Items.Add(dr["adi"]);

            }
            con.Close();
        }

        private void cmbbox_getir_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select tbl_bilgisayarKimlikKarti.sistemno, tbl_bilgisayarKimlikKarti.departman, tbl_bilgisayarKimlikKarti.kullanici,tbl_klasor.adi,tbl_bilgisayarKlasor.seviye,tbl_bilgisayarKlasor.aciklama from tbl_bilgisayarKimlikKarti, tbl_bilgisayarKlasor, tbl_klasor where tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarKlasor.bilgisayarid and tbl_bilgisayarKlasor.klasorid=tbl_klasor.id and adi='" + cmbbox_getir.Text + "'", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_klasor");
            dgv_klasorGetir.DataSource = ds.Tables["tbl_klasor"];
            adtr.Dispose();
            db.baglanti.Close();
        }
    }
}
