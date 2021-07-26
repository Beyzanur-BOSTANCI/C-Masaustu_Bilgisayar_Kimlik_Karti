using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemsanKimlikKarti
{
    public partial class BilgisayarKimlikKartı : Form
    {
        public BilgisayarKimlikKartı()
        {
            InitializeComponent();
        }

        Bkk_DB db = new Bkk_DB();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string[] bilgi = new string[5];
        private void button1_Click(object sender, EventArgs e)
        {
            //   Bkk_DB db = new Bkk_DB();
            db.baglanti.Open();
            if (db.baglanti.State == ConnectionState.Open)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("no");
            }
            db.baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            temizle();
            listele();
            listele2();
            listele3();
            listele4();
            txt_sistemNo.Text = " ";

        }

        //temizle();
        private void button2_Click(object sender, EventArgs e)
        {


        }

        string kullanici = Environment.UserName;

        public string connectionString { get; private set; }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                txt_sistem_Kontrol.Text = txt_sistemNo.Text;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select sistemno from tbl_bilgisayarKimlikKarti where sistemno Like '" + txt_sistemNo.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label17.Text = "Kayit var";

                }
                con.Close();
                if (label17.Text == "Kayit var")
                {
                    MessageBox.Show("Kayıt Var!");

                }
                else
                {
                    if (db.baglanti.State == ConnectionState.Closed)
                        db.baglanti.Open();
                    string kayit = "insert into tbl_bilgisayarKimlikKarti(sistemno,ipno,departman,kullanici,lokasyon,islemci,hafiza,anakart,harddisk,ekrankarti,monitor,disketsurucu,cddvd,seskarti,diger,internet,logkullanici,logzaman)"
                        + "values" + "('" + txt_sistemNo.Text.ToString() + "','" + txt_ipNo.Text.ToString() + "','" + txt_departman.Text.ToString() + "','" + txt_kullanici.Text.ToString() + "','" + cmbBox_lokasyon.Text.ToString() + "','" + txt_islemci.Text.ToString() + "','" + txt_hazifa.Text.ToString() + "','" + txt_anakart.Text.ToString() + "','" + txt_harddisk.Text.ToString() + "','" + txt_ekranKarti.Text.ToString() + "','" + txt_monitor.Text.ToString() + "','" + cmbBox_disketSurucu.Text.ToString() + "','" + cmbBox_cdDvd.Text.ToString() + "','" + cmbBox_sesKarti.Text.ToString() + "','" + cmboBox_diger.Text.ToString() + "','" + cmbBox_internet.Text.ToString() + "','" + kullanici.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Bilgisayar Kimlik Kartı Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            // temizle();
            listele();
            listele2();
            listele3();
            aktarma();

        }
        void aktarma()
        {
            //  Bkk_DB db = new Bkk_DB();
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_bilgisayarKimlikKarti ORDER BY id ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_aktar.Text = dr["id"].ToString();

            }
            con.Close();
        }

        void listele()
        {


            //Bkk_DB db = new Bkk_DB();
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select id,sistemno,ipno,departman,kullanici,lokasyon,islemci,hafiza,anakart,harddisk,ekrankarti,monitor,disketsurucu,cddvd,seskarti,diger,internet From tbl_bilgisayarKimlikKarti", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarKimlikKarti");
            dgv_bilgisayarlar.DataSource = ds.Tables["tbl_bilgisayarKimlikKarti"];
            adtr.Dispose();
            db.baglanti.Close();
            dgv_bilgisayarlar.Columns[0].Visible = false;

        }
        public static void txtKaydet(DataGridView veriTablosu)
        {
            try
            {
                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "projeTxtDosyaAdı";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "Txt Dosyası|*.txt";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    TextWriter txt = new StreamWriter(dosyakaydet.FileName);
                    foreach (DataGridViewColumn sutun in veriTablosu.Columns)
                    {
                        txt.Write(sutun.HeaderText + "    ");
                    }
                    txt.Write("\n");
                    foreach (DataGridViewRow satir in veriTablosu.Rows)
                    {
                        foreach (DataGridViewCell hucre in satir.Cells)
                        {
                            txt.Write(hucre.Value.ToString() + "     ");
                        }
                        txt.Write("\n");
                    }
                    txt.Close();
                    MessageBox.Show("TXT dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        public void dosyayaYaz()
        {
            try
            {
                string logPath;
                StreamReader file = new StreamReader("LogYol.txt");
                logPath = file.ReadToEnd();
                file.Close();

                string dosya_yolu = logPath;


                Bkk_DB DB = new Bkk_DB();

                // string[] bilgi= DB.silBilgisiniGetir(veri);
                string text = bilgi[0] + " " + bilgi[1] + " " + bilgi[2] + " " + bilgi[3] + " " + bilgi[4]  + " " + System.Environment.UserName + " " + DateTime.Today + Environment.NewLine;

                File.AppendAllText(dosya_yolu, text);


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            //Bkk_DB db = new Bkk_DB();

            DialogResult secenek = MessageBox.Show("Kaydı Silmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                try
                {

                 
                    SqlCommand komut = new SqlCommand();
                    SqlCommand komut2 = new SqlCommand();
                    SqlCommand komut3 = new SqlCommand();
                    SqlCommand komut4 = new SqlCommand();

                    db.baglanti.Open();


                    dosyayaYaz();
                    string sorgu4 = "delete from tbl_bilgisayarAriza Where bilgisayarid=@bilgisayarid";
                    komut4 = new SqlCommand(sorgu4, db.baglanti);
                    komut4.Parameters.AddWithValue("@bilgisayarid", dgv_ariza.CurrentRow.Cells[2].Value);
                    komut4.ExecuteNonQuery();

                    string sorgu3 = "Delete From tbl_bilgisayarKlasor Where bilgisayarid=@bilgisayarid";
                    komut3 = new SqlCommand(sorgu3, db.baglanti);
                    komut3.Parameters.AddWithValue("@bilgisayarid", dgv_serverYetkili.CurrentRow.Cells[3].Value);
                    komut3.ExecuteNonQuery();

                    string sorgu2 = "Delete From tbl_bilgisayarSoftware Where bilgisayarid=@bilgisayarid";
                    komut2 = new SqlCommand(sorgu2, db.baglanti);
                    komut2.Parameters.AddWithValue("@bilgisayarid", dgv_yazilimlar.CurrentRow.Cells[3].Value);
                    komut2.ExecuteNonQuery();

                
                    string sorgu = "Delete From tbl_bilgisayarKimlikKarti Where sistemno=@sistemno";
                    komut = new SqlCommand(sorgu, db.baglanti);
                    komut.Parameters.AddWithValue("@sistemno", dgv_bilgisayarlar.CurrentRow.Cells[1].Value);
                    komut.ExecuteNonQuery();
                  


                    db.baglanti.Close();

                  

                    listele();
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
            //temizle();
            listele();

        }


        void renklendir()
        {
            for (int i = 0; i < dgv_yazilimlar.Rows.Count - 1; i++)
            {
                // Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 1)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 2)
                {
                    renk.BackColor = Color.Yellow;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 3)
                {
                    renk.BackColor = Color.Green;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 4)
                {
                    renk.BackColor = Color.Gray;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 5)
                {
                    renk.BackColor = Color.Pink;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 6)
                {
                    renk.BackColor = Color.Purple;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 7)
                {
                    renk.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 8)
                {
                    renk.BackColor = Color.Orange;
                }

                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 9)
                {
                    renk.BackColor = Color.OldLace;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 10)
                {
                    renk.BackColor = Color.MediumSlateBlue;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 11)
                {
                    renk.BackColor = Color.LightSalmon;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 12)
                {
                    renk.BackColor = Color.Khaki;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 13)
                {
                    renk.BackColor = Color.LightPink;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 14)
                {
                    renk.BackColor = Color.Ivory;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 15)
                {
                    renk.BackColor = Color.Brown;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 16)
                {
                    renk.BackColor = Color.Aqua;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 17)
                {
                    renk.BackColor = Color.DarkMagenta;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 18)
                {
                    renk.BackColor = Color.DarkViolet;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 19)
                {
                    renk.BackColor = Color.Honeydew;
                }
                else if (Convert.ToInt32(dgv_yazilimlar.Rows[i].Cells["softwareid"].Value) == 20)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                dgv_yazilimlar.Rows[i].DefaultCellStyle = renk;
            }
        }
        public void renklendir2()
        {
            for (int i = 0; i < dgv_serverYetkili.Rows.Count - 1; i++)
            {
                //Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 1)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 2)
                {
                    renk.BackColor = Color.Yellow;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 3)
                {
                    renk.BackColor = Color.Green;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 4)
                {
                    renk.BackColor = Color.Gray;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 5)
                {
                    renk.BackColor = Color.Pink;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 6)
                {
                    renk.BackColor = Color.Purple;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 7)
                {
                    renk.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 8)
                {
                    renk.BackColor = Color.Orange;
                }

                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 9)
                {
                    renk.BackColor = Color.OldLace;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 10)
                {
                    renk.BackColor = Color.MediumSlateBlue;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 11)
                {
                    renk.BackColor = Color.LightSalmon;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 12)
                {
                    renk.BackColor = Color.Khaki;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 13)
                {
                    renk.BackColor = Color.LightPink;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 14)
                {
                    renk.BackColor = Color.Ivory;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 15)
                {
                    renk.BackColor = Color.Brown;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 16)
                {
                    renk.BackColor = Color.Aqua;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 17)
                {
                    renk.BackColor = Color.DarkMagenta;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 18)
                {
                    renk.BackColor = Color.DarkViolet;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 19)
                {
                    renk.BackColor = Color.Honeydew;
                }
                else if (Convert.ToInt32(dgv_serverYetkili.Rows[i].Cells["klasorid"].Value) == 20)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                dgv_serverYetkili.Rows[i].DefaultCellStyle = renk;
            }
        }

        void listele2()
        {
            db.baglanti.Open();

            string sorgu = "SELECT tbl_bilgisayarKimlikKarti.sistemno, tbl_bilgisayarSoftware.softwareid, tbl_software.adi,tbl_bilgisayarSoftware.bilgisayarid,tbl_bilgisayarSoftware.aciklama ,tbl_bilgisayarSoftware.lisansno  FROM tbl_bilgisayarSoftware , tbl_software , tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarSoftware.softwareid = tbl_software.id and tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarSoftware.bilgisayarid ORDER BY adi ASC";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarSoftware");
            dgv_yazilimlar.DataSource = ds.Tables["tbl_bilgisayarSoftware"];
            adtr.Dispose();
            db.baglanti.Close();
            dgv_yazilimlar.Columns[1].Visible = false;
            dgv_yazilimlar.Columns[3].Visible = false;
            renklendir();


        }
        private void dgv_yazilimlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgv_yazilim(object sender, EventArgs e)
        {

        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            /*  ara();
              aktarma2();
              ara2();
              aktarma2();
              ara3();*/

        }
        /* void ara()
         {
             if (db.baglanti.State != ConnectionState.Open)
                 db.baglanti.Open();
             SqlDataAdapter adtr = new SqlDataAdapter("Select * from tbl_bilgisayarKimlikKarti where sistemno='" + txt_sistemNo.Text + "'", db.baglanti);
             DataSet ds = new DataSet();
             adtr.Fill(ds, "tbl_bilgisayarKimlikKarti");
             dgv_bilgisayarlar.DataSource = ds.Tables["tbl_bilgisayarKimlikKarti"];
             adtr.Dispose();
             db.baglanti.Close();

         }*/
        void ara2(string id)
        {

            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarSoftware.softwareid, tbl_software.adi,tbl_bilgisayarSoftware.bilgisayarid,tbl_bilgisayarSoftware.aciklama, tbl_bilgisayarSoftware.lisansno FROM tbl_bilgisayarSoftware , tbl_software , tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarSoftware.softwareid = tbl_software.id and tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarSoftware.bilgisayarid and bilgisayarid='" + id + "'", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarSoftware");
            dgv_yazilimlar.DataSource = ds.Tables["tbl_bilgisayarSoftware"];
            adtr.Dispose();
            db.baglanti.Close();
            renklendir();

        }
        void ara3(string id)
        {
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarKlasor.klasorid, tbl_klasor.adi,tbl_bilgisayarKlasor.bilgisayarid, tbl_bilgisayarKlasor.seviye, tbl_bilgisayarKlasor.aciklama  FROM tbl_bilgisayarKlasor, tbl_klasor, tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarKlasor.klasorid = tbl_klasor.id and tbl_bilgisayarKimlikKarti.id = tbl_bilgisayarKlasor.bilgisayarid and bilgisayarid='" + id + "'", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarKlasor");
            dgv_serverYetkili.DataSource = ds.Tables["tbl_bilgisayarKlasor"];
            adtr.Dispose();
            db.baglanti.Close();
            renklendir2();
        }
        void aktarma2()
        {
            //   Bkk_DB db = new Bkk_DB();
            con = new SqlConnection("data source=(local);database=BilgisayarKimlikKarti;integrated security =SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_bilgisayarKimlikKarti Where sistemno= '" + txt_sistemNo.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_aktar.Text = dr["id"].ToString();

            }
            con.Close();
        }
        private void dgv_bilgisayarlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_sistemNo.Text = dgv_bilgisayarlar.CurrentRow.Cells[1].Value.ToString();
            txt_ipNo.Text = dgv_bilgisayarlar.CurrentRow.Cells[2].Value.ToString();
            txt_departman.Text = dgv_bilgisayarlar.CurrentRow.Cells[3].Value.ToString();
            txt_kullanici.Text = dgv_bilgisayarlar.CurrentRow.Cells[4].Value.ToString();
            cmbBox_lokasyon.Text = dgv_bilgisayarlar.CurrentRow.Cells[5].Value.ToString();
            txt_islemci.Text = dgv_bilgisayarlar.CurrentRow.Cells[6].Value.ToString();
            txt_hazifa.Text = dgv_bilgisayarlar.CurrentRow.Cells[7].Value.ToString();
            txt_anakart.Text = dgv_bilgisayarlar.CurrentRow.Cells[8].Value.ToString();
            txt_harddisk.Text = dgv_bilgisayarlar.CurrentRow.Cells[9].Value.ToString();
            txt_ekranKarti.Text = dgv_bilgisayarlar.CurrentRow.Cells[10].Value.ToString();
            txt_monitor.Text = dgv_bilgisayarlar.CurrentRow.Cells[11].Value.ToString();
            cmbBox_disketSurucu.Text = dgv_bilgisayarlar.CurrentRow.Cells[12].Value.ToString();
            cmbBox_cdDvd.Text = dgv_bilgisayarlar.CurrentRow.Cells[13].Value.ToString();
            cmbBox_sesKarti.Text = dgv_bilgisayarlar.CurrentRow.Cells[14].Value.ToString();
            cmboBox_diger.Text = dgv_bilgisayarlar.CurrentRow.Cells[15].Value.ToString();
            cmbBox_internet.Text = dgv_bilgisayarlar.CurrentRow.Cells[16].Value.ToString();
            aktarma2();
            ara2(dgv_bilgisayarlar.CurrentRow.Cells[0].Value.ToString());
            ara3(dgv_bilgisayarlar.CurrentRow.Cells[0].Value.ToString());
            ara4(dgv_bilgisayarlar.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgv_bilgisayarlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void temizle()
        {
            txt_sistemNo.Clear(); txt_ipNo.Clear(); txt_departman.Clear(); txt_kullanici.Clear(); txt_islemci.Clear();
            txt_hazifa.Clear(); txt_anakart.Clear(); txt_harddisk.Clear(); txt_monitor.Clear();


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Klasorler SUYetkilendirme = new Klasorler();
            SUYetkilendirme.sistemno = txt_aktar.Text;
            SUYetkilendirme.ShowDialog();
            ara3(dgv_bilgisayarlar.CurrentRow.Cells[0].Value.ToString());
        }
        void listele3()
        {

            db.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarKlasor.klasorid, tbl_klasor.adi, tbl_bilgisayarKlasor.bilgisayarid,tbl_bilgisayarKlasor.seviye, tbl_bilgisayarKlasor.aciklama  FROM tbl_bilgisayarKlasor, tbl_klasor, tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarKlasor.klasorid = tbl_klasor.id and tbl_bilgisayarKimlikKarti.id = tbl_bilgisayarKlasor.bilgisayarid Order By adi ASC ", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarKlasor");
            dgv_serverYetkili.DataSource = ds.Tables["tbl_bilgisayarKlasor"];
            adtr.Dispose();
            db.baglanti.Close();
            dgv_serverYetkili.Columns[1].Visible = false;
            dgv_serverYetkili.Columns[3].Visible = false;
            renklendir2();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_sistemNo.Text != null)
            {
                yazilimekle yazilimekliyorum = new yazilimekle();
                yazilimekliyorum.sistemno = txt_aktar.Text;
                yazilimekliyorum.ShowDialog();
                ara2(dgv_bilgisayarlar.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("seçilmedi");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dgv_bilgisayarlar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            bilgi[0] = dgv_bilgisayarlar.Rows[e.RowIndex].Cells[dgv_bilgisayarlar.Columns[0].Name].Value.ToString();
            bilgi[1] = dgv_bilgisayarlar.Rows[e.RowIndex].Cells[dgv_bilgisayarlar.Columns[1].Name].Value.ToString();
            bilgi[2] = dgv_bilgisayarlar.Rows[e.RowIndex].Cells[dgv_bilgisayarlar.Columns[2].Name].Value.ToString();
            bilgi[3] = dgv_bilgisayarlar.Rows[e.RowIndex].Cells[dgv_bilgisayarlar.Columns[3].Name].Value.ToString();
            bilgi[4] = dgv_bilgisayarlar.Rows[e.RowIndex].Cells[dgv_bilgisayarlar.Columns[4].Name].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.baglanti.State == ConnectionState.Closed)
                    db.baglanti.Open();
                string kayit = "UPDATE tbl_bilgisayarKimlikKarti Set ipno=@ipno,departman=@departman,kullanici=@kullanici,lokasyon=@lokasyon,islemci=@islemci,hafiza=@hafiza,anakart=@anakart,harddisk=@harddisk,ekrankarti=@ekrankarti,monitor=@monitor,disketsurucu=@disketsurucu,cddvd=@cddvd,seskarti=@seskarti,diger=@diger,internet=@internet  where sistemno=@sistemno";
                SqlCommand komut = new SqlCommand(kayit, db.baglanti);

                komut.Parameters.AddWithValue("@ipno", txt_ipNo.Text);
                komut.Parameters.AddWithValue("@departman", txt_departman.Text);
                komut.Parameters.AddWithValue("@kullanici", txt_kullanici.Text);
                komut.Parameters.AddWithValue("@lokasyon", cmbBox_lokasyon.Text);
                komut.Parameters.AddWithValue("@islemci", txt_islemci.Text);
                komut.Parameters.AddWithValue("@hafiza", txt_hazifa.Text);
                komut.Parameters.AddWithValue("@anakart", txt_anakart.Text);
                komut.Parameters.AddWithValue("@harddisk", txt_harddisk.Text);
                komut.Parameters.AddWithValue("@ekrankarti", txt_ekranKarti.Text);
                komut.Parameters.AddWithValue("@monitor", txt_monitor.Text);
                komut.Parameters.AddWithValue("@disketsurucu", cmbBox_disketSurucu.Text);
                komut.Parameters.AddWithValue("@cddvd", cmbBox_cdDvd.Text);
                komut.Parameters.AddWithValue("@seskarti", cmbBox_sesKarti.Text);
                komut.Parameters.AddWithValue("@diger", cmboBox_diger.Text);
                komut.Parameters.AddWithValue("@internet", cmbBox_internet.Text);


                komut.Parameters.AddWithValue("@sistemno", txt_sistemNo.Text);

                komut.ExecuteNonQuery();
                db.baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            listele();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_yazilimlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip_bilgisayar_Opening(object sender, CancelEventArgs e)
        {

        }
        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT logkullanici,logzaman  FROM tbl_bilgisayarKimlikKarti WHERE sistemno='" + txt_sistemNo.Text + "'", db.baglanti);
            adtr.Fill(dt);
            MessageBox.Show("kullanıcı : " + dt.Rows[0][0].ToString() + "  " + "tarih / saat : " + dt.Rows[0][1].ToString());
            db.baglanti.Close();

        }

        private void btn_listele_Click_1(object sender, EventArgs e)
        {
            listele();
            listele2();
            listele3();
            listele4();

        }

        private void logToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT logkullanici,logzaman  FROM tbl_bilgisayarSoftware WHERE bilgisayarid= '" + txt_aktar.Text + "'", db.baglanti);
            adtr.Fill(dt);
            MessageBox.Show("kullanıcı : " + dt.Rows[0][0].ToString() + "  " + "tarih / saat : " + dt.Rows[0][1].ToString());
            db.baglanti.Close();

        }

        private void logToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT logkullanici,logzaman  FROM tbl_bilgisayarKlasor WHERE bilgisayarid= '" + txt_aktar.Text + "'", db.baglanti);
            adtr.Fill(dt);
            MessageBox.Show("kullanıcı : " + dt.Rows[0][0].ToString() + "  " + "tarih / saat : " + dt.Rows[0][1].ToString());
            db.baglanti.Close();
        }

        private void btn_programGetir_Click(object sender, EventArgs e)
        {
            ProgramlariGetir goster = new ProgramlariGetir();
            goster.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KlasorGetir goster2 = new KlasorGetir();
            goster2.ShowDialog();
        }

        private void txt_aktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_bilgisayarKarti_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_serverYetkili_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_ekranKarti_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_yazilimlar_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void btn_arizalar_Click(object sender, EventArgs e)
        {


        }

        private void btn_Arizalar_Click_1(object sender, EventArgs e)
        {
            Ariza arizaislemleri = new Ariza();
            arizaislemleri.idaktarma = txt_aktar.Text;
            arizaislemleri.ShowDialog();

        }

        private void dgv_serverYetkili_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_Ara_Click_1(object sender, EventArgs e)
        {
            KullaniciveİpnoAramaYapma aramayap = new KullaniciveİpnoAramaYapma();
            aramayap.ShowDialog();
        }
        void listele4()
        {

            db.baglanti.Open();

            string sorgu = "SELECT tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarKimlikKarti.kullanici, tbl_bilgisayarAriza.bilgisayarid, tbl_bilgisayarAriza.bildirimtarih,tbl_bilgisayarKimlikKarti.id, tbl_bilgisayarAriza.gidermetarih,tbl_bilgisayarAriza.parcamaliyet FROM  tbl_bilgisayarAriza, tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarAriza.bilgisayarid";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarAriza");
            dgv_ariza.DataSource = ds.Tables["tbl_bilgisayarAriza"];
            adtr.Dispose();
            db.baglanti.Close();
            dgv_ariza.Columns[2].Visible = false;
            dgv_ariza.Columns[4].Visible = false;

        }

        void ara4(string id)
        {

            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("SELECT tbl_bilgisayarKimlikKarti.sistemno, tbl_bilgisayarKimlikKarti.kullanici, tbl_bilgisayarAriza.bilgisayarid, tbl_bilgisayarAriza.bildirimtarih, tbl_bilgisayarKimlikKarti.id, tbl_bilgisayarAriza.gidermetarih, tbl_bilgisayarAriza.parcamaliyet FROM  tbl_bilgisayarAriza, tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarKimlikKarti.id = tbl_bilgisayarAriza.bilgisayarid and  bilgisayarid='" + id + "'", db.baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "tbl_bilgisayarAriza");
            dgv_ariza.DataSource = ds.Tables["tbl_bilgisayarAriza"];
            adtr.Dispose();
            db.baglanti.Close();
            


        }
 


        private void btn_tarih_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_baslangic_ValueChanged(object sender, EventArgs e)
        {

            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            string sql = "SELECT tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarKimlikKarti.kullanici, tbl_bilgisayarAriza.bilgisayarid, tbl_bilgisayarAriza.bildirimtarih,tbl_bilgisayarKimlikKarti.id, tbl_bilgisayarAriza.gidermetarih,tbl_bilgisayarAriza.parcamaliyet FROM  tbl_bilgisayarAriza, tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarAriza.bilgisayarid and bildirimtarih >= @bildirimtarih and gidermetarih<=@gidermetarih and sistemno='" + txt_sistemNo.Text + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@bildirimtarih", dateTimePicker_baslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            adp.SelectCommand.Parameters.AddWithValue("@gidermetarih", dateTimePicker_bitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            adp.Fill(dt);
            con.Close();
            dgv_ariza.DataSource = dt;
        }

        private void dateTimePicker_bitis_ValueChanged(object sender, EventArgs e)
        {
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            string sql = "SELECT tbl_bilgisayarKimlikKarti.sistemno,tbl_bilgisayarKimlikKarti.kullanici, tbl_bilgisayarAriza.bilgisayarid, tbl_bilgisayarAriza.bildirimtarih,tbl_bilgisayarKimlikKarti.id, tbl_bilgisayarAriza.gidermetarih,tbl_bilgisayarAriza.parcamaliyet FROM  tbl_bilgisayarAriza, tbl_bilgisayarKimlikKarti WHERE tbl_bilgisayarKimlikKarti.id=tbl_bilgisayarAriza.bilgisayarid and bildirimtarih >= @bildirimtarih and gidermetarih<=@gidermetarih and sistemno='" + txt_sistemNo.Text + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@bildirimtarih", dateTimePicker_baslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            adp.SelectCommand.Parameters.AddWithValue("@gidermetarih", dateTimePicker_bitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            adp.Fill(dt);
            con.Close();
            dgv_ariza.DataSource = dt;
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            Raporlar raporolustur = new Raporlar();
            raporolustur.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox_Ariza_Enter(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ariza arizaislemleri = new Ariza();
            arizaislemleri.idaktarma = txt_aktar.Text;
            arizaislemleri.ShowDialog();
            ara4(dgv_ariza.CurrentRow.Cells[0].Value.ToString());
        }

        private void logToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (db.baglanti.State != ConnectionState.Open)
                db.baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT logkullanici,logzaman  FROM tbl_bilgisayarAriza WHERE bilgisayarid= '" + txt_aktar.Text + "'", db.baglanti);
            adtr.Fill(dt);
            MessageBox.Show("kullanıcı : " + dt.Rows[0][0].ToString() + "  " + "tarih / saat : " + dt.Rows[0][1].ToString());
            db.baglanti.Close();
        }
    }
}

