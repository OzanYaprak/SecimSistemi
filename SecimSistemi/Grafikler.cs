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
        }
    }
}
