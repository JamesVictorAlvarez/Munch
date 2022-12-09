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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jericho Nieva\OneDrive - Vanier College\School\Semester 3\ApplicationDevelopment\Munch\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

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
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Table WHERE TableId = " + inTableId, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table Removed");
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
            conn.Close();
        }
    }
}
