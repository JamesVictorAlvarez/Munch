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
    public partial class ModifyCustomer : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\School\App Dev\Project\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public ModifyCustomer()
        {
            InitializeComponent();
            Populate();
        }

        private void modifyCustumer()
        {
            try
            {
                if (nameTextBox.Text != "" && phoneNumberTextBox.Text != "" && genderComboBox.SelectedIndex != -1)
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("update Customers set CustName='" + nameTextBox.Text + "', CustPhoneNum='" + phoneNumberTextBox.Text + "', CustGender='" + Gender() + "' " +
                        "where CustNum='" + int.Parse(custNumTextBox.Text) + "' ", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer has been modified!!");
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

        private string Gender()
        {
            if (genderComboBox.SelectedIndex == 0)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
            modifyCustumer();
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

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersDataGridView.Rows[e.RowIndex];
                custNumTextBox.Text = row.Cells[0].Value.ToString();
                nameTextBox.Text = row.Cells[1].Value.ToString();
                phoneNumberTextBox.Text = row.Cells[2].Value.ToString();
                genderComboBox.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
