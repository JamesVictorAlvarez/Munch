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
    public partial class AddCustomer : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public AddCustomer()
        {
            InitializeComponent();
            connection = con1.connection;
        }

        private void insertCustumers()
        {
            try
            {
                if (nameTextBox.Text != "" && phoneNumberTextBox.Text != "" && genderComboBox.SelectedIndex != -1)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into Customers(CustName,CustPhoneNum,CustGender) " +
                        "values('" + nameTextBox.Text + "', '" + phoneNumberTextBox.Text + "', '" + Gender(genderComboBox.SelectedIndex) + "')", connection);
                    //command.Parameters.AddWithValue("@CustN", CustName.Text);
                    //command.Parameters.AddWithValue("@CustP", CustPhoneNum.Text);
                    //command.Parameters.AddWithValue("@CustG", CustGender.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer has been added!!");
                    connection.Close();
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

        private string Gender(int index)
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

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            insertCustumers();
        }
    }
}
