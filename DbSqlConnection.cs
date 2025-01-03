using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTrackingAdoNet
{
    class DbSqlConnection
    {
        public SqlConnection Connection()
        {
            SqlConnection baglantı = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            baglantı.Open();
            return baglantı;
        }
    }
}
