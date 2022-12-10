using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMunch
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void ViewCustomersButton_Click(object sender, EventArgs e)
        {
            ViewCustomerForm viewForm = new ViewCustomerForm();
            viewForm.Show();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rachelle\ProjectMunch\ProjectMunch\Customers.mdf;Integrated Security=True");

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomersForm addForm = new AddCustomersForm();
            addForm.Show(); 
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
            ModifyCustomerForm modifyForm = new ModifyCustomerForm();
            modifyForm.Show();  
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            RemoveCustomersForm removeForm = new RemoveCustomersForm();
            removeForm.Show();  
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            SearchCustomerForm searchForm = new SearchCustomerForm();
            searchForm.Show();
        }
    }
}
