using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//connect to databse !!!
using static System.Net.Mime.MediaTypeNames;

namespace Munch
{
    public partial class Login : Form
    {
        Connection con1 = new Connection();
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = con1.connection;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureClose, "Close");
        }

        private void pictureMin_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureMin, "Minimize");
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showPicture_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(showPicture, "Show the Password");
        }

        private void hidePicture_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(hidePicture, "Hide the Password");
        }

        private void showPicture_Click(object sender, EventArgs e)
        {
            showPicture.Hide();
            passwordText.UseSystemPasswordChar = false;
            hidePicture.Show();
        }

        private void hidePicture_Click(object sender, EventArgs e)
        {
            hidePicture.Hide();
            passwordText.UseSystemPasswordChar = true;
            showPicture.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim(), password = passwordText.Text.Trim();
            if (username == String.Empty || password == String.Empty)
                MessageBox.Show("All of the fields must be filled out!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string querry = "SELECT * FROM Login WHERE username = '" + username + "' AND password = '"+ password +"'";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, connection); // The statements and connection string

                    DataTable dataTable = new DataTable(); //Put in a new data table
                    adapter.Fill(dataTable); //Put the data in the data table

                    if (dataTable.Rows.Count > 0) //If there is data, succesfully logged in 
                    {
                        username = usernameText.Text.Trim();
                        password = passwordText.Text.Trim();

                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else //Data table was empty so no user exist
                        MessageBox.Show("Username or Password Invalid", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Database error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }
    }
}
