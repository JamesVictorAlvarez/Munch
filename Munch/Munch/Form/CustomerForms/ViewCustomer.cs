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
    public partial class ViewCustomer : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;

        public ViewCustomer()
        {
            InitializeComponent();
            connection = con1.connection;
            Populate();
            
        }

        private void Populate()
        {
            connection.Open();
            string query = "select * from Customers";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ViewCustomersDataGridView.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void ViewCustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
