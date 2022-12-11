﻿using System;
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
    public partial class RemoveUser : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\School\App Dev\Project\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string username = userText.Text.Trim();
            if (username == String.Empty) //Check if text boxes are not empty
                MessageBox.Show("All of the fields must be filled out!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    connection.Open(); //open connection
                    String query = "DELETE FROM Login WHERE username = @user"; //Query to add into database
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been removed from the database", "REMOVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
