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

namespace Munch
{
    public partial class ModifyUser : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public ModifyUser()
        {
            InitializeComponent();
            connection = con1.connection;
            PopulateUser();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string username = userText.Text.Trim(), password = passText.Text.Trim();
            if (username == String.Empty || password == String.Empty ) //Check if text boxes are not empty
                MessageBox.Show("All of the fields must be filled out!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    connection.Open(); //open connection
                    String query = "UPDATE Login SET username = @user, password = @pass WHERE Username = @user"; //Query to add into database
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been modified from the database", "MODIFIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                PopulateUser();
            }
        }

        private void PopulateUser()
        {
            try
            {
                connection.Open();
                string query = "SELECT username FROM Login";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var dataset = new DataSet();
                sda.Fill(dataset);
                userDataGridView.DataSource = dataset.Tables[0];
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = userDataGridView.Rows[e.RowIndex];
                userText.Text = row.Cells[0].Value.ToString();
            }
        }

        private void userDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = userDataGridView.Rows[e.RowIndex];
                userText.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
