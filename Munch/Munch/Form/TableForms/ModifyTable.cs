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
    public partial class ModifyTable : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public ModifyTable()
        {
            InitializeComponent();
            connection = con1.connection;
        }

        private void modifyTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (!String.IsNullOrEmpty(tableIdTextBox.Text))
                {
                    int tableId = Int32.Parse(tableIdTextBox.Text.Trim());

                    if (!String.IsNullOrEmpty(capacityTextBox.Text) && !String.IsNullOrEmpty(sectionTextBox.Text))
                    {
                        int capacity = Int32.Parse(capacityTextBox.Text.Trim());
                        int section = Int32.Parse(sectionTextBox.Text.Trim());
                        string query = "UPDATE Tables SET Capacity = @capacity, Section = @section WHERE TableId = @tableId";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@tableId", tableId);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@section", section);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Table Modified.");
                    }
                    else
                    {
                        MessageBox.Show("Please fill all fields");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a table ID");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
