using Org.BouncyCastle.Asn1.Cms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGEmbroidery.Inventorys
{
    public partial class UpdateInventory : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        GetData getData = new GetData();

        public UpdateInventory()
        {
            InitializeComponent();
            db.ConnectDatabase();
            LoadInventory();
        }
        // Combo Box
        void LoadInventory()
        {
            inventoryCategoryCombo.Items.AddRange(getData.GetInventory().ToArray());

            for (int i = 0; i < inventoryCategoryCombo.Items.Count; i++)
            {

            }
        }
        public void InventoryComboChange(object sender, EventArgs e)
        {
            FetchInventoryDetails(getData.inventoryID);
        }
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {

        }
        private void updateInventoryBtn_Click(object sender, EventArgs e)
        {

        }
        void FetchInventoryDetails(int inventoryID)
        {
            string sql = @"SELECT i.inventoryID, i.inventoryQuantity, ic.categoryName, isz.sizeName, ico.colourName
                                FROM Inventory i
                                INNER JOIN ItemCategory ic ON i.inventoryCategoryID = ic.categoryID
                                INNER JOIN ItemSize isz ON i.inventorySizeID = isz.sizeID
                                INNER JOIN ItemColor ico ON i.inventoryColor = ico.colourID WHERE inventoryID = '" + inventoryID + "'"
            ;
            var command = db.DbSQLCommand(sql);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    quantityTxtBx.Text = reader.GetInt32(1).ToString();
                    sizeTxtBx.Text = reader.GetString(3);
                    colourTextBx.Text = reader.GetString(4);
                }
            }
        }
    }
}