using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Munch
{
    public partial class Home : Form
    {
        private Form currentForm; //To know which is the current form to show
        String currLang = "eng";
        public Home()
        {
            InitializeComponent();
            OnStartSubPanel();
            closePanel.Visible = false;
            timer.Start();
            hideSettings();
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
            hideSettings();
            closePanel.Visible = true;
            homePicture.Visible = false;
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
            HideSubPanel();
            if (currLang == "eng")
                title.Text = "Tables";
            if (currLang == "fr")
                title.Text = "Tables";
            if (currLang == "es")
                title.Text = "Mesas";
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
            if (currentForm != null)
            {
                currentForm.Close(); //Close the previous form if there is before opening this form
            }
            languageBox.Visible = true;
            settingsPanel.Visible = true;
            langLabel.Visible = true;
            darkLabel.Visible = true;
            audioLabel.Visible = true;
            logoutButton.Visible = true;
            homePicture.Visible = false;
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
            if (currLang == "eng")
                title.Text = "Add User";
            if (currLang == "fr")
                title.Text = "Ajouter un Utilisateur";
            if (currLang == "es")
                title.Text = "Agregar Usuario";
            OpenForm(new AddUser());
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Remove User";
            if (currLang == "fr")
                title.Text = "Supprimer un Utilisateur";
            if (currLang == "es")
                title.Text = "Eliminar Usuario";
            OpenForm(new RemoveUser());
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
                currentForm.Close();
            HideSubPanel();
            title.Text = "HOME";
            if (currLang == "eng")
                title.Text = "HOME";
            if (currLang == "fr")
                title.Text = "PAGE D'ACCUEIL";
            if (currLang == "es")
                title.Text = "HOGAR";
            closePanel.Visible = false;
            homePicture.Visible = true;
            hideSettings();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToShortTimeString();
        }

        private void hideSettings()
        {
            languageBox.Visible = false;
            settingsPanel.Visible = false;
            langLabel.Visible = false;
            darkLabel.Visible = false;
            audioLabel.Visible = false;
            logoutButton.Visible = false;
        }

        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageBox.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    currLang = "eng";
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
                    currLang = "fr";
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    currLang = "es";
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();
            HideSubPanel();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Close();
        }

    }
}
