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

namespace Munch
{
    public partial class AddTable : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jericho Nieva\OneDrive - Vanier College\School\Semester 3\ApplicationDevelopment\Munch\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");
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
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Table (Section, Capacity) VALUES ('" + sectionTextBox.Text + "','" + capacityTextBox.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Table Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
