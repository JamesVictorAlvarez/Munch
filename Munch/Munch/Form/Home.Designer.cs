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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.IndianRed;
            this.menu.Controls.Add(this.settingsButton);
            this.menu.Controls.Add(this.userButton);
            this.menu.Controls.Add(this.tableButton);
            this.menu.Controls.Add(this.customerButton);
            this.menu.Controls.Add(this.reserveButton);
            this.menu.Controls.Add(this.panel1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(179, 602);
            this.menu.TabIndex = 3;
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureMin);
            this.panel2.Controls.Add(this.pictureClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 100);
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
            this.panelPage.Size = new System.Drawing.Size(857, 502);
            this.panelPage.TabIndex = 5;
            // 
            // pictureMin
            // 
            this.pictureMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMin.Image = global::Munch.Properties.Resources.minimize;
            this.pictureMin.Location = new System.Drawing.Point(791, 13);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(26, 28);
            this.pictureMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMin.TabIndex = 2;
            this.pictureMin.TabStop = false;
            this.pictureMin.Click += new System.EventHandler(this.pictureMin_Click);
            this.pictureMin.MouseHover += new System.EventHandler(this.pictureMin_MouseHover);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(823, 13);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(26, 28);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pictureClose.MouseHover += new System.EventHandler(this.pictureClose_MouseHover);
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
            this.settingsButton.Location = new System.Drawing.Point(0, 404);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(179, 76);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(1036, 602);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelPage;
    }
}