using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEmbroidery.Database
{
    internal class GetData
    {
        DatabaseConnection db = new DatabaseConnection();
        public int inventoryID = -1;
        public List<string> GetItemCategory()
        {
            string sqlQuery = "SELECT categoryName FROM itemCategory";

            List<string> itemList = new List<string>();

            var command = db.DbSQLCommand(sqlQuery);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string item = reader["categoryName"].ToString();
                itemList.Add(item);
            }

            reader.Close();

            return itemList;
        }
        public List<string> GetItemColor()
        {
            string sqlQuery = "SELECT colourName FROM itemColor";

            List<string> colorList = new List<string>();

            var command = db.DbSQLCommand(sqlQuery);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string item = reader["colourName"].ToString();
                colorList.Add(item);
            }

            reader.Close();

            return colorList;
        }
        public List<string> GetItemSize()
        {
            string sqlQuery = "SELECT sizeName FROM itemSize";

            List<string> sizeList = new List<string>();

            var command = db.DbSQLCommand(sqlQuery);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string item = reader["sizeName"].ToString();
                sizeList.Add(item);
            }

            reader.Close();

            return sizeList;
        }
        public List<string> GetInventory()
        {
            string sqlQuery = @"SELECT i.inventoryID, i.inventoryQuantity, ic.categoryName, isz.sizeName, ico.colourName
                                FROM Inventory i
                                INNER JOIN ItemCategory ic ON i.inventoryCategoryID = ic.categoryID
                                INNER JOIN ItemSize isz ON i.inventorySizeID = isz.sizeID
                                INNER JOIN ItemColor ico ON i.inventoryColor = ico.colourID"
            ;

            List<string> inventoryList = new List<string>();

            var command = db.DbSQLCommand(sqlQuery);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(db.DbSQLCommand(sqlQuery));
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                inventoryList.Add(dataSet.Tables[0].Rows[i][0] + " . " + 
                    dataSet.Tables[0].Rows[i][2] + " , " + 
                    dataSet.Tables[0].Rows[i][3] + " , " + 
                    dataSet.Tables[0].Rows[i][4] + " - "+ 
                    dataSet.Tables[0].Rows[i][1]);

                inventoryID = (int)dataSet.Tables[0].Rows[i][0];
            }

            reader.Close();

            return inventoryList;
        }
    }
}
