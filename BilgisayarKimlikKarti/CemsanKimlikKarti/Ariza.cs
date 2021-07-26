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
    public partial class Ariza : Form
    {
        public Ariza()
        {
            InitializeComponent();
        }

        Bkk_DB db = new Bkk_DB();
        
        public string idaktarma { get; set; }
        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void Ariza_Load(object sender, EventArgs e)
        {
            txt_aktar.Text = idaktarma;
         
       
            listele();
           
        }
        string kullanici = Environment.UserName;
        string teslimalan="Bilgi İşlem Sorumlusu";
        private void Btn_bildiriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                    if (db.baglanti.State == ConnectionState.Closed)
                        db.baglanti.Open();
                    string kayit = "insert into tbl_bilgisayarAriza(bilgisayarid,bildirimtarih,arizasikayet,degisecekanakart,degisecekislemci,degisecekhafiza,degisecekharddisk,degisecekekrankarti,degisecekseskarti,degisecekdisketsurucu,degisecekcddvd,degisecekdiger,degisecekikidiger,teslimalan,logkullanici,logzaman)"
                        + "values" + "('" + txt_aktar.Text.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "','" + txt_sikayet.Text.ToString() + "','" + cmbBox_degisecekanakart.Text.ToString() + "','" + cmbBox_degisecekislemi.Text.ToString() + "','" + cmbBox_degisecekhafiza.Text.ToString() + "','" + cmbBox_degisecekhardDisk.Text.ToString() + "','" + cmbBox_degisecekekranKarti.Text.ToString() + "','" + cmbBox_degiseceksesKarti.Text.ToString() + "','" + cmbBox_degisecekdisketSurucu.Text.ToString() + "','" + cmbBox_degisecekcdDvd.Text.ToString() + "','" + cmbBox_degisecekdiger.Text.ToString() + "','" + cmbBox_degisecekdigeriki.Text.ToString() + "','" +teslimalan+"','"+ kullanici.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Bilgisayar Arıza Bilgisi!");
                    
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            listele();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string kayit = "UPDATE tbl_bilgisayarAriza Set bildirimtarih=@bildirimtarih,arizasikayet=@arizasikayet,degisecekanakart=@degisecekanakart,degisecekislemci=@degisecekislemci,degisecekhafiza=@degisecekhafiza,degisecekharddisk=@degisecekharddisk,degisecekekrankarti=@degisecekekrankarti,degisecekseskarti=@degisecekseskarti,degisecekdisketsurucu=@degisecekdisketsurucu,degisecekcddvd=@degisecekcddvd,degisecekdiger=@degisecekdiger,degisecekikidiger=@degisecekikidiger, teslimalan=@teslimalan where bilgisayarid=@bilgisayarid";
                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);

                komut.Parameters.AddWithValue("@bildirimtarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                komut.Parameters.AddWithValue("@arizasikayet", txt_sikayet.Text);
                komut.Parameters.AddWithValue("@degisecekanakart", cmbBox_degisenAnakart.Text);
                komut.Parameters.AddWithValue("@degisecekislemci", cmbBox_degisecekislemi.Text);
                komut.Parameters.AddWithValue("@degisecekhafiza", cmbBox_degisecekhafiza.Text);
                komut.Parameters.AddWithValue("@degisecekharddisk", cmbBox_degisecekhardDisk.Text);
                komut.Parameters.AddWithValue("@degisecekekrankarti",cmbBox_degisecekekranKarti .Text);
                komut.Parameters.AddWithValue("@degisecekseskarti", cmbBox_degiseceksesKarti.Text);
                komut.Parameters.AddWithValue("@degisecekdisketsurucu", cmbBox_degisecekdisketSurucu.Text);
                komut.Parameters.AddWithValue("@degisecekcddvd", cmbBox_degisecekcdDvd.Text);
                komut.Parameters.AddWithValue("@degisecekdiger", cmbBox_degisecekdiger.Text);
                komut.Parameters.AddWithValue("@degisecekikidiger", cmbBox_degisecekdigeriki.Text);
                komut.Parameters.AddWithValue("@teslimalan", teslimalan);
                komut.Parameters.AddWithValue("@bilgisayarid", txt_aktar.Text);

                komut.ExecuteNonQuery();
                db.baglanti.Close();
                MessageBox.Show("Güncellendi!");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void groupBox_Bİldirim_Enter(object sender, EventArgs e)
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

                    string sorgu = "Delete From tbl_bilgisayarAriza Where id=@id";
                    komut = new SqlCommand(sorgu, db.baglanti);
                    komut.Parameters.AddWithValue("@id", dgv_ariza.CurrentRow.Cells[0].Value);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
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
            listele();
        }
        void listele()
        {
            //Bkk_DB db = new Bkk_DB();
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select tbl_bilgisayarAriza.id,tbl_bilgisayarAriza.bilgisayarid, tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarAriza.teslimalan,tbl_bilgisayarKimlikKarti.kullanici,  tbl_bilgisayarAriza.bildirimtarih,tbl_bilgisayarAriza.arizasikayet,tbl_bilgisayarAriza.degisecekanakart,tbl_bilgisayarAriza.degisecekislemci,tbl_bilgisayarAriza.degisecekhafiza,tbl_bilgisayarAriza.degisecekharddisk,tbl_bilgisayarAriza.degisecekekrankarti,tbl_bilgisayarAriza.degisecekseskarti,tbl_bilgisayarAriza.degisecekdisketsurucu,tbl_bilgisayarAriza.degisecekcddvd,tbl_bilgisayarAriza.degisecekdiger,tbl_bilgisayarAriza.degisecekikidiger,tbl_bilgisayarKimlikKarti.kullanici,tbl_bilgisayarAriza.teslimalan, tbl_bilgisayarAriza.gidermetarih ,tbl_bilgisayarAriza.yapilanlar,tbl_bilgisayarAriza.degisenanakart,tbl_bilgisayarAriza.degisenislemci,tbl_bilgisayarAriza.degisenhafiza,tbl_bilgisayarAriza.degisenharddisk,tbl_bilgisayarAriza.degisenekrankarti,tbl_bilgisayarAriza.degisenseskarti,tbl_bilgisayarAriza.degisendisketsurucu,tbl_bilgisayarAriza.degisencddvd,tbl_bilgisayarAriza.degisendiger,tbl_bilgisayarAriza.degisenikidiger, tbl_bilgisayarAriza.sonuc,tbl_bilgisayarAriza.oneriler,tbl_bilgisayarAriza.parcamaliyet from tbl_bilgisayarAriza,tbl_bilgisayarKimlikKarti where tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarAriza.bilgisayarid", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarAriza");
            dgv_ariza.DataSource = ds.Tables["tbl_bilgisayarAriza"];
            adtr.Dispose();
            db.baglanti.Close();
            dgv_ariza.Columns[0].Visible = false;
            dgv_ariza.Columns[1].Visible = false;
            dgv_ariza.Columns[7].Visible = false;
            dgv_ariza.Columns[8].Visible = false;
            dgv_ariza.Columns[9].Visible = false;
            dgv_ariza.Columns[10].Visible = false;
            dgv_ariza.Columns[11].Visible = false;
            dgv_ariza.Columns[12].Visible = false;
            dgv_ariza.Columns[13].Visible = false;
            dgv_ariza.Columns[14].Visible = false;
            dgv_ariza.Columns[15].Visible = false;
            dgv_ariza.Columns[16].Visible = false;
         
            dgv_ariza.Columns[21].Visible = false;
            dgv_ariza.Columns[22].Visible = false;
            dgv_ariza.Columns[23].Visible = false;
            dgv_ariza.Columns[24].Visible = false;
            dgv_ariza.Columns[25].Visible = false;
            dgv_ariza.Columns[26].Visible = false;
            dgv_ariza.Columns[27].Visible = false;
            dgv_ariza.Columns[28].Visible = false;
            dgv_ariza.Columns[29].Visible = false;
            dgv_ariza.Columns[30].Visible = false;
            dgv_ariza.Columns[31].Visible = false;
            dgv_ariza.Columns[32].Visible = false;
        }
        
        private void btn_gidermeKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string kayit = "UPDATE tbl_bilgisayarAriza Set gidermetarih=@gidermetarih,yapilanlar=@yapilanlar,degisenanakart=@degisenanakart,degisenislemci=@degisenislemci,degisenhafiza=@degisenhafiza,degisenharddisk=@degisenharddisk,degisenekrankarti=@degisenekrankarti,degisenseskarti=@degisenseskarti,degisendisketsurucu=@degisendisketsurucu,degisencddvd=@degisencddvd,degisendiger=@degisendiger,degisenikidiger=@degisenikidiger,sonuc=@sonuc,oneriler=@oneriler, parcamaliyet=@parcamaliyet where id=@id";
                SqlCommand komut = new SqlCommand(kayit, db.baglanti);

                komut.Parameters.AddWithValue("@gidermetarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                komut.Parameters.AddWithValue("@yapilanlar", txt_sikayet.Text);
                komut.Parameters.AddWithValue("@degisenanakart", cmbBox_degisenAnakart.Text);
                komut.Parameters.AddWithValue("@degisenislemci", cmbBox_degisecekislemi.Text);
                komut.Parameters.AddWithValue("@degisenhafiza", cmbBox_degisecekhafiza.Text);
                komut.Parameters.AddWithValue("@degisenharddisk", cmbBox_degisecekhardDisk.Text);
                komut.Parameters.AddWithValue("@degisenekrankarti", cmbBox_degisecekekranKarti.Text);
                komut.Parameters.AddWithValue("@degisenseskarti", cmbBox_degiseceksesKarti.Text);
                komut.Parameters.AddWithValue("@degisendisketsurucu", cmbBox_degisecekdisketSurucu.Text);
                komut.Parameters.AddWithValue("@degisencddvd", cmbBox_degisecekcdDvd.Text);
                komut.Parameters.AddWithValue("@degisendiger", cmbBox_degisecekdiger.Text);
                komut.Parameters.AddWithValue("@degisenikidiger", cmbBox_degisecekdigeriki.Text);
                komut.Parameters.AddWithValue("@sonuc", txt_sonuc.Text);
                komut.Parameters.AddWithValue("@oneriler", txt_oneriler.Text);
                komut.Parameters.AddWithValue("@parcamaliyet", txt_maliyet.Text);

                komut.Parameters.AddWithValue("@id", txt_idtut.Text);
                komut.ExecuteNonQuery();
                db.baglanti.Close();
                MessageBox.Show("Bilgisayar Arıza Giderilme!");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
      
            listele();
        }

        private void dgv_ariza_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_idtut.Text=dgv_ariza.CurrentRow.Cells[0].Value.ToString();
            txt_aktar2.Text = dgv_ariza.CurrentRow.Cells[1].Value.ToString();
            txt_sikayet.Text = dgv_ariza.CurrentRow.Cells[6].Value.ToString();
            cmbBox_degisecekanakart.Text = dgv_ariza.CurrentRow.Cells[7].Value.ToString();
            cmbBox_degisecekislemi.Text = dgv_ariza.CurrentRow.Cells[8].Value.ToString();
            cmbBox_degisecekhafiza.Text = dgv_ariza.CurrentRow.Cells[9].Value.ToString();
            cmbBox_degisecekhardDisk.Text = dgv_ariza.CurrentRow.Cells[10].Value.ToString();
            cmbBox_degisecekekranKarti.Text = dgv_ariza.CurrentRow.Cells[11].Value.ToString();
            cmbBox_degiseceksesKarti.Text = dgv_ariza.CurrentRow.Cells[12].Value.ToString();
            cmbBox_degisecekdisketSurucu.Text = dgv_ariza.CurrentRow.Cells[13].Value.ToString();
            cmbBox_degisecekcdDvd.Text = dgv_ariza.CurrentRow.Cells[14].Value.ToString();
            cmbBox_degisecekdiger.Text = dgv_ariza.CurrentRow.Cells[15].Value.ToString();
            cmbBox_degisecekdigeriki.Text = dgv_ariza.CurrentRow.Cells[16].Value.ToString();

            txt_yapilanlar.Text = dgv_ariza.CurrentRow.Cells[20].Value.ToString();
            cmbBox_degisenAnakart.Text = dgv_ariza.CurrentRow.Cells[21].Value.ToString();
            cmbBox_degisenİslemci.Text = dgv_ariza.CurrentRow.Cells[22].Value.ToString();
            cmbBox_degisenHafiza.Text = dgv_ariza.CurrentRow.Cells[23].Value.ToString();
            cmbBox_degisenHardDisk.Text = dgv_ariza.CurrentRow.Cells[24].Value.ToString();
            cmbBox_degisenEkranKArti.Text = dgv_ariza.CurrentRow.Cells[25].Value.ToString();
            cmbBox_degisenSesKarti.Text = dgv_ariza.CurrentRow.Cells[26].Value.ToString();
            cmbBox_degisenDisketSurucu.Text = dgv_ariza.CurrentRow.Cells[27].Value.ToString();
            cmbBox_degisenCdDvd.Text = dgv_ariza.CurrentRow.Cells[28].Value.ToString();
            cmbBox_degisenDiger.Text = dgv_ariza.CurrentRow.Cells[29].Value.ToString();
            cmbBox_degisenDigerıki.Text = dgv_ariza.CurrentRow.Cells[30].Value.ToString();
            txt_sonuc.Text = dgv_ariza.CurrentRow.Cells[31].Value.ToString();
            txt_oneriler.Text = dgv_ariza.CurrentRow.Cells[32].Value.ToString();
            txt_maliyet.Text = dgv_ariza.CurrentRow.Cells[33].Value.ToString();
        }

        private void btn_gidermeGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string kayit = "UPDATE tbl_bilgisayarAriza Set gidermetarih=@gidermetarih,yapilanlar=@yapilanlar,degisenanakart=@degisenanakart,degisenislemci=@degisenislemci,degisenhafiza=@degisenhafiza,degisenharddisk=@degisenharddisk,degisenekrankarti=@degisenekrankarti,degisenseskarti=@degisenseskarti,degisendisketsurucu=@degisendisketsurucu,degisencddvd=@degisencddvd,degisendiger=@degisendiger,degisenikidiger=@degisenikidiger,sonuc=@sonuc,oneriler=@oneriler, parcamaliyet=@parcamaliyet where id=@id";
                SqlCommand komut = new SqlCommand(kayit, db.baglanti);
           

                komut.Parameters.AddWithValue("@gidermetarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                komut.Parameters.AddWithValue("@yapilanlar", txt_sikayet.Text);
                komut.Parameters.AddWithValue("@degisenanakart", cmbBox_degisenAnakart.Text);
                komut.Parameters.AddWithValue("@degisenislemci", cmbBox_degisecekislemi.Text);
                komut.Parameters.AddWithValue("@degisenhafiza", cmbBox_degisecekhafiza.Text);
                komut.Parameters.AddWithValue("@degisenharddisk", cmbBox_degisecekhardDisk.Text);
                komut.Parameters.AddWithValue("@degisenekrankarti", cmbBox_degisecekekranKarti.Text);
                komut.Parameters.AddWithValue("@degisenseskarti", cmbBox_degiseceksesKarti.Text);
                komut.Parameters.AddWithValue("@degisendisketsurucu", cmbBox_degisecekdisketSurucu.Text);
                komut.Parameters.AddWithValue("@degisencddvd", cmbBox_degisecekcdDvd.Text);
                komut.Parameters.AddWithValue("@degisendiger", cmbBox_degisecekdiger.Text);
                komut.Parameters.AddWithValue("@degisenikidiger", cmbBox_degisecekdigeriki.Text);
                komut.Parameters.AddWithValue("@sonuc", txt_sonuc.Text);
                komut.Parameters.AddWithValue("@oneriler", txt_oneriler.Text);
                komut.Parameters.AddWithValue("@parcamaliyet", txt_maliyet.Text);

                komut.Parameters.AddWithValue("@id", txt_idtut.Text);
                komut.ExecuteNonQuery();
                db.baglanti.Close();
                MessageBox.Show("Güncellendi!");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }

            listele();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_maliyet.Clear();txt_oneriler.Clear();txt_sikayet.Clear();txt_sonuc.Clear();
            txt_yapilanlar.Clear();
        }

        private void btn_gidermeSil_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Kaydı Silmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand();
                    db.baglanti.Open();

                    string sorgu = "Delete From tbl_bilgisayarAriza Where id=@id";
                    komut = new SqlCommand(sorgu, db.baglanti);
                    komut.Parameters.AddWithValue("@id", dgv_ariza.CurrentRow.Cells[0].Value);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
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
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}


