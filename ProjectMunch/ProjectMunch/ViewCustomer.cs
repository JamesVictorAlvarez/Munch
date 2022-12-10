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
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm()
        {
            InitializeComponent();
            Populate();
        }

        
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Rachelle\ProjectMunch\ProjectMunch\Customers.mdf;Integrated Security = True");
        private void Populate()
        {
            connection.Open();
            string query = "select * from Customers";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ViewCustomersDataGridView.DataSource= dataset.Tables[0];
            connection.Close();
        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

        private void insertCustumers()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Customers(CustName,CustPhoneNum,CustGender) values('@CustN', '@CustP', '@CustG'", connection);
            //command.Parameters.AddWithValue("@CustN", CustName.Text);
            //command.Parameters.AddWithValue("@CustP", CustPhoneNum.Text);
            //command.Parameters.AddWithValue("@CustG", CustGender.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
