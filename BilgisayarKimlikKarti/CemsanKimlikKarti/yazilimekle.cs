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
    public partial class yazilimekle : Form
    {
        public yazilimekle()
        {
            InitializeComponent();
        }
        Bkk_DB db = new Bkk_DB();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public string sistemno { get; set; }

        string kullanici = Environment.UserName;
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
          
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select adi from tbl_software where adi Like '" + cmbBox_Adi.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text = "Kayit var";

                }
                con.Close();
                if (label1.Text == "Kayit var")
                {
                    MessageBox.Show("Zaten Yazılım Kayıtlı!");

                }
                else
                {
                    if (db.baglanti.State == ConnectionState.Closed)
                        db.baglanti.Open();
                    string kayit = "insert into tbl_software(adi,logkullanici,logzaman)"
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
            yaziliminidgetir();

        }
        void yaziliminidgetir()
        {
           
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_software ORDER BY id ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_yazilimid.Text = dr["id"].ToString();

            }
            con.Close();
        }
        private void yazilimekle_Load(object sender, EventArgs e)
        {
            txt_aktar.Text = sistemno;
            aktarma();
        
        }
        void aktarma()
        {
          
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_software ORDER BY Adi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBox_Adi.Items.Add(dr["Adi"]);

            }
            con.Close();

        }

        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_aktar.Text != null)
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "select bilgisayarid, softwareid from tbl_bilgisayarSoftware where bilgisayarid=" + txt_aktar.Text + "and softwareid=" + txt_yazilimid.Text;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        label1.Text = "Kayit var";

                    }
                    con.Close();
                    if (label1.Text == "Kayit var")
                    {
                        MessageBox.Show("Zaten Kayıt Var!");

                    }
                    else
                    {
                        if (db.baglanti.State == ConnectionState.Closed)
                            db.baglanti.Open();
                        string kayit = "insert into tbl_bilgisayarSoftware(bilgisayarid,softwareid,aciklama,lisansno,logkullanici,logzaman)"
                            + "values" + "('" + txt_aktar.Text.ToString() + "','" + txt_yazilimid.Text.ToString() + "','" + txt_aciklama.Text.ToString() + "','" + txt_lisansNo.Text.ToString() + "','" + kullanici.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                        komut.ExecuteNonQuery();
                        db.baglanti.Close();

                        MessageBox.Show("işlem Tamamlandı.");

                    }
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            }
        
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBox_Adi_SelectedIndexChanged(object sender, EventArgs e)
        {
         
          
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_software Where adi= '" + cmbBox_Adi.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_yazilimid.Text = dr["id"].ToString();

            }
            con.Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
    

            DialogResult secenek = MessageBox.Show("Kaydı Silmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand();
                    db.baglanti.Open();

                    string sorgu = "Delete From tbl_software Where id=@id";
                    komut = new SqlCommand(sorgu, db.baglanti);
                    komut.Parameters.AddWithValue("@id", txt_yazilimid.Text);
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

        private void btn_güncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string kayit = "UPDATE tbl_bilgisayarSoftware Set softwareid=@softwareid,aciklama=@aciklama,lisansno=@lisansno where bilgisayarid=@bilgisayarid ";

                SqlCommand komut = new SqlCommand(kayit, db.baglanti);

                komut.Parameters.AddWithValue("@softwareid", txt_yazilimid.Text);
                komut.Parameters.AddWithValue("@aciklama", txt_aciklama.Text);
                komut.Parameters.AddWithValue("@lisansno", txt_lisansNo.Text);


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

        private void btn_progGüncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string guncelle = "Update tbl_software set adi=@adi where id=@id";
                SqlCommand komut = new SqlCommand(guncelle, db.baglanti);
                komut.Parameters.AddWithValue("@adi", cmbBox_Adi.Text);
                komut.Parameters.AddWithValue("@id", txt_yazilimid.Text);
                komut.ExecuteNonQuery();
                db.baglanti.Close();
                MessageBox.Show("Program Güncellendi.");
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            yaziliminidgetir();
        }
    }
    }
    

