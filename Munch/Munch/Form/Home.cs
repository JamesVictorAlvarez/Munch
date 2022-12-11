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
            reservationSubMenu.Visible = false;
            customerSubMenu.Visible = false;
            tablesSubMenu.Visible = false;
            userSubMenu.Visible = false;
        }

        private void HideSubPanel() //Hide all the sub panels
        {
            if (reservationSubMenu.Visible == true)
                reservationSubMenu.Visible = false;
            if (customerSubMenu.Visible == true)
                customerSubMenu.Visible = false;
            if (tablesSubMenu.Visible == true)
                tablesSubMenu.Visible = false;
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
            showSubPanel(tablesSubMenu);
            OpenForm(new ViewTable());
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
            homePicture.Visible = false;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Reservation";
            if (currLang == "fr")
                title.Text = "Réservation";
            if (currLang == "es")
                title.Text = "Reserva";
            showSubPanel(reservationSubMenu);
            OpenForm(new ViewReservation());
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            showSubPanel(customerSubMenu);
            OpenForm(new ViewCustomer());
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Add Customer";
            if (currLang == "fr")
                title.Text = "Ajouter un Client";
            if (currLang == "es")
                title.Text = "Agregar Cliente";
            OpenForm(new AddCustomer());
        }

        private void removeCustomer_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Remove Customer";
            if (currLang == "fr")
                title.Text = "Supprimer un Client";
            if (currLang == "es")
                title.Text = "Eliminar Cliente";
            OpenForm(new RemoveCustomer());
        }

        private void modifyCustomer_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Modify Customer";
            if (currLang == "fr")
                title.Text = "Modifier un Client";
            if (currLang == "es")
                title.Text = "Modificar Cliente";
            OpenForm(new ModifyCustomer());
        }

        private void searchCustomer_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Search Customer";
            if (currLang == "fr")
                title.Text = "Chercher un Client";
            if (currLang == "es")
                title.Text = "Búsqueda Cliente";
            OpenForm(new SearchCustomer());
        }

        private void addTables_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Add Table";
            if (currLang == "fr")
                title.Text = "Ajouter un Table";
            if (currLang == "es")
                title.Text = "Agregar Mesas";
            OpenForm(new AddTable());
        }

        private void removeTables_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Remove Table";
            if (currLang == "fr")
                title.Text = "Supprimer un Table";
            if (currLang == "es")
                title.Text = "Eliminar Mesas";
            OpenForm(new RemoveTable());
        }

        private void modifyTables_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Modify Table";
            if (currLang == "fr")
                title.Text = "Modifier un Table";
            if (currLang == "es")
                title.Text = "Modificar Mesas";
            OpenForm(new ModifyTable());
        }

        private void searchTables_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Search Table";
            if (currLang == "fr")
                title.Text = "Chercher un Table";
            if (currLang == "es")
                title.Text = "Búsqueda Mesas";
            OpenForm(new SearchTable());
        }

        private void addReservation_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Add Reservation";
            if (currLang == "fr")
                title.Text = "Ajouter un Réservation";
            if (currLang == "es")
                title.Text = "Agregar Reserva";
            OpenForm(new AddReservation());
        }

        private void removeReservation_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Remove Reservation";
            if (currLang == "fr")
                title.Text = "Supprimer un Réservation";
            if (currLang == "es")
                title.Text = "Eliminar Reserva";
            OpenForm(new RemoveReservation());
        }

        private void modifyReservation_Click(object sender, EventArgs e)
        {
            if (currLang == "eng")
                title.Text = "Modify Reservation";
            if (currLang == "fr")
                title.Text = "Modifier un Réservation";
            if (currLang == "es")
                title.Text = "Modificar Reserva";
            OpenForm(new ModifyReservation());
        }
    }
}
