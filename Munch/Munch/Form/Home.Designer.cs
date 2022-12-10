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
            this.label1 = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.userDbDataSet1 = new Munch.UserDbDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Munch.UserDbDataSet1TableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Munch.UserDbDataSet1TableAdapters.TableAdapterManager();
            this.min = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.userSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoScroll = true;
            this.menu.BackColor = System.Drawing.Color.IndianRed;
            this.menu.Controls.Add(this.settingsButton);
            this.menu.Controls.Add(this.userSubMenu);
            this.menu.Controls.Add(this.userButton);
            this.menu.Controls.Add(this.tableButton);
            this.menu.Controls.Add(this.customerButton);
            this.menu.Controls.Add(this.reserveButton);
            this.menu.Controls.Add(this.panel1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(179, 600);
            this.menu.TabIndex = 3;
            // 
            // userSubMenu
            // 
            this.userSubMenu.BackColor = System.Drawing.Color.LightCoral;
            this.userSubMenu.Controls.Add(this.removeUserButton);
            this.userSubMenu.Controls.Add(this.addUserButton);
            this.userSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSubMenu.Location = new System.Drawing.Point(0, 404);
            this.userSubMenu.Name = "userSubMenu";
            this.userSubMenu.Size = new System.Drawing.Size(179, 76);
            this.userSubMenu.TabIndex = 0;
            // 
            // removeUserButton
            // 
            this.removeUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeUserButton.FlatAppearance.BorderSize = 0;
            this.removeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserButton.ForeColor = System.Drawing.Color.White;
            this.removeUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeUserButton.Location = new System.Drawing.Point(0, 39);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.removeUserButton.Size = new System.Drawing.Size(179, 37);
            this.removeUserButton.TabIndex = 6;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserButton.Location = new System.Drawing.Point(0, 0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.addUserButton.Size = new System.Drawing.Size(179, 39);
            this.addUserButton.TabIndex = 5;
            this.addUserButton.Text = "Add User";
            this.addUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.min);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 100);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // panelPage
            // 
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPage.Location = new System.Drawing.Point(179, 100);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(821, 500);
            this.panelPage.TabIndex = 5;
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
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Image = global::Munch.Properties.Resources.minimize;
            this.min.Location = new System.Drawing.Point(756, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(26, 28);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 3;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(788, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 28);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Location = new System.Drawing.Point(0, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(100, 50);
            this.pictureClose.TabIndex = 5;
            this.pictureClose.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = global::Munch.Properties.Resources.settings;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 480);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(179, 76);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Image = global::Munch.Properties.Resources.user;
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.Location = new System.Drawing.Point(0, 328);
            this.userButton.Name = "userButton";
            this.userButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userButton.Size = new System.Drawing.Size(179, 76);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "User";
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableButton.FlatAppearance.BorderSize = 0;
            this.tableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableButton.ForeColor = System.Drawing.Color.White;
            this.tableButton.Image = global::Munch.Properties.Resources.table;
            this.tableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tableButton.Location = new System.Drawing.Point(0, 252);
            this.tableButton.Name = "tableButton";
            this.tableButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tableButton.Size = new System.Drawing.Size(179, 76);
            this.tableButton.TabIndex = 3;
            this.tableButton.Text = "Tables";
            this.tableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Image = global::Munch.Properties.Resources.customer;
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(0, 176);
            this.customerButton.Name = "customerButton";
            this.customerButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customerButton.Size = new System.Drawing.Size(179, 76);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "Customer";
            this.customerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerButton.UseVisualStyleBackColor = true;
            // 
            // reserveButton
            // 
            this.reserveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reserveButton.FlatAppearance.BorderSize = 0;
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.White;
            this.reserveButton.Image = global::Munch.Properties.Resources.reserve2;
            this.reserveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserveButton.Location = new System.Drawing.Point(0, 100);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reserveButton.Size = new System.Drawing.Size(179, 76);
            this.reserveButton.TabIndex = 1;
            this.reserveButton.Text = "Reservation";
            this.reserveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Munch.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.userSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
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
        private System.Windows.Forms.Label label1;
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
    }
}