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

namespace winSqlTelefon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string BaglantiCumlesi = "server=BURAK; Database=TestDB; User id=sa; Password=wissen;";

        private SqlConnection Baglanti;

        private void btnKisileriGetir_Click(object sender, EventArgs e)
        {
            // btnKisileriGetir butonuna tıklandıktan sonra SqlConnection nesnesini
            // oluşturuyorum.
            Baglanti = new SqlConnection(BaglantiCumlesi);

            // SqlCommand - sorgu çalıştıracak olan nesnemiz.
            string sorgu = "SELECT KisiID, Ad, Soyad FROM Kisiler";
            SqlCommand komutCalistirici = new SqlCommand(sorgu, Baglanti);

            Baglanti.Open();

            // ExecuteReader - okuma amaçlı sorgu çalıştır.
            SqlDataReader okuyucu = komutCalistirici.ExecuteReader();

            // Satır okudukça dön..
            while (okuyucu.Read())
            {
                int id = (int)okuyucu[0];
                string ad = okuyucu[1].ToString();
                string soyad = okuyucu[2].ToString();

                Kisi k = new Kisi();
                k.KisiID = id;
                k.Ad = ad;
                k.Soyad = soyad;

                // "Murat Başeren (1)" formatında listbox'a yazılır.
                lstKisiler.Items.Add(k);
            }

            Baglanti.Close();

        }

        // Listbox'dan seçim değiştiğinde..
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex == -1)
            {
                return;
            }

            Kisi kisi = (Kisi)lstKisiler.SelectedItem;

            //MessageBox.Show(kisi.KisiID.ToString());
            //MessageBox.Show(kisi.Ad);
            //MessageBox.Show(kisi.Soyad);

            AdresleriYukle(kisi);
            TelefonlariYukle(kisi);

            //TelefonlariYukleDataTableIle(kisi);
            TelefonlariYukleDataAdapterIle(kisi);
        }

        private void TelefonlariYukleDataAdapterIle(Kisi kisi)
        {
            lstTelefonlar.Items.Clear();

            Baglanti = new SqlConnection(BaglantiCumlesi);

            string sorgu = "SELECT TelefonID, TelefonNo, TelefonKisiID FROM Telefonlar WHERE TelefonKisiID=" + kisi.KisiID.ToString();

            SqlCommand komutCalistirici =
                new SqlCommand(sorgu, Baglanti);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(komutCalistirici);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["TelefonID"].Visible = false;
        }

        private void TelefonlariYukleDataTableIle(Kisi kisi)
        {
            lstTelefonlar.Items.Clear();

            Baglanti = new SqlConnection(BaglantiCumlesi);

            string sorgu = "SELECT TelefonID, TelefonNo, TelefonKisiID FROM Telefonlar WHERE TelefonKisiID=" + kisi.KisiID.ToString();

            SqlCommand komutCalistirici =
                new SqlCommand(sorgu, Baglanti);

            Baglanti.Open();

            SqlDataReader okuyucu = komutCalistirici.ExecuteReader();

            // DatagridView içine DataTable ister..

            DataTable dt = new DataTable();

            dt.Columns.Add("TelID");
            dt.Columns.Add("TelNo");
            dt.Columns.Add("TelKisiID");

            while (okuyucu.Read())
            {
                int id = (int)okuyucu["TelefonID"];
                string telno = okuyucu["TelefonNo"].ToString();
                int kisiId = (int)okuyucu["TelefonKisiID"];

                // Satır oluşturulur. Satır oluşturulurken datatable'ın NewRow fonksiyonu kullanılır.
                DataRow satir = dt.NewRow();
                satir["TelID"] = id;
                satir["TelNo"] = telno;
                satir["TelKisiID"] = kisiId;

                dt.Rows.Add(satir);
            }

            Baglanti.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["TelID"].Visible = false;
        }

        private void TelefonlariYukle(Kisi kisi)
        {
            lstTelefonlar.Items.Clear();

            Baglanti = new SqlConnection(BaglantiCumlesi);

            string sorgu = "SELECT TelefonID, TelefonNo, TelefonKisiID FROM Telefonlar WHERE TelefonKisiID=" + kisi.KisiID.ToString();

            SqlCommand komutCalistirici =
                new SqlCommand(sorgu, Baglanti);

            Baglanti.Open();

            SqlDataReader okuyucu = komutCalistirici.ExecuteReader();

            while (okuyucu.Read())
            {
                int id = (int)okuyucu["TelefonID"];
                string telno = okuyucu["TelefonNo"].ToString();
                int kisiId = (int)okuyucu["TelefonKisiID"];

                Telefon tel = new Telefon();
                tel.TelefonID = id;
                tel.TelefonNo = telno;
                tel.TelefonKisiID = kisiId;

                lstTelefonlar.Items.Add(tel);
            }

            Baglanti.Close();
        }

        private void AdresleriYukle(Kisi kisi)
        {
            lstAdresler.Items.Clear();

            Baglanti = new SqlConnection(BaglantiCumlesi);

            string sorgu = "SELECT AdresID, AdresTanimi, AdresKisiID FROM Adresler WHERE AdresKisiID=" + kisi.KisiID.ToString();

            SqlCommand komutCalistirici =
                new SqlCommand(sorgu, Baglanti);

            Baglanti.Open();

            SqlDataReader okuyucu = komutCalistirici.ExecuteReader();

            while (okuyucu.Read())
            {
                int id = (int)okuyucu["AdresID"];
                string adresT = okuyucu["AdresTanimi"].ToString();
                int kisiId = (int)okuyucu["AdresKisiID"];

                Adres adres = new Adres();
                adres.AdresID = id;
                adres.AdresTanim = adresT;
                adres.AdresKisiID = kisiId;

                lstAdresler.Items.Add(adres);

            }

            Baglanti.Close();
        }

        private void btnTelefonEkle_Click(object sender, EventArgs e)
        {
            Kisi k = KisiVer();

            if (k == null)
            {
                return;
            }

            string sorgu = "INSERT INTO Telefonlar(TelefonNo, TelefonKisiID) VALUES('{0}',{1})";
            sorgu = string.Format(sorgu, txtTelefonNo.Text, k.KisiID);

            SorguCalistir(BaglantiCumlesi, sorgu);

            TelefonlariYukleDataAdapterIle(k);
        }


        private Kisi KisiVer()
        {
            if (lstKisiler.SelectedIndex == -1)
            {
                MessageBox.Show("Kişi seçiniz..");
                return null;
            }

            Kisi kisi = (Kisi)lstKisiler.SelectedItem;

            return kisi;
        }

        private void SorguCalistir(string baglantiCumlesi, string sorgu)
        {
            SqlConnection Baglanti = new SqlConnection(baglantiCumlesi);

            SqlCommand komutCalistirici =
                new SqlCommand(sorgu, Baglanti);

            try
            {
                Baglanti.Open();
                komutCalistirici.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Baglanti.State != ConnectionState.Closed || Baglanti.State != ConnectionState.Broken)
                {
                    Baglanti.Close();
                }
            }

        }

    }
}
