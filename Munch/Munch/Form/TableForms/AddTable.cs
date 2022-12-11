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
    public partial class AddTable : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public AddTable()
        {
            InitializeComponent();
            connection = con1.connection;
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sectionTextBox.Text != "" && capacityTextBox.Text != "")
                {

                    int section = Int32.Parse(sectionTextBox.Text.Trim());
                    int capacity = Int32.Parse(capacityTextBox.Text.Trim());

                    connection.Open();
                    String query = "INSERT INTO Tables (Section, Capacity) VALUES (@section, @capacity)"; //Query to add into database
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table Added");
                    sectionTextBox.Clear();
                    capacityTextBox.Clear();
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
    }
}
