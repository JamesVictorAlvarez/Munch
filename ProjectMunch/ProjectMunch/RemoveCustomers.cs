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

namespace ProjectMunch
{
    public partial class RemoveCustomersForm : Form
    {
        public RemoveCustomersForm()
        {
            InitializeComponent();
            Populate();
        }

        private void customersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersDataGridView.Rows[e.RowIndex];
                custNumTextBox.Text = row.Cells[0].Value.ToString();
            }
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Rachelle\ProjectMunch\ProjectMunch\Customers.mdf;Integrated Security = True");

        private void removeCustumer()
        {
            try
            {
                if (custNumTextBox.Text != "")
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("delete from Customers where CustNum='" + int.Parse(custNumTextBox.Text) + "' ", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer has been removed!!");
                    connection.Close();
                    Populate();
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

        private void Populate()
        {
            connection.Open();
            string query = "select * from Customers";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //CustomersDataSet dataset = new CustomersDataSet();   
            var dataset = new DataSet();
            sda.Fill(dataset);
            customersDataGridView.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            removeCustumer();
        }
    }
}
