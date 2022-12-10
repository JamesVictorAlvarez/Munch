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
using static System.Collections.Specialized.BitVector32;

namespace Munch
{
    public partial class ModifyTable : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jericho Nieva\OneDrive - Vanier College\School\Semester 3\ApplicationDevelopment\Munch-ecb9baf7c193b77f2c79564068be50a0b3343000\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public ModifyTable()
        {
            InitializeComponent();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void modifyTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if(!String.IsNullOrEmpty(tableIdTextBox.Text))
                {
                    int tableId = Int32.Parse(tableIdTextBox.Text.Trim());

                    if(!String.IsNullOrEmpty(capacityTextBox.Text) && !String.IsNullOrEmpty(sectionTextBox.Text))
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
