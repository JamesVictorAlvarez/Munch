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
    public partial class ViewReservation : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public ViewReservation()
        {
            InitializeComponent();
            connection = con1.connection;
            PopulateReservation();
            
        }

        private void PopulateReservation()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Reservation ORDER BY Date ASC";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var dataset = new DataSet();
                sda.Fill(dataset);
                reservationDataGridView.DataSource = dataset.Tables[0];
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Reservation WHERE CustNum LIKE '%" + searchTextBox.Text + "%' " +
                        "OR TableId LIKE '%" + searchTextBox.Text + "%' " +
                        "OR CustName LIKE '%" + searchTextBox.Text + "%' " +
                        "OR Time LIKE '%" + searchTextBox.Text + "%' " +
                        "OR Date LIKE '%" + searchTextBox.Text + "%'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var dataset = new DataSet();
                    sda.Fill(dataset);
                    reservationDataGridView.DataSource = dataset.Tables[0];
                    connection.Close();
                } catch
                {
                    MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please fill search field and press correct button.");
            }
        }
    }
}
