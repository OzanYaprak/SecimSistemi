using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SecimSistemi
{
    public partial class OyGiris : Form
    {
        public OyGiris()
        {
            InitializeComponent();
        }

        SqlConnection SqlConnection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SecimProjeDB;Integrated Security=True");

        private void ButtonOyGiris_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ILCE (ILCEAD,ARIPARTISI,BUYUKPARTI,CABUKPARTI,DEGISIMPARTISI,EMEKPARTISI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", SqlConnection);

            cmd.Parameters.AddWithValue("@P1", TBIlceAd.Text);
            cmd.Parameters.AddWithValue("@P2", TBAriPartisi.Text);
            cmd.Parameters.AddWithValue("@P3", TBBuyukParti.Text);
            cmd.Parameters.AddWithValue("@P4", TBCabukParti.Text);
            cmd.Parameters.AddWithValue("@P5", TBDegisimPartisi.Text);
            cmd.Parameters.AddWithValue("@P6", TBEmekPartisi.Text);

            cmd.ExecuteNonQueryAsync();

            SqlConnection.Close();

            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void ButtonGrafik_Click(object sender, EventArgs e)
        {
            Grafikler grafikler = new Grafikler();
            grafikler.Show();
        }
    }
}
