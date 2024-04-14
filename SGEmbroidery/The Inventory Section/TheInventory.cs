using SGEmbroidery.Database;
using SGEmbroidery.Inventory;
using SGEmbroidery.Inventorys;
using SGEmbroidery.The_Inventory;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SGEmbroidery
{
    public partial class TheInventory : Form
    {
        FormProperties formProperties = new FormProperties();
        DatabaseConnection db = new DatabaseConnection();

        public TheInventory()
        {
            InitializeComponent();
            db.ConnectDatabase();
            formProperties.ButtonOnClick(inventoryDashboardBtn);
            formProperties.LoadForm(new InventoryDashboard(), this.mainPanel);

            formProperties.ButtonReset(AddInventoryBtn);
            formProperties.ButtonReset(UpdateInventoryBtn);
            formProperties.ButtonReset(AddItemCategoryBtn);
        }

        private void inventoryDashboardBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(inventoryDashboardBtn);
            formProperties.LoadForm(new InventoryDashboard(), this.mainPanel);

            formProperties.ButtonReset(AddInventoryBtn);
            formProperties.ButtonReset(UpdateInventoryBtn);
            formProperties.ButtonReset(AddItemCategoryBtn);
        }

        private void AddInventoryBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(AddInventoryBtn);
            formProperties.LoadForm(new AddInventory(), this.mainPanel);

            formProperties.ButtonReset(inventoryDashboardBtn);
            formProperties.ButtonReset(UpdateInventoryBtn);
            formProperties.ButtonReset(AddItemCategoryBtn);
        }

        private void AddItemCategoryBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(AddItemCategoryBtn);
            formProperties.LoadForm(new AddItem(), this.mainPanel);

            formProperties.ButtonReset(AddInventoryBtn);
            formProperties.ButtonReset(inventoryDashboardBtn);
            formProperties.ButtonReset(UpdateInventoryBtn);
        }

        private void UpdateInventoryBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(UpdateInventoryBtn);
            formProperties.LoadForm(new UpdateInventory(), this.mainPanel);

            formProperties.ButtonReset(AddInventoryBtn);
            formProperties.ButtonReset(inventoryDashboardBtn);
            formProperties.ButtonReset(AddItemCategoryBtn);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        public int GetCategoryID(string categoryName)
        {
            int categoryID = 0;

            string query = "SELECT categoryID FROM ItemCategory WHERE categoryName = @categoryName";

            var command = db.DbSQLCommand(query);
            command.Parameters.AddWithValue("@categoryName", categoryName);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    categoryID = reader.GetInt32(0);
                }
            }

            return categoryID;
        }
        public int GetSizeID(string sizeName)
        {
            int sizeID = 0;

            string query = "SELECT sizeID FROM ItemSize WHERE sizeName = @sizeName";
            var command = db.DbSQLCommand(query);

            command.Parameters.AddWithValue("@sizeName", sizeName);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    sizeID = reader.GetInt32(0);
                }
            }

            return sizeID;
        }
        public int GetColorID(string colorName)
        {
            int colorID = 0;

            string query = "SELECT colourID FROM ItemColor WHERE colourName = @colourName";
            var command = db.DbSQLCommand(query);

            command.Parameters.AddWithValue("@colourName", colorName);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    colorID = reader.GetInt32(0);
                }
            }

            return colorID;
        }
    }
}
