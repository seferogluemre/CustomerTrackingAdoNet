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


        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridListCity();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            DataGridListCity();
        }
    }
}
