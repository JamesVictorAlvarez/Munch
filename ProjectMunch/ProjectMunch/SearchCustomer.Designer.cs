namespace ProjectMunch
{
    partial class SearchCustomerForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.searchNumButton = new System.Windows.Forms.Button();
            this.viewAllCustomerButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.searchPhoneButton = new System.Windows.Forms.Button();
            this.searchGenderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.searchTextBox.Location = new System.Drawing.Point(360, 29);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(218, 36);
            this.searchTextBox.TabIndex = 24;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchLabel.Location = new System.Drawing.Point(25, 40);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(329, 25);
            this.searchLabel.TabIndex = 23;
            this.searchLabel.Text = "Search (Num, Name, Phone):";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderComboBox.Location = new System.Drawing.Point(274, 93);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(219, 24);
            this.genderComboBox.TabIndex = 22;
            this.genderComboBox.Text = "Gender";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.genderLabel.Location = new System.Drawing.Point(23, 90);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(222, 23);
            this.genderLabel.TabIndex = 19;
            this.genderLabel.Text = "Customer\'s Gender:";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.customersDataGridView.Location = new System.Drawing.Point(604, 12);
            this.customersDataGridView.MaximumSize = new System.Drawing.Size(443, 292);
            this.customersDataGridView.MinimumSize = new System.Drawing.Size(443, 292);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.Size = new System.Drawing.Size(443, 292);
            this.customersDataGridView.TabIndex = 25;
            // 
            // searchNumButton
            // 
            this.searchNumButton.BackColor = System.Drawing.Color.IndianRed;
            this.searchNumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchNumButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchNumButton.Location = new System.Drawing.Point(12, 141);
            this.searchNumButton.Name = "searchNumButton";
            this.searchNumButton.Size = new System.Drawing.Size(146, 52);
            this.searchNumButton.TabIndex = 26;
            this.searchNumButton.Text = "Search Num";
            this.searchNumButton.UseVisualStyleBackColor = false;
            this.searchNumButton.Click += new System.EventHandler(this.searchNumButton_Click);
            // 
            // viewAllCustomerButton
            // 
            this.viewAllCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.viewAllCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewAllCustomerButton.Location = new System.Drawing.Point(277, 227);
            this.viewAllCustomerButton.Name = "viewAllCustomerButton";
            this.viewAllCustomerButton.Size = new System.Drawing.Size(216, 52);
            this.viewAllCustomerButton.TabIndex = 27;
            this.viewAllCustomerButton.Text = "View all Customers";
            this.viewAllCustomerButton.UseVisualStyleBackColor = false;
            this.viewAllCustomerButton.Click += new System.EventHandler(this.viewAllCustomerButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.BackColor = System.Drawing.Color.IndianRed;
            this.searchNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchNameButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchNameButton.Location = new System.Drawing.Point(208, 141);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(146, 52);
            this.searchNameButton.TabIndex = 28;
            this.searchNameButton.Text = "Search Name";
            this.searchNameButton.UseVisualStyleBackColor = false;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // searchPhoneButton
            // 
            this.searchPhoneButton.BackColor = System.Drawing.Color.IndianRed;
            this.searchPhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPhoneButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchPhoneButton.Location = new System.Drawing.Point(407, 141);
            this.searchPhoneButton.Name = "searchPhoneButton";
            this.searchPhoneButton.Size = new System.Drawing.Size(146, 52);
            this.searchPhoneButton.TabIndex = 29;
            this.searchPhoneButton.Text = "Search Phone";
            this.searchPhoneButton.UseVisualStyleBackColor = false;
            this.searchPhoneButton.Click += new System.EventHandler(this.searchPhoneButton_Click);
            // 
            // searchGenderButton
            // 
            this.searchGenderButton.BackColor = System.Drawing.Color.IndianRed;
            this.searchGenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGenderButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchGenderButton.Location = new System.Drawing.Point(85, 227);
            this.searchGenderButton.Name = "searchGenderButton";
            this.searchGenderButton.Size = new System.Drawing.Size(146, 52);
            this.searchGenderButton.TabIndex = 30;
            this.searchGenderButton.Text = "Search Gender";
            this.searchGenderButton.UseVisualStyleBackColor = false;
            this.searchGenderButton.Click += new System.EventHandler(this.searchGenderButton_Click);
            // 
            // SearchCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 317);
            this.Controls.Add(this.searchGenderButton);
            this.Controls.Add(this.searchPhoneButton);
            this.Controls.Add(this.searchNameButton);
            this.Controls.Add(this.viewAllCustomerButton);
            this.Controls.Add(this.searchNumButton);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Name = "SearchCustomerForm";
            this.Text = "Search Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        public System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button searchNumButton;
        private System.Windows.Forms.Button viewAllCustomerButton;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button searchPhoneButton;
        private System.Windows.Forms.Button searchGenderButton;
    }
}