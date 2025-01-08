using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEKİMOĞLU_PANSİYON_UYG
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin fr = new FrmAdmin();
            fr.Show();
            
        }
      

      

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmYenıMusterı fr = new FrmYenıMusterı() ;
            fr.Show();
           
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
          
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler fr = new FrmMüsteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEKİMOĞLU PANSİYON UYGULAMASI / KUTAY İNCEDERE / 2024-FATSA       ®️ TÜM HAKLARI SAKLIDIR      ");
        }

        private void FrmAnaForm_Load_1(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGazateOku fr = new FrmGazateOku();
            fr.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }
    }
}
