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
    public partial class Klasorler : Form
    {
        Bkk_DB db = new Bkk_DB();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public string sistemno { get; set; }
        public Klasorler()
        {
            InitializeComponent();
        }
        string kullanici = Environment.UserName;
        private void Klasorler_Load(object sender, EventArgs e)
        {
            txt_aktar.Text = sistemno;
            aktarma();
        }
    
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Bkk_DB db = new Bkk_DB();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select bilgisayarid, klasorid from tbl_bilgisayarKlasor where bilgisayarid=" + txt_aktar.Text + "and klasorid=" + txt_klasorid.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label6.Text = "Kayit var";

                }
                con.Close();
                if (label6.Text == "Kayit var")
                {
                    MessageBox.Show("Zaten Kayıt Var!");

                }
                else
                {
                    if (db.baglanti.State == ConnectionState.Closed)
                        db.baglanti.Open();
                    string kayit = "insert into tbl_bilgisayarKlasor(bilgisayarid,klasorid,seviye,aciklama,logkullanici,logzaman)"
                        + "values" + "('" + txt_aktar.Text.ToString() + "','" + txt_klasorid.Text.ToString() + "','" + txt_seviye.Text.ToString() + "','" + txt_aciklama.Text.ToString() + "','" + kullanici.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("işlem Tamamlandı.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Bkk_DB db = new Bkk_DB();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select adi from tbl_klasor where adi Like '" + cmbBox_Adi.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label6.Text = "Kayit var";

                }
                con.Close();
                if (label6.Text == "Kayit var")
                {
                    MessageBox.Show("Zaten Klasör Kayıtlı!");

                }
                else
                {
                    if (db.baglanti.State == ConnectionState.Closed)
                        db.baglanti.Open();
                    string kayit = "insert into tbl_klasor(adi,logkullanici,logzaman)"
                        + "values" + "('" + cmbBox_Adi.Text.ToString() + "','" + kullanici.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Yeni Program Eklendi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            klasoridgetir();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Close();
        }
        void aktarma()
        {
            Bkk_DB db = new Bkk_DB();
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_klasor ORDER BY Adi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBox_Adi.Items.Add(dr["Adi"]);

            }
            con.Close();
        }
        void klasoridgetir()
        {
            Bkk_DB db = new Bkk_DB();
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_klasor ORDER BY id ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_klasorid.Text = dr["id"].ToString();

            }
            con.Close();
        }
        private void cmbBox_Adi_SelectedIndexChanged(object sender, EventArgs e)
        {

            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_klasor Where adi= '" + cmbBox_Adi.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_klasorid.Text = dr["id"].ToString();

            }
            con.Close();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı Silmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand();
                    db.baglanti.Open();

                    string sorgu = "Delete From tbl_klasor Where id=@id";
                    komut = new SqlCommand(sorgu, db.baglanti);
                    komut.Parameters.AddWithValue("@id", txt_klasorid.Text);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Kayıt Silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Kayıt Silinmedi.");
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string kayit = "UPDATE tbl_bilgisayarKlasor Set klasorid=@klasorid,seviye=@seviye,aciklama=@aciklama where bilgisayarid=@bilgisayarid ";

                SqlCommand komut = new SqlCommand(kayit, db.baglanti);

                komut.Parameters.AddWithValue("@klasorid", txt_klasorid.Text);
                komut.Parameters.AddWithValue("@seviye", txt_seviye.Text);
                komut.Parameters.AddWithValue("@aciklama", txt_aciklama.Text);


                komut.Parameters.AddWithValue("@bilgisayarid", txt_aktar.Text);

                komut.ExecuteNonQuery();
                db.baglanti.Close();
                MessageBox.Show("Kayıt Güncellenmiştir.");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
                string guncelle = "Update tbl_klasor set adi=@adi where id=@id";
            SqlCommand komut = new SqlCommand(guncelle, db.baglanti);
                komut.Parameters.AddWithValue("@adi", cmbBox_Adi.Text);
                komut.Parameters.AddWithValue("@id", txt_klasorid.Text);
                komut.ExecuteNonQuery();
            db.baglanti.Close();
            MessageBox.Show("Klasör Güncellendi.");
        }
    
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            klasoridgetir();
        }
        }
    }

