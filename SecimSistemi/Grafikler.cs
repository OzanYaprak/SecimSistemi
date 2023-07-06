using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SecimSistemi
{
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }

        SqlConnection SqlConnection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SecimProjeDB;Integrated Security=True");

        private void Grafikler_Load(object sender, EventArgs e)
        {
            //İLÇE ADLARINI COMBOBOX'A ÇEKME İŞLEMİ

            SqlConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT ILCEAD FROM ILCE", SqlConnection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            SqlConnection.Close();

            //GRAFİĞE TOPLAM SONUÇLARI GETİRME

            SqlConnection.Open();

            SqlCommand cmd2 = new SqlCommand("SELECT SUM(ARIPARTISI),SUM(BUYUKPARTI),SUM(CABUKPARTI),SUM(DEGISIMPARTISI),SUM(EMEKPARTISI) FROM ILCE", SqlConnection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("ARI PARTISI",dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("BUYUK PARTI",dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("CABUK PARTI",dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("DEGISIM PARTISI",dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("EMEK PARTISI",dr2[4]);
            }

            SqlConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ILCE WHERE ILCEAD = @P1", SqlConnection);

            cmd.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value= int.Parse(dr[2].ToString());
                progressBar2.Value= int.Parse(dr[3].ToString());
                progressBar3.Value= int.Parse(dr[4].ToString());
                progressBar4.Value= int.Parse(dr[5].ToString());
                progressBar5.Value= int.Parse(dr[6].ToString());

                LBLAriPartisi.Text = dr[2].ToString();
                LBLBüyükParti.Text = dr[3].ToString();
                LBLCabukParti.Text = dr[4].ToString();
                LBLDegisimPartisi.Text = dr[5].ToString();
                LBLEmekPartisi.Text = dr[6].ToString();
            }

            SqlConnection.Close();
        }
    }
}
