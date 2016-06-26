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


        //Kendi Bağlantı Cümlenizi Ekleyiniz

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

               
                lstKisiler.Items.Add(k);
            }

            Baglanti.Close();

        }

        // Listbox'dan seçim değiştiğinde..
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstKisiler.SelectedIndex == -1)
            {
                return;
            }

            Kisi kisi = (Kisi)lstKisiler.SelectedItem;

            //MessageBox.Show(kisi.KisiID.ToString());
            //MessageBox.Show(kisi.Ad);
            //MessageBox.Show(kisi.Soyad);


        }
    }
}
