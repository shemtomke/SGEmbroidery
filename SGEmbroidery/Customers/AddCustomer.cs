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

namespace SGEmbroidery.Customers
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerDetails(customerName.Text, customerOrganization.Text, customerEmail.Text, primaryPhone.Text, secondaryPhone.Text);
        }
        // make the form empty
        void ResetForm()
        {
            customerEmail.Text = "";
            customerName.Text = "";
            customerOrganization.Text = "";
            primaryPhone.Text = "";
            secondaryPhone.Text = "";
        }
        public void CustomerDetails(string customerName, string organization, string email, string primaryPhone, string secondaryPhone)
        {
            DatabaseConnection db = new DatabaseConnection();

            db.ConnectDatabase();

            string sql = "INSERT INTO Customers(customerName, primaryPhoneNumber, secondaryPhoneNumber, customerEmail, customerOrganization) VALUES (@customerName, @primaryPhone, @secondaryPhone, @email, @organization)";

            var sqlCommand = db.DbSQLCommand(sql);
            sqlCommand.Parameters.AddWithValue("@customerName", customerName);
            sqlCommand.Parameters.AddWithValue("@primaryPhone", primaryPhone);
            sqlCommand.Parameters.AddWithValue("@secondaryPhone", secondaryPhone);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@organization", organization);

            try
            {
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully added customer!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Failed to add customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.ConnectDatabase().Close();
            }
        }
    }
}
