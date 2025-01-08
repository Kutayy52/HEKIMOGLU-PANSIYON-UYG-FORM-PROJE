using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HEKİMOĞLU_PANSİYON_UYG
{
    public partial class FrmYenıMusterı : Form
    {
        public FrmYenıMusterı()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HEKİMOĞLU PANSİYON;Integrated Security=True");


        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "101";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda101 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Btn102_Click_1(object sender, EventArgs e)
        {
            TxtOdano.Text = "102";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda102 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();

        }


        private void Btn103_Click_1(object sender, EventArgs e)
        {
            TxtOdano.Text = "103";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda103 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "104";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda104 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Btn105_Click_1(object sender, EventArgs e)
        {
            TxtOdano.Text = "105";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda105 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Btn106_Click_1(object sender, EventArgs e)
        {
            TxtOdano.Text = "106";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda106 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Btn107_Click_1(object sender, EventArgs e)
        {
            TxtOdano.Text = "107";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda107 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Btn108_Click_1(object sender, EventArgs e)
        {
            TxtOdano.Text = "108";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda108 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "109";

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda109 (Adi, Soyadi) VALUES (@Adi, @Soyadi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            con.Close();
        }







        private void DtOdaÇıkış_ValueChanged_1(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtOdaGiriş.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtOdaÇıkış.Text);

            TimeSpan sonuç;
            sonuç = BuyukTarih - KucukTarih;

            label11.Text = sonuç.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 500;
            TxtÜcret.Text = Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEŞİL RENKLİ BUTONLAR BOŞ ODALARI GÖSTERİR");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KIRMIZI RENKLİ BUTONLAR DOLU ODALARI GÖSTERİR");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO MusterıEkle (Adi, Soyadi, Cinsiyet,Telefon, Mail, TC, OdaNO, Ücret, GirişTarihi, ÇıkışTarihi) VALUES (@Adi, @Soyadi, @Cinsiyet,@Telefon,@Mail,@TC,@OdaNO,@Ücret,@GirişTarihi,@ÇıkışTarihi)", con);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@Telefon", MskTxtTel.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMai.Text);
            komut.Parameters.AddWithValue("@TC", TxtTc.Text);
            komut.Parameters.AddWithValue("@OdaNO", TxtOdano.Text);
            komut.Parameters.AddWithValue("@Ücret", TxtÜcret.Text);
            komut.Parameters.AddWithValue("@GirişTarihi", DtOdaGiriş.Value);
            komut.Parameters.AddWithValue("@ÇıkışTarihi", DtOdaÇıkış.Value);

            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("MÜŞTERİ KAYDI YAPILDI");

        }

        private void FrmYenıMusterı_Load(object sender, EventArgs e)
        {


            // Oda 101
            con.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Oda101", con);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            con.Close();
            if (Btn101.Text != "101")
            {
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;
            }

            // Oda 102
            con.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Oda102", con);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            con.Close();
            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }

            // Oda 103
            con.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM Oda103", con);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            con.Close();
            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }

            // Oda 104
            con.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM Oda104", con);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            con.Close();
            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }

            // Oda 105
            con.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM Oda105", con);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                Btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            con.Close();
            if (Btn105.Text != "105")
            {
                Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;
            }

            // Oda 106
            con.Open();
            SqlCommand komut6 = new SqlCommand("SELECT * FROM Oda106", con);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            con.Close();
            if (Btn106.Text != "106")
            {
                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;
            }

            // Oda 107
            con.Open();
            SqlCommand komut7 = new SqlCommand("SELECT * FROM Oda107", con);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                Btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            con.Close();
            if (Btn107.Text != "107")
            {
                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;
            }

            // Oda 108
            con.Open();
            SqlCommand komut8 = new SqlCommand("SELECT * FROM Oda108", con);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                Btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            con.Close();
            if (Btn108.Text != "108")
            {
                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }

            // Oda 109
            con.Open();
            SqlCommand komut9 = new SqlCommand("SELECT * FROM Oda109", con);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                Btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            con.Close();
            if (Btn109.Text != "109")
            {
                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    //Data Source=.\SQLEXPRESS;Initial Catalog="HEKİMOĞLU PANSİYON";Integrated Security=True
}
