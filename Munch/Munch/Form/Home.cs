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

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureClose, "Close");
        }

        private void pictureMin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureMin, "Minimize");
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            OpenForm(new Table());
        }
    }
}
