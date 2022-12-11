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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Munch
{
    public partial class RemoveReservation : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        int custNum;
        int tableId;
        
        public RemoveReservation()
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

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Reservation WHERE CustNum = @num AND TableId = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@num", custNum);
                cmd.Parameters.AddWithValue("@id", tableId);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Reservation has been removed from the database", "REMOVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PopulateReservation();
        }

        private void reservationDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = reservationDataGridView.Rows[e.RowIndex];
                custNum = Int32.Parse(row.Cells[0].Value.ToString());
                tableId = Int32.Parse(row.Cells[1].Value.ToString());
            }
        }
    }
}
