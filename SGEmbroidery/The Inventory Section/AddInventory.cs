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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGEmbroidery.Inventory
{
    public partial class AddInventory : Form
    {
        TheInventory inventory = new TheInventory();
        DatabaseConnection db = new DatabaseConnection();
        GetData getData = new GetData();

        public AddInventory()
        {
            InitializeComponent();
            db.ConnectDatabase();
            LoadItems();
            LoadColor();
            LoadSize();
        }

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            // Add to database 
            AddInventoryDetails(inventory.GetCategoryID(itemCategoryCombo.Text), inventory.GetSizeID(sizeCombo.Text), int.Parse(quantityTxtBx.Text), inventory.GetColorID(colorCombo.Text));
        }
        void AddInventoryDetails(int categoryID, int sizeID, int quantity, int colourID)
        {
            string query = "INSERT INTO Inventory (inventoryCategoryID, inventorySizeID, inventoryQuantity, inventoryColor) VALUES (@categoryID, @sizeID, @quantity, @colorID)";

            var command = db.DbSQLCommand(query);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@sizeID", sizeID);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@colorID", colourID);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully added Inventory!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Failed to add Inventory!");
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

        void UpdateInventoryTable()
        {

        }
        // Populate the ComboBox with the retrieved data
        public void LoadItems()
        {
            itemCategoryCombo.Items.AddRange(getData.GetItemCategory().ToArray());
        }
        public void LoadColor()
        {
            colorCombo.Items.AddRange(getData.GetItemColor().ToArray());
        }
        public void LoadSize()
        {
            sizeCombo.Items.AddRange(getData.GetItemSize().ToArray());
        }
        void ResetForm()
        {
            itemCategoryCombo.Text = "";
            quantityTxtBx.Text = "";
            sizeCombo.Text = "";
            colorCombo.Text = "";
        }
    }
}
