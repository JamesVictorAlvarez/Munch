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
    public partial class SearchTable : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\School\App Dev\Project\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public SearchTable()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tableIdTextBox.Text) && String.IsNullOrEmpty(sectionTextBox.Text) && String.IsNullOrEmpty(capacityTextBox.Text))
                {
                    int tableId = Int32.Parse(tableIdTextBox.Text.Trim());
                    connection.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables WHERE TableId = '" + tableId + "'", connection);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    searchDataGridView.DataSource = dtbl;
                    connection.Close();
                    tableIdTextBox.Clear();
                }

                else if (String.IsNullOrEmpty(tableIdTextBox.Text) && !String.IsNullOrEmpty(sectionTextBox.Text) && !String.IsNullOrEmpty(capacityTextBox.Text))
                {
                    int section = Int32.Parse(sectionTextBox.Text.Trim());
                    int capacity = Int32.Parse(capacityTextBox.Text.Trim());
                    connection.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables WHERE Section = '" + section + "' AND Capacity = '" + capacity + "'", connection);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    searchDataGridView.DataSource = dtbl;
                    connection.Close();
                    sectionTextBox.Clear();
                    capacityTextBox.Clear();
                }

                else if (String.IsNullOrEmpty(tableIdTextBox.Text) && !String.IsNullOrEmpty(sectionTextBox.Text) && String.IsNullOrEmpty(capacityTextBox.Text))
                {
                    int section = Int32.Parse(sectionTextBox.Text.Trim());
                    connection.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables WHERE Section = '" + section + "'", connection);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    searchDataGridView.DataSource = dtbl;
                    connection.Close();
                    sectionTextBox.Clear();
                }

                else if (String.IsNullOrEmpty(tableIdTextBox.Text) && String.IsNullOrEmpty(sectionTextBox.Text) && !String.IsNullOrEmpty(capacityTextBox.Text))
                {
                    int capacity = Int32.Parse(capacityTextBox.Text.Trim());
                    connection.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables WHERE Capacity = '" + capacity + "'", connection);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    searchDataGridView.DataSource = dtbl;
                    connection.Close();
                    capacityTextBox.Clear();
                }

                else
                {
                    MessageBox.Show("Please fill atleast one field.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
