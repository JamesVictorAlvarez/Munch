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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Munch
{
    public partial class RemoveTable : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jericho Nieva\OneDrive - Vanier College\School\Semester 3\ApplicationDevelopment\Munch-ecb9baf7c193b77f2c79564068be50a0b3343000\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public RemoveTable()
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
    }
}
