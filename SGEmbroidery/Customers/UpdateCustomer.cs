using SGEmbroidery.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGEmbroidery.Customers
{
    public partial class UpdateCustomer : Form
    {
        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
        Database.DatabaseConnection db = new Database.DatabaseConnection();
        string customerId = "";

        public UpdateCustomer()
        {
            InitializeComponent();
            db.ConnectDatabase();
            InitializeAutocomplete();
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            UpdateCustomerDetails(customerId);
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            // delete customer from database
            DeleteCustomer(customerId);
        }
        private void InitializeAutocomplete()
        {
            customerName.AutoCompleteMode = AutoCompleteMode.Suggest;
            customerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            customerName.AutoCompleteCustomSource = autoCompleteCollection;

            customerName.TextChanged += customerName_TextChanged;
        }
        // when selecting the name from the autocomplete then fill other text box
        void FetchCustomerDetails(string customerName)
        {
            string sql = "select * from Customers WHERE customerName = '" + customerName + "'";

            var command = db.DbSQLCommand(sql);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Retrieve the customer details from the reader and do something with them
                    customerOrganization.Text = reader["customerOrganization"].ToString();
                    primaryPhone.Text = reader["primaryPhoneNumber"].ToString();
                    secondaryPhone.Text = reader["secondaryPhoneNumber"].ToString();
                    customerEmail.Text = reader["customerEmail"].ToString();
                    customerId = reader["customerID"]?.ToString() ?? "";
                }
            }
        }
        private void customerName_TextChanged(object? sender, EventArgs e)
        {
            string partialText = customerName.Text;

            string sql = "select customerName from Customers WHERE customerName LIKE @partialText";

            var command = db.DbSQLCommand(sql);
            command.Parameters.AddWithValue("@partialText", partialText + "%");

            SqlDataReader reader = command.ExecuteReader();
            autoCompleteCollection.Clear();

            while (reader.Read())
            {
                autoCompleteCollection.Add(reader["customerName"].ToString());
            }

            FetchCustomerDetails(customerName.Text);

            reader.Close();
        }
        void UpdateCustomerDetails(string customerId)
        {
            try
            {
                if (!string.IsNullOrEmpty(customerId))
                {
                    string sql = "UPDATE Customers SET customerName = @customerName, primaryPhoneNumber = @primaryPhoneNumber, secondaryPhoneNumber = @secondaryPhoneNumber, customerEmail = @customerEmail, customerOrganization = @customerOrganization WHERE customerID = @customerId";

                    var command = db.DbSQLCommand(sql);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@customerOrganization", customerOrganization.Text);
                    command.Parameters.AddWithValue("@primaryPhoneNumber", primaryPhone.Text);
                    command.Parameters.AddWithValue("@secondaryPhoneNumber", secondaryPhone.Text);
                    command.Parameters.AddWithValue("@customerName", customerName.Text);
                    command.Parameters.AddWithValue("@customerEmail", customerEmail.Text);

                    // Display confirmation message box
                    DialogResult result = MessageBox.Show("Are you sure you want to update these customer details?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Updated Customer Successfully!");
                        ResetForm();
                    }
                }
                else
                {
                    MessageBox.Show("Enter customer details to update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the customer: " + ex.Message);
            }
        }
        void DeleteCustomer(string customerID)
        {
            try
            {
                if (!string.IsNullOrEmpty(customerID))
                {
                    string sql = "DELETE FROM Customers WHERE customerID = @customerID";

                    var command = db.DbSQLCommand(sql);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    // Display confirmation message box
                    DialogResult result = MessageBox.Show("Are you sure you want to delete these customer details?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted Customer Successfully!");
                        ResetForm();
                    }
                }
                else
                {
                    MessageBox.Show("Enter customer details to delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the customer: " + ex.Message);
            }
        }
        void ResetForm()
        {
            customerId = "";
            customerEmail.Text = "";
            customerName.Text = "";
            customerOrganization.Text = "";
            primaryPhone.Text = "";
            secondaryPhone.Text = "";
        }
    }
}
