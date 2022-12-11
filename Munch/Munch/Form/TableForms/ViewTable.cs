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
        Connection con1 = new Connection();
        SqlConnection connection;
        public ViewTable()
        {
            InitializeComponent();
            connection = con1.connection;
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
