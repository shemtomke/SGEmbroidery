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

namespace SGEmbroidery.Inventorys
{
    public partial class InventoryDashboard : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public InventoryDashboard()
        {
            InitializeComponent();
            db.ConnectDatabase();
            LoadDataIntoDataGridView();
        }

        private void inventoryDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataIntoDataGridView()
        {
            DataTable dataTable = GetInventoryData();

            inventoryDataView.DataSource = dataTable.DefaultView;
            inventoryDataView.ReadOnly = true;
        }
        DataTable GetInventoryData()
        {
            DataTable inventoryData = new DataTable();

            string query = @"SELECT i.inventoryQuantity, ic.categoryName, isz.sizeName, ico.colourName
                                FROM Inventory i
                                INNER JOIN ItemCategory ic ON i.inventoryCategoryID = ic.categoryID
                                INNER JOIN ItemSize isz ON i.inventorySizeID = isz.sizeID
                                INNER JOIN ItemColor ico ON i.inventoryColor = ico.colourID"
            ;

            var command = db.DbSQLCommand(query);
            SqlDataAdapter adapter = new SqlDataAdapter(db.DbSQLCommand(query));

            adapter.Fill(inventoryData);

            return inventoryData;
        }
    }
}
