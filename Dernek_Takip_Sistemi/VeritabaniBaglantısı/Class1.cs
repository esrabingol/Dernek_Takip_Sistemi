using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek_Takip_Sistemi
{
    internal class Class1
    {

        public class VeriTabaniBaglantisi
        {
            SqlConnection baglan;
            private string dynamicConnectionString;
            string connectionString = string.Empty;
            public VeriTabaniBaglantisi(string dbName)
            {
                dynamicConnectionString = dbName;
            }
            public SqlConnection Connect()
            {
                if (baglan?.State != ConnectionState.Open)
                {
                    connectionString = $"Data Source=LAPTOP-IPQTP7GR;Initial Catalog={dynamicConnectionString};Integrated Security=True";

                    baglan = new SqlConnection(connectionString);
                    baglan.Open();
                }

                return baglan;
            }
        }
 


    }
}
