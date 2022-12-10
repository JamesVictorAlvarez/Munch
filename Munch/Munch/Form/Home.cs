using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Munch
{
    public partial class Home : Form
    {
        private Form currentForm; //To know which is the current form to show
        public Home()
        {
            InitializeComponent();
            OnStartSubPanel();
        }

        private void OpenForm(Form f)
        {
            if(currentForm != null)
            {
                currentForm.Close(); //Close the previous form if there is before opening this form
            }
            currentForm = f;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelPage.Controls.Add(f);
            this.panelPage.Tag = f;
            f.Show();
        }

        //Hide the sub panels on start
        private void OnStartSubPanel() 
        {
            userSubMenu.Visible = false;
        }

        private void HideSubPanel()
        {
            if (userSubMenu.Visible == true)
                userSubMenu.Visible = false;
        }

        private void showSubPanel(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideSubPanel(); //Hide every sub panel just in case
                menu.Visible = true; //Show the sub panel
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDbDataSet1.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.userDbDataSet1.Login);

        }

        private void pictureClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(close, "Close");
        }

        private void pictureMin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(min, "Minimize");
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            OpenForm(new Table());
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDbDataSet1);

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            showSubPanel(userSubMenu);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            OpenForm(new AddUser());
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            OpenForm(new RemoveUser());
        }
    }
}
