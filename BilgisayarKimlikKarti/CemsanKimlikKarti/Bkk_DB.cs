using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CemsanKimlikKarti
{
    class Bkk_DB
    {
        static string logPath;
        string dosyaYolu = Yol();
        static string Yol()
        {
            StreamReader file = new StreamReader("LogConn.txt"); //dosyadaki verileri okumak için açıyoruz
            logPath = file.ReadToEnd(); //baştan sona verileri okumak için
            file.Close(); //baglantıyı kapatıyoruz
            return logPath; //aldığımız veriyi (yani yolu) değişkene atıyoruz
        }

        public SqlConnection baglanti = new SqlConnection(logPath); //sql server bağlantısı kuruluyor

        DataTable tablo = new DataTable();


        

    }
}
