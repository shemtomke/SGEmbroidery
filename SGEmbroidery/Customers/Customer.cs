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

namespace SGEmbroidery
{
    public partial class Customer : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        FormProperties formProperties = new FormProperties();
        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

        public Customer()
        {
            InitializeComponent();
            db.ConnectDatabase();
            InitializeAutocomplete();

            formProperties.ButtonOnClick(customerDashboardBtn);
            formProperties.LoadForm(new Customers.CustomerDashboard(), this.mainPanel);

            formProperties.ButtonReset(AddCustomerBtn);
            formProperties.ButtonReset(button4);
        }
        private void InitializeAutocomplete()
        {
            textSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = autoCompleteCollection;

            textSearch.TextChanged += textSearch_TextChanged;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            formProperties.GoBackToMainPanel(this);
        }
        private void customerDashboardBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(customerDashboardBtn);
            formProperties.LoadForm(new Customers.CustomerDashboard(), this.mainPanel);

            formProperties.ButtonReset(AddCustomerBtn);
            formProperties.ButtonReset(button4);
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(AddCustomerBtn);
            formProperties.LoadForm(new Customers.AddCustomer(), this.mainPanel);

            formProperties.ButtonReset(customerDashboardBtn);
            formProperties.ButtonReset(button4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(button4);
            formProperties.LoadForm(new Customers.UpdateCustomer(), this.mainPanel);

            formProperties.ButtonReset(AddCustomerBtn);
            formProperties.ButtonReset(customerDashboardBtn);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Display a window message in the middle of the window with client details
            // else no results were found
            string searchValue = textSearch.Text;

            SearchDetails(searchValue);
        }
        private void textSearch_TextChanged(object? sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            string partialText = textSearch.Text;

            string sql = "select customerName from Customers WHERE customerName LIKE @partialText";

            var command = db.DbSQLCommand(sql);
            command.Parameters.AddWithValue("@partialText", partialText + "%");

            SqlDataReader reader = command.ExecuteReader();
            autoCompleteCollection.Clear();

            while (reader.Read())
            {
                autoCompleteCollection.Add(reader["customerName"].ToString());
            }

            reader.Close();
        }
        private void SearchDetails(string searchValue)
        {
            string sql = "select * from Customers WHERE customerName = '" + searchValue + "'";

            var command = db.DbSQLCommand(sql);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Create a StringBuilder to store the search results
                    StringBuilder resultsBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        // Append details of each search result to the StringBuilder
                        resultsBuilder.AppendLine($"Customer Name: {reader["customerName"]}");
                        resultsBuilder.AppendLine($"Primary Phone Number: {reader["primaryPhoneNumber"]}");
                        resultsBuilder.AppendLine($"Secondary Phone Number: {reader["secondaryPhoneNumber"]}");
                        resultsBuilder.AppendLine($"Email: {reader["customerEmail"]}");
                        resultsBuilder.AppendLine($"Organization Associated: {reader["customerOrganization"]}");

                        resultsBuilder.AppendLine(); // Add space between search results
                    }

                    // Show search results using a scrollable MessageBox
                    MessageBox.Show(resultsBuilder.ToString(), "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show("No matching results found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
