namespace Munch
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menu = new System.Windows.Forms.Panel();
            this.userSubMenu = new System.Windows.Forms.Panel();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.audioLabel = new System.Windows.Forms.Label();
            this.darkLabel = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.userDbDataSet1 = new Munch.UserDbDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Munch.UserDbDataSet1TableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Munch.UserDbDataSet1TableAdapters.TableAdapterManager();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.reservationSubMenu = new System.Windows.Forms.Panel();
            this.deleteReservation = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.Button();
            this.modifyReservation = new System.Windows.Forms.Button();
            this.customerSubMenu = new System.Windows.Forms.Panel();
            this.removeCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.modifyCustomer = new System.Windows.Forms.Button();
            this.searchCustomer = new System.Windows.Forms.Button();
            this.tablesSubMenu = new System.Windows.Forms.Panel();
            this.removeTables = new System.Windows.Forms.Button();
            this.addTables = new System.Windows.Forms.Button();
            this.modifyTables = new System.Windows.Forms.Button();
            this.searchTables = new System.Windows.Forms.Button();
            this.homePicture = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePanel = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.userSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.reservationSubMenu.SuspendLayout();
            this.customerSubMenu.SuspendLayout();
            this.tablesSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.BackColor = System.Drawing.Color.IndianRed;
            this.menu.Controls.Add(this.settingsButton);
            this.menu.Controls.Add(this.userSubMenu);
            this.menu.Controls.Add(this.userButton);
            this.menu.Controls.Add(this.tablesSubMenu);
            this.menu.Controls.Add(this.tableButton);
            this.menu.Controls.Add(this.customerSubMenu);
            this.menu.Controls.Add(this.customerButton);
            this.menu.Controls.Add(this.reservationSubMenu);
            this.menu.Controls.Add(this.reserveButton);
            this.menu.Controls.Add(this.panel1);
            this.menu.Name = "menu";
            // 
            // userSubMenu
            // 
            this.userSubMenu.BackColor = System.Drawing.Color.LightCoral;
            this.userSubMenu.Controls.Add(this.removeUserButton);
            this.userSubMenu.Controls.Add(this.addUserButton);
            resources.ApplyResources(this.userSubMenu, "userSubMenu");
            this.userSubMenu.Name = "userSubMenu";
            // 
            // removeUserButton
            // 
            resources.ApplyResources(this.removeUserButton, "removeUserButton");
            this.removeUserButton.FlatAppearance.BorderSize = 0;
            this.removeUserButton.ForeColor = System.Drawing.Color.White;
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // addUserButton
            // 
            resources.ApplyResources(this.addUserButton, "addUserButton");
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.closePanel);
            this.panel2.Controls.Add(this.min);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.title);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Name = "title";
            // 
            // panelPage
            // 
            this.panelPage.Controls.Add(this.homePicture);
            this.panelPage.Controls.Add(this.settingsPanel);
            resources.ApplyResources(this.panelPage, "panelPage");
            this.panelPage.Name = "panelPage";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.IndianRed;
            this.settingsPanel.Controls.Add(this.logoutButton);
            this.settingsPanel.Controls.Add(this.audioLabel);
            this.settingsPanel.Controls.Add(this.darkLabel);
            this.settingsPanel.Controls.Add(this.languageBox);
            this.settingsPanel.Controls.Add(this.langLabel);
            resources.ApplyResources(this.settingsPanel, "settingsPanel");
            this.settingsPanel.Name = "settingsPanel";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // audioLabel
            // 
            resources.ApplyResources(this.audioLabel, "audioLabel");
            this.audioLabel.ForeColor = System.Drawing.Color.White;
            this.audioLabel.Name = "audioLabel";
            // 
            // darkLabel
            // 
            resources.ApplyResources(this.darkLabel, "darkLabel");
            this.darkLabel.ForeColor = System.Drawing.Color.White;
            this.darkLabel.Name = "darkLabel";
            // 
            // languageBox
            // 
            this.languageBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.languageBox, "languageBox");
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            resources.GetString("languageBox.Items"),
            resources.GetString("languageBox.Items1"),
            resources.GetString("languageBox.Items2")});
            this.languageBox.Name = "languageBox";
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.languageBox_SelectedIndexChanged);
            // 
            // langLabel
            // 
            resources.ApplyResources(this.langLabel, "langLabel");
            this.langLabel.ForeColor = System.Drawing.Color.White;
            this.langLabel.Name = "langLabel";
            // 
            // userDbDataSet1
            // 
            this.userDbDataSet1.DataSetName = "UserDbDataSet1";
            this.userDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.userDbDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Munch.UserDbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // reservationSubMenu
            // 
            this.reservationSubMenu.BackColor = System.Drawing.Color.LightCoral;
            this.reservationSubMenu.Controls.Add(this.modifyReservation);
            this.reservationSubMenu.Controls.Add(this.deleteReservation);
            this.reservationSubMenu.Controls.Add(this.addReservation);
            resources.ApplyResources(this.reservationSubMenu, "reservationSubMenu");
            this.reservationSubMenu.Name = "reservationSubMenu";
            // 
            // deleteReservation
            // 
            resources.ApplyResources(this.deleteReservation, "deleteReservation");
            this.deleteReservation.FlatAppearance.BorderSize = 0;
            this.deleteReservation.ForeColor = System.Drawing.Color.White;
            this.deleteReservation.Name = "deleteReservation";
            this.deleteReservation.UseVisualStyleBackColor = true;
            // 
            // addReservation
            // 
            resources.ApplyResources(this.addReservation, "addReservation");
            this.addReservation.FlatAppearance.BorderSize = 0;
            this.addReservation.ForeColor = System.Drawing.Color.White;
            this.addReservation.Name = "addReservation";
            this.addReservation.UseVisualStyleBackColor = true;
            // 
            // modifyReservation
            // 
            resources.ApplyResources(this.modifyReservation, "modifyReservation");
            this.modifyReservation.FlatAppearance.BorderSize = 0;
            this.modifyReservation.ForeColor = System.Drawing.Color.White;
            this.modifyReservation.Name = "modifyReservation";
            this.modifyReservation.UseVisualStyleBackColor = true;
            // 
            // customerSubMenu
            // 
            this.customerSubMenu.BackColor = System.Drawing.Color.LightCoral;
            this.customerSubMenu.Controls.Add(this.searchCustomer);
            this.customerSubMenu.Controls.Add(this.modifyCustomer);
            this.customerSubMenu.Controls.Add(this.removeCustomer);
            this.customerSubMenu.Controls.Add(this.addCustomer);
            resources.ApplyResources(this.customerSubMenu, "customerSubMenu");
            this.customerSubMenu.Name = "customerSubMenu";
            // 
            // removeCustomer
            // 
            resources.ApplyResources(this.removeCustomer, "removeCustomer");
            this.removeCustomer.FlatAppearance.BorderSize = 0;
            this.removeCustomer.ForeColor = System.Drawing.Color.White;
            this.removeCustomer.Name = "removeCustomer";
            this.removeCustomer.UseVisualStyleBackColor = true;
            this.removeCustomer.Click += new System.EventHandler(this.removeCustomer_Click);
            // 
            // addCustomer
            // 
            resources.ApplyResources(this.addCustomer, "addCustomer");
            this.addCustomer.FlatAppearance.BorderSize = 0;
            this.addCustomer.ForeColor = System.Drawing.Color.White;
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // modifyCustomer
            // 
            resources.ApplyResources(this.modifyCustomer, "modifyCustomer");
            this.modifyCustomer.FlatAppearance.BorderSize = 0;
            this.modifyCustomer.ForeColor = System.Drawing.Color.White;
            this.modifyCustomer.Name = "modifyCustomer";
            this.modifyCustomer.UseVisualStyleBackColor = true;
            this.modifyCustomer.Click += new System.EventHandler(this.modifyCustomer_Click);
            // 
            // searchCustomer
            // 
            resources.ApplyResources(this.searchCustomer, "searchCustomer");
            this.searchCustomer.FlatAppearance.BorderSize = 0;
            this.searchCustomer.ForeColor = System.Drawing.Color.White;
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.UseVisualStyleBackColor = true;
            this.searchCustomer.Click += new System.EventHandler(this.searchCustomer_Click);
            // 
            // tablesSubMenu
            // 
            this.tablesSubMenu.BackColor = System.Drawing.Color.LightCoral;
            this.tablesSubMenu.Controls.Add(this.searchTables);
            this.tablesSubMenu.Controls.Add(this.modifyTables);
            this.tablesSubMenu.Controls.Add(this.removeTables);
            this.tablesSubMenu.Controls.Add(this.addTables);
            resources.ApplyResources(this.tablesSubMenu, "tablesSubMenu");
            this.tablesSubMenu.Name = "tablesSubMenu";
            // 
            // removeTables
            // 
            resources.ApplyResources(this.removeTables, "removeTables");
            this.removeTables.FlatAppearance.BorderSize = 0;
            this.removeTables.ForeColor = System.Drawing.Color.White;
            this.removeTables.Name = "removeTables";
            this.removeTables.UseVisualStyleBackColor = true;
            this.removeTables.Click += new System.EventHandler(this.removeTables_Click);
            // 
            // addTables
            // 
            resources.ApplyResources(this.addTables, "addTables");
            this.addTables.FlatAppearance.BorderSize = 0;
            this.addTables.ForeColor = System.Drawing.Color.White;
            this.addTables.Name = "addTables";
            this.addTables.UseVisualStyleBackColor = true;
            this.addTables.Click += new System.EventHandler(this.addTables_Click);
            // 
            // modifyTables
            // 
            resources.ApplyResources(this.modifyTables, "modifyTables");
            this.modifyTables.FlatAppearance.BorderSize = 0;
            this.modifyTables.ForeColor = System.Drawing.Color.White;
            this.modifyTables.Name = "modifyTables";
            this.modifyTables.UseVisualStyleBackColor = true;
            this.modifyTables.Click += new System.EventHandler(this.modifyTables_Click);
            // 
            // searchTables
            // 
            resources.ApplyResources(this.searchTables, "searchTables");
            this.searchTables.FlatAppearance.BorderSize = 0;
            this.searchTables.ForeColor = System.Drawing.Color.White;
            this.searchTables.Name = "searchTables";
            this.searchTables.UseVisualStyleBackColor = true;
            this.searchTables.Click += new System.EventHandler(this.searchTables_Click);
            // 
            // homePicture
            // 
            this.homePicture.Image = global::Munch.Properties.Resources.menu;
            resources.ApplyResources(this.homePicture, "homePicture");
            this.homePicture.Name = "homePicture";
            this.homePicture.TabStop = false;
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = global::Munch.Properties.Resources.settings;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // userButton
            // 
            resources.ApplyResources(this.userButton, "userButton");
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Image = global::Munch.Properties.Resources.user;
            this.userButton.Name = "userButton";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // tableButton
            // 
            resources.ApplyResources(this.tableButton, "tableButton");
            this.tableButton.FlatAppearance.BorderSize = 0;
            this.tableButton.ForeColor = System.Drawing.Color.White;
            this.tableButton.Image = global::Munch.Properties.Resources.table;
            this.tableButton.Name = "tableButton";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // customerButton
            // 
            resources.ApplyResources(this.customerButton, "customerButton");
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Image = global::Munch.Properties.Resources.customer;
            this.customerButton.Name = "customerButton";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // reserveButton
            // 
            resources.ApplyResources(this.reserveButton, "reserveButton");
            this.reserveButton.FlatAppearance.BorderSize = 0;
            this.reserveButton.ForeColor = System.Drawing.Color.White;
            this.reserveButton.Image = global::Munch.Properties.Resources.reserve2;
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Munch.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.Transparent;
            this.closePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.closePanel, "closePanel");
            this.closePanel.Image = global::Munch.Properties.Resources.home;
            this.closePanel.Name = "closePanel";
            this.closePanel.UseVisualStyleBackColor = false;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            // 
            // min
            // 
            resources.ApplyResources(this.min, "min");
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Image = global::Munch.Properties.Resources.minimize;
            this.min.Name = "min";
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Name = "close";
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.userSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPage.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.reservationSubMenu.ResumeLayout(false);
            this.customerSubMenu.ResumeLayout(false);
            this.tablesSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Panel panelPage;
        private UserDbDataSet1 userDbDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private UserDbDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
        private UserDbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Panel userSubMenu;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button closePanel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Label darkLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox homePicture;
        private System.Windows.Forms.Panel tablesSubMenu;
        private System.Windows.Forms.Button searchTables;
        private System.Windows.Forms.Button modifyTables;
        private System.Windows.Forms.Button removeTables;
        private System.Windows.Forms.Button addTables;
        private System.Windows.Forms.Panel customerSubMenu;
        private System.Windows.Forms.Button searchCustomer;
        private System.Windows.Forms.Button modifyCustomer;
        private System.Windows.Forms.Button removeCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Panel reservationSubMenu;
        private System.Windows.Forms.Button modifyReservation;
        private System.Windows.Forms.Button deleteReservation;
        private System.Windows.Forms.Button addReservation;
    }
}