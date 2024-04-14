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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SGEmbroidery.Customers
{
    public partial class CustomerDashboard : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public CustomerDashboard()
        {
            InitializeComponent();
            db.ConnectDatabase();
            UpdateCustomerCount();
            LoadDataIntoDataGridView();
        }
        public DataTable GetCustomers()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT customerName, primaryPhoneNumber, secondaryPhoneNumber, customerEmail, customerOrganization FROM Customers";

            SqlDataAdapter adapter = new SqlDataAdapter(db.DbSQLCommand(sql));
            adapter.Fill(dataTable);

            return dataTable;
        }
        private void LoadDataIntoDataGridView()
        {
            DataTable dataTable = GetCustomers();

            customerDataView.DataSource = dataTable.DefaultView;
            customerDataView.ReadOnly = true;
        }
        void UpdateCustomerCount()
        {
            string sql = "SELECT COUNT(*) FROM Customers";

            var command = db.DbSQLCommand(sql);
            int rowCount = Convert.ToInt32(command.ExecuteScalar());

            // Update the customer count in a separate table or variable
            // Example: Updating a label on the form
            numberOfCustomers.Text = rowCount.ToString();
        }

        private void numberOfCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
