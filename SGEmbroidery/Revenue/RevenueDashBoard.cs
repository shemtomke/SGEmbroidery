using SGEmbroidery.Database;
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

namespace SGEmbroidery.Progress
{
    public partial class RevenueDashBoard : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public RevenueDashBoard()
        {
            InitializeComponent();
            db.ConnectDatabase();
            LoadDataIntoDataGridView();
        }
        public DataTable GetFinancialRecord()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT fromDate, toDate, amount FROM Finances";

            SqlDataAdapter adapter = new SqlDataAdapter(db.DbSQLCommand(sql));
            adapter.Fill(dataTable);

            return dataTable;
        }
        private void LoadDataIntoDataGridView()
        {
            DataTable dataTable = GetFinancialRecord();

            dataGridView1.DataSource = dataTable.DefaultView;
            dataGridView1.ReadOnly = true;
        }
    }
}
