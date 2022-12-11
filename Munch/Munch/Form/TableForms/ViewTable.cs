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
    public partial class ViewTable : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\School\App Dev\Project\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public ViewTable()
        {
            InitializeComponent();
        }

        private void DisplayTablesButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            tableDataGridView.DataSource = dtbl;
            connection.Close();
        }
    }
}
