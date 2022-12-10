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
    public partial class SearchCustomerForm : Form
    {
        public SearchCustomerForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Rachelle\ProjectMunch\ProjectMunch\Customers.mdf;Integrated Security = True");

        private void searchNum()
        {
            try
            {
                if (searchTextBox.Text != "")
                {
                    connection.Open();
                    string query = "select * from Customers where CustNum like '%" + int.Parse(searchTextBox.Text) + "%'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    //CustomersDataSet dataset = new CustomersDataSet();   
                    var dataset = new DataSet();
                    sda.Fill(dataset);
                    customersDataGridView.DataSource = dataset.Tables[0];
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please fill search field and press correct button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void SearchName()
        {
            try
            {
                if (searchTextBox.Text != "")
                {
                    connection.Open();
                    string query = "select * from Customers where CustName like '%" + searchTextBox.Text + "%'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    //CustomersDataSet dataset = new CustomersDataSet();   
                    var dataset = new DataSet();
                    sda.Fill(dataset);
                    customersDataGridView.DataSource = dataset.Tables[0];
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please fill search field and press correct button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void SearchPhone()
        {
            try
            {
                if (searchTextBox.Text != "")
                {
                    connection.Open();
                    string query = "select * from Customers where CustPhoneNum like '%" + searchTextBox.Text +  "%'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    //CustomersDataSet dataset = new CustomersDataSet();   
                    var dataset = new DataSet();
                    sda.Fill(dataset);
                    customersDataGridView.DataSource = dataset.Tables[0];
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please fill search field and press correct button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void SearchGender()
        {
            try
            {
                if (genderComboBox.SelectedIndex != -1)
                {
                    connection.Open();
                    string query = "select * from Customers where CustGender='" + Gender() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    //CustomersDataSet dataset = new CustomersDataSet();   
                    var dataset = new DataSet();
                    sda.Fill(dataset);
                    customersDataGridView.DataSource = dataset.Tables[0];
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please fill search field and press correct button.");
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

        private void viewAllCustomerButton_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void searchNumButton_Click(object sender, EventArgs e)
        {
            searchNum();
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {
            SearchName();
        }

        private void searchPhoneButton_Click(object sender, EventArgs e)
        {
            SearchPhone();
        }

        private void searchGenderButton_Click(object sender, EventArgs e)
        {
            SearchGender();
        }
    }
}
