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
    public partial class KullaniciveİpnoAramaYapma : Form
    {
        public KullaniciveİpnoAramaYapma()
        {
            InitializeComponent();
            listele();
        }
        Bkk_DB db = new Bkk_DB();
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            if (radiobtn_kullanıcı.Checked)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select id,sistemno,ipno,departman,kullanici,lokasyon,islemci,hafiza,anakart,harddisk,ekrankarti,monitor,disketsurucu,cddvd,seskarti,diger,internet From tbl_bilgisayarKimlikKarti where kullanici like '%" + txt_kullanici.Text + "%'", db.baglanti);
                DataSet ds = new DataSet();
                adtr.Fill(ds, "tbl_bilgisayarKimlikKarti");
                dgv_arama.DataSource = ds.Tables["tbl_bilgisayarKimlikKarti"];
                adtr.Dispose();
            }
            else if (radiobtn_ip.Checked)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select id,sistemno,ipno,departman,kullanici,lokasyon,islemci,hafiza,anakart,harddisk,ekrankarti,monitor,disketsurucu,cddvd,seskarti,diger,internet From tbl_bilgisayarKimlikKarti where ipno like '%" + txt_kullanici.Text + "%'", db.baglanti);
                DataSet ds = new DataSet();
                adtr.Fill(ds, "tbl_bilgisayarKimlikKarti");
                dgv_arama.DataSource = ds.Tables["tbl_bilgisayarKimlikKarti"];
                adtr.Dispose();

      
            }
            else
            {
                listele();
            }
            db.baglanti.Close();
        }
        void listele()
        {
            //Bkk_DB db = new Bkk_DB();
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select id,sistemno,ipno,departman,kullanici,lokasyon,islemci,hafiza,anakart,harddisk,ekrankarti,monitor,disketsurucu,cddvd,seskarti,diger,internet From tbl_bilgisayarKimlikKarti", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarKimlikKarti");
            dgv_arama.DataSource = ds.Tables["tbl_bilgisayarKimlikKarti"];
            adtr.Dispose();
            db.baglanti.Close();
            dgv_arama.Columns[0].Visible = false;

        }

        private void radiobtn_ip_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
