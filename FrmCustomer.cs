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
    }
}
