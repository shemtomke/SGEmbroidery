using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SGEmbroidery.Database
{
    internal class DatabaseConnection
    {
        public SqlConnection ConnectDatabase()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\SHEM TOM\\DOCUMENTS\\DUMPS\\DUMP20230315\\SGEMBROIDERY.MDF\";Integrated Security=True");
            sqlCon.Open();
            return sqlCon;
        }
        public SqlCommand DbSQLCommand(string query)
        {
            SqlCommand sqlCmd = new SqlCommand(query, ConnectDatabase()); 
            return sqlCmd;
        }
    }
}
