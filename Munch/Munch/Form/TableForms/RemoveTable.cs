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
    public partial class RemoveTable : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public RemoveTable()
        {
            InitializeComponent();
            connection = con1.connection;
        }

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            string inTableId = tableIdTextBox.Text.Trim();

            try
            {
                if (tableIdTextBox.Text != "")
                {
                    connection.Open();
                    String query = "DELETE FROM Tables WHERE TableId = @TableId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableId", inTableId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table Removed");
                    tableIdTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void tableIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
