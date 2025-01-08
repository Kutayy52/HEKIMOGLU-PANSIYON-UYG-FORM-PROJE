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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace HEKİMOĞLU_PANSİYON_UYG
{
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HEKİMOĞLU PANSİYON;Integrated Security=True");

        private void verilerigöster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand(" select * from MusterıEkle", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirişTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkışTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }


        private void BtnVeriGöster_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMai.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtÜcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtOdaGiriş.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtOdaÇıkış.Text = listView1.SelectedItems[0].SubItems[10].Text;



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdano.Text == "101")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda101", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "102")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda102", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "103")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda103", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "104")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda104", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "105")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda105", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "106")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda106", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "107")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda107", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "108")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda108", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }
            else if (TxtOdano.Text == "109")
            {
                con.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda109", con);
                komut.ExecuteNonQuery();
                con.Close();
                verilerigöster();
            }


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTel.Clear();
            TxtMai.Text = "";
            TxtTc.Clear();
            TxtOdano.Clear();
            TxtÜcret.Clear();
            DtOdaÇıkış.Text = "";
            DtOdaGiriş.Text = "";
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            con.Open();
            SqlCommand komut = new SqlCommand("UPDATE MusterıEkle SET Adi = @Adi, Soyadi = @Soyadi, Cinsiyet = @Cinsiyet ,Telefon = @Telefon ,Mail= @Mail, TC = @TC,OdaNO =@OdaNO, Ücret=@Ücret, GirişTarihi =@GirişTarihi, ÇıkışTarihi = @ÇıkışTarihi WHERE Musteriİd = @Musteriİd", con); // 'con' bağlantısını buraya ekledim
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@Musteriİd", id);
            komut.Parameters.AddWithValue("@Telefon", MskTxtTel.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMai.Text);
            komut.Parameters.AddWithValue("@TC", TxtTc.Text);
            komut.Parameters.AddWithValue("@OdaNO", TxtOdano.Text);
            komut.Parameters.AddWithValue("@Ücret", TxtÜcret.Text);
            komut.Parameters.AddWithValue("@GirişTarihi", DtOdaGiriş.Value);
            komut.Parameters.AddWithValue("@ÇıkışTarihi", DtOdaÇıkış.Value);


            komut.ExecuteNonQuery();
          
            con.Close();
            verilerigöster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand(" select * from MusterıEkle WHERE Adi LIKE '%"+textBox1.Text+"%'", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirişTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkışTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }
    }
    //SqlCommand komut = new SqlCommand(" DELETE FROM MusterıEkle where Musteriid=(" + id + ")", con);
}
