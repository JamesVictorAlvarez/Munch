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
    public partial class ModifyReservation : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\School\App Dev\Project\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");

        public ModifyReservation()
        {
            InitializeComponent();
            PopulateReservation();
        }

        private void PopulateReservation()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Reservation";
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

        private void reservationDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = reservationDataGridView.Rows[e.RowIndex];
                // Split the input string into an array of substrings using the space
                // and dash characters as delimiters.
                string[] nums = row.Cells[3].Value.ToString().Split(' ', '-');

                custNumTextBox.Text = row.Cells[0].Value.ToString();
                tableIdTextBox.Text = row.Cells[1].Value.ToString();
                custNameTextBox.Text = row.Cells[2].Value.ToString();
                time1.Text = nums[0];
                time2.Text = nums[3];
                dateTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
            string num = custNumTextBox.Text.Trim(), name = custNameTextBox.Text.Trim(), id = tableIdTextBox.Text.Trim(), timeText1 = time1.Text.Trim(),
                timeText2 = time2.Text.Trim(), date = dateTextBox.Text.Trim();
            string timeTogether = timeText1 + " - " + timeText2;
            if (num == String.Empty || name == String.Empty || id == String.Empty || timeText1 == String.Empty || timeText2 == String.Empty || date == String.Empty) //Check if text boxes are not empty
                MessageBox.Show("All of the fields must be filled out!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    connection.Open(); //open connection
                    String query = "UPDATE Reservation SET CustName = @name, Time = @time, Date = @date " +
                        "WHERE CustNum = @num AND TableId = @id"; //Query to add into database
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@num", Int32.Parse(num));
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(id));
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@time", timeTogether);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Reservation has been modified to the database", "ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                PopulateReservation();
            }
        }
    }
}
