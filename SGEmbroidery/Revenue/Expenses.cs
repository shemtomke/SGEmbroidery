using SGEmbroidery.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery.Progress
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            ExpenseDetails(fromDateTimePicker.Value, expenseDescription.Text, float.Parse(amount.Text));
        }
        void ResetForm()
        {
            fromDateTimePicker.Value = DateTime.Now;
            amount.Text = "";
            expenseDescription.Text = "";
        }
        public void ExpenseDetails(DateTime datePurchased, string expenseDescription, float amount)
        {
            DatabaseConnection db = new DatabaseConnection();

            db.ConnectDatabase();

            string sql = "INSERT INTO Expenses(expenseDescription, datePurchased, expensesAmount) VALUES (@expenseDescription, @datePurchased, @expensesAmount)";

            var sqlCommand = db.DbSQLCommand(sql);
            sqlCommand.Parameters.AddWithValue("@datePurchased", datePurchased);
            sqlCommand.Parameters.AddWithValue("@expenseDescription", expenseDescription);
            sqlCommand.Parameters.AddWithValue("@expensesAmount", amount);

            try
            {
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Added Expenses!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Failed to Add Expenses!");
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
