using System;
using System.Data;
using System.Data.SqlClient;
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
        DbSqlConnection connection = new DbSqlConnection();
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
            SqlCommand deleteCommand = new SqlCommand("Delete from TblCity where CityId=@cityId", connection.Connection());
            deleteCommand.Parameters.AddWithValue("@cityId", TxtCityNo.Text);
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show($"{TxtCityNo.Text} numaralı şehri silmek istediginize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (tepki == DialogResult.Yes)
            {
                if (TxtCityNo.Text.Trim() == "")
                {
                    MessageBox.Show("Boş numara girişi tekrar deneyin", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    deleteCommand.ExecuteNonQuery();
                }
            }
            DataGridListCity();
            connection.Connection().Close();
        }
        private async Task updateCityDataAsync()
        {
            SqlCommand updateCommand = new SqlCommand("Update TblCity Set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId", connection.Connection());
            updateCommand.Parameters.AddWithValue("@cityId", TxtCityNo.Text);
            updateCommand.Parameters.AddWithValue("@cityName", TxtCityName.Text);
            updateCommand.Parameters.AddWithValue("@cityCountry", TxtCountry.Text);
            if (TxtCityNo.Text.Trim() == "")
            {
                MessageBox.Show("Boş numara girişi tekrar deneyin", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updateCommand.ExecuteNonQuery();
                label4.Visible = true;
                label4.Text = "Şehir Bilgisi güncellendi";
                // 3 saniye bekle
                await Task.Delay(2500);

                // Mesajı tekrar gizle
                label4.Visible = false;
            }
            DataGridListCity();
            connection.Connection().Close();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            deletingCityFromCityTable();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _ = updateCityDataAsync();
        }
    }
}
