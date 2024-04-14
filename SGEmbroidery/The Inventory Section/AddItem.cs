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

namespace SGEmbroidery.The_Inventory
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            // Add to the ItemCategory Database
            ItemDetails(itemCategoryTxtBox.Text);
        }
        public void ItemDetails(string categoryName)
        {
            DatabaseConnection db = new DatabaseConnection();

            db.ConnectDatabase();

            string sql = "INSERT INTO ItemCategory(categoryName) VALUES (@categoryName)";

            var sqlCommand = db.DbSQLCommand(sql);
            sqlCommand.Parameters.AddWithValue("@categoryName", categoryName);

            try
            {
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully added Item!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Failed to add Item!");
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
        void ResetForm()
        {
            itemCategoryTxtBox.Text = "";
        }
    }
}
