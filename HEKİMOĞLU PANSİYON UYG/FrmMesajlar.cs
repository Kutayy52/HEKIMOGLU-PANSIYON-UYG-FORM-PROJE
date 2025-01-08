using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HEKİMOĞLU_PANSİYON_UYG
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();

          
          
        }


        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HEKİMOĞLU PANSİYON;Integrated Security=True");


        private void verilerigöster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand(" select * from MüsteriMesajları", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajİd"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
              
               
                listView1.Items.Add(ekle);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO MüsteriMesajları (Adsoyad, Mesaj) VALUES (@Adsoyad, @Mesaj)";
            SqlCommand komut = new SqlCommand(query, con);

            // Parametreleri ekle
            komut.Parameters.AddWithValue("@Adsoyad", textBox1.Text.Trim());
            komut.Parameters.AddWithValue("@Mesaj", richTextBox1.Text.Trim());

            komut.ExecuteNonQuery();
            con.Close();
            verilerigöster();

        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigöster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
