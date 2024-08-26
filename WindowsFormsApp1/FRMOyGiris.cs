using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=LAPTOP-HJDDK6A0\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;TrustServerCertificate=True"); 
        private void BTNOYGİRİŞ_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6) ", baglanti);
            komut.Parameters.AddWithValue("@P1", TXTAD.Text);
            komut.Parameters.AddWithValue("@P2", TXTA.Text);
            komut.Parameters.AddWithValue("@P3", TXTB.Text);
            komut.Parameters.AddWithValue("@P4", TXTC.Text);
            komut.Parameters.AddWithValue("@P5", TXTD.Text);
            komut.Parameters.AddWithValue("@P6", TXTE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("OY GİRİŞİ GERÇEKLEŞTİ");

        }

        private void BTNGRAFİK_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr=new FrmGrafikler(); 
            fr.Show();
        }
    }
}
