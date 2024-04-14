using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using SGEmbroidery.Database;

namespace SGEmbroidery
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "" || passwordField.Text == "")
            {
                MessageBox.Show("Username or Password is Null!");
            }
            else
            {
                try
                {
                    //check if it matches the database
                    Logins(usernameField.Text.ToString(), passwordField.Text.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Logins(string username, string password)
        {
            DatabaseConnection db = new DatabaseConnection();
            Dashboard dashboard = new Dashboard();

            db.ConnectDatabase();
            string sql = "select * from [user] where username ='" + username + "' and password ='" + password + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(db.DbSQLCommand(sql));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully!");

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Logins!");
            }
            db.ConnectDatabase().Close();
        }
    }
}
