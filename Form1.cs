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

namespace CustomerTrackingAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSqlConnection connection=new DbSqlConnection();
        private void DataGridListCity()
        {
            SqlCommand listCommand = new SqlCommand("Select * from TblCity", connection.Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(listCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();
        }
        private async Task addToCityTableAsync()
        {
            SqlCommand addCommand = new SqlCommand("insert into TblCity (CityName,CityCountry) values (@cityName,@cityCountry)", connection.Connection());
            addCommand.Parameters.AddWithValue("@cityName", TxtCityName.Text);
            addCommand.Parameters.AddWithValue("@cityCountry", TxtCountry.Text);
            addCommand.ExecuteNonQuery();
            connection.Connection().Close();
            DataGridListCity();

            label4.Visible = true;
            // 3 saniye bekle
            await Task.Delay(3000);

            // Mesajı tekrar gizle
            label4.Visible = false;
        }

        private void deletingCityFromCityTable()
        {
            SqlCommand deleteCommand = new SqlCommand("",connection.Connection());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridListCity();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            DataGridListCity();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _ = addToCityTableAsync();
        }
    }
}
