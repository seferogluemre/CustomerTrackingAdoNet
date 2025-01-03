using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTrackingAdoNet
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        DbSqlConnection connection = new DbSqlConnection();
        string queryOption = "";
        private void dataGridCustomerList()
        {
            SqlCommand listCommand = new SqlCommand(queryOption, connection.Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(listCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            queryOption = "select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer Inner join TblCity on TblCity.CityId=TblCustomer.CustomerCity";
            dataGridCustomerList();
        }

        private void dataGridCustomerList(string v)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CmbCustomerCity.Items.Clear();
            // Eğer tıklanan hücre geçerli bir hücre değilse (örneğin sütun başlığına tıklanmışsa), işlem yapma.
            if (e.RowIndex >= 0)
            {
                // Tıklanan satırın tüm hücrelerine erişmek için DataGridViewRow nesnesini alalım.
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // TextBox'lara değerleri aktarma
                TxtCustomerName.Text = selectedRow.Cells["CustomerName"].Value?.ToString();
                TxtCustomerSurname.Text = selectedRow.Cells["CustomerSurname"].Value?.ToString();
                TxtCustomerBalance.Text = selectedRow.Cells["CustomerBalance"].Value?.ToString();
                TxtCustomerNo.Text = selectedRow.Cells["CustomerId"].Value?.ToString();
                CmbCustomerCity.Items.Add(selectedRow.Cells["CityName"].Value?.ToString());
                CmbCustomerCity.SelectedIndex = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryOption = "Execute CustomerListWithCity";
            dataGridCustomerList();
        }

        private void CityListWithCombobox()
        {
            SqlCommand kmt = new SqlCommand("Select * from TblCity", connection.Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(kmt);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CmbCustomerCity.ValueMember = "CityId";
            CmbCustomerCity.DisplayMember = "CityName";
            CmbCustomerCity.DataSource = table;
            connection.Connection().Close();
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            queryOption = "Execute CustomerListWithCity";
            dataGridCustomerList();
            CityListWithCombobox();
        }

        void clearAreas()
        {
            TxtCustomerBalance.Clear();
            TxtCustomerName.Clear();
            TxtCustomerSurname.Clear();
            TxtCustomerNo.Clear();
            CmbCustomerCity.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void addToCityDataToCityTable()
        {
            SqlCommand addCommand = new SqlCommand(
                "insert into TblCustomer (CustomerName, CustomerSurname, CustomerBalance, CustomerStatus, CustomerCity) " +
                "VALUES (@CustomerName, @CustomerSurname, @CustomerBalance, @CustomerStatus, @CustomerCity)", connection.Connection());

            addCommand.Parameters.AddWithValue("@CustomerName", TxtCustomerName.Text.Trim());
            addCommand.Parameters.AddWithValue("@CustomerSurname", TxtCustomerSurname.Text.Trim());
            addCommand.Parameters.AddWithValue("@CustomerBalance", TxtCustomerBalance.Text.Trim());
            addCommand.Parameters.AddWithValue("@CustomerCity", CmbCustomerCity.SelectedValue);

            addCommand.Parameters.AddWithValue("@CustomerStatus", true);
            if (radioButton1.Checked)
            {
                addCommand.Parameters.AddWithValue("@CustomerStatus", true);
            }
            if (radioButton2.Checked)
            {
                addCommand.Parameters.AddWithValue("@CustomerStatus", false);
            }

            addCommand.ExecuteNonQuery();
            queryOption = "Execute CustomerListWithCity";
            dataGridCustomerList();
            clearAreas();
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addToCityDataToCityTable();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("Delete from TblCustomer where CustomerId=@customerId", connection.Connection());
            deleteCommand.Parameters.AddWithValue("@customerId", TxtCustomerNo.Text);
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show($"{TxtCustomerNo.Text} numaralı müşteriyi silmek istediginize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (tepki == DialogResult.Yes)
            {
                if (TxtCustomerNo.Text.Trim() == "")
                {
                    MessageBox.Show("Boş numara girişi tekrar deneyin", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    deleteCommand.ExecuteNonQuery();
              
                }
            }
            dataGridCustomerList();
            clearAreas();
            connection.Connection().Close();
        }
    }
}
