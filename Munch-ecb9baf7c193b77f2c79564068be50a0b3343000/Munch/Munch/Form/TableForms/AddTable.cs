using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Munch
{
    public partial class AddTable : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jericho Nieva\OneDrive - Vanier College\School\Semester 3\ApplicationDevelopment\Munch-ecb9baf7c193b77f2c79564068be50a0b3343000\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");
        public AddTable()
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
