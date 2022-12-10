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
    public partial class ViewTables : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jericho Nieva\OneDrive - Vanier College\School\Semester 3\ApplicationDevelopment\Munch-ecb9baf7c193b77f2c79564068be50a0b3343000\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public ViewTables()
        {
            InitializeComponent();
        }

        private void DisplayTablesButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter  sqlDa = new SqlDataAdapter("SELECT * FROM Tables", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            tableDataGridView.DataSource = dtbl;
            connection.Close();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
