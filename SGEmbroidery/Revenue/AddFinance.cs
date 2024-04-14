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
    public partial class AddFinance : Form
    {
        public AddFinance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinanceDetails(fromDateTimePicker1.Value, toDateTimePicker1.Value, float.Parse(totalAmount.Text));
        }
        void ResetForm()
        {
            fromDateTimePicker1.Value = DateTime.Now;
            toDateTimePicker1.Value = DateTime.Now;
            totalAmount.Text = "";
        }
        public void FinanceDetails(DateTime fromDate, DateTime toDate, float amount)
        {
            DatabaseConnection db = new DatabaseConnection();

            db.ConnectDatabase();

            string sql = "INSERT INTO Finances(fromDate, toDate, amount) VALUES (@fromDate, @toDate, @amount)";

            var sqlCommand = db.DbSQLCommand(sql);
            sqlCommand.Parameters.AddWithValue("@fromDate", fromDate);
            sqlCommand.Parameters.AddWithValue("@toDate", toDate);
            sqlCommand.Parameters.AddWithValue("@amount", amount);

            try
            {
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully added Financial Record!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Failed to add Financial Record!");
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