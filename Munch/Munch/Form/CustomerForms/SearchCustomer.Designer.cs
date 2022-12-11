namespace Munch
{
    partial class SearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.searchGenderButton = new System.Windows.Forms.Button();
            this.searchPhoneButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.viewAllCustomerButton = new System.Windows.Forms.Button();
            this.searchNumButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.customersDataGridView);
            this.panel1.Controls.Add(this.searchGenderButton);
            this.panel1.Controls.Add(this.searchPhoneButton);
            this.panel1.Controls.Add(this.searchNameButton);
            this.panel1.Controls.Add(this.viewAllCustomerButton);
            this.panel1.Controls.Add(this.searchNumButton);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.genderComboBox);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Name = "panel1";
            // 
            // customersDataGridView
            // 
            resources.ApplyResources(this.customersDataGridView, "customersDataGridView");
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AllowUserToResizeColumns = false;
            this.customersDataGridView.AllowUserToResizeRows = false;
            this.customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.customersDataGridView.EnableHeadersVisualStyles = false;
            this.customersDataGridView.GridColor = System.Drawing.Color.Gray;
            this.customersDataGridView.MultiSelect = false;
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersVisible = false;
            this.customersDataGridView.RowTemplate.Height = 25;
            this.customersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // searchGenderButton
            // 
            resources.ApplyResources(this.searchGenderButton, "searchGenderButton");
            this.searchGenderButton.BackColor = System.Drawing.Color.White;
            this.searchGenderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchGenderButton.FlatAppearance.BorderSize = 0;
            this.searchGenderButton.Name = "searchGenderButton";
            this.searchGenderButton.UseVisualStyleBackColor = false;
            this.searchGenderButton.Click += new System.EventHandler(this.searchGenderButton_Click);
            // 
            // searchPhoneButton
            // 
            resources.ApplyResources(this.searchPhoneButton, "searchPhoneButton");
            this.searchPhoneButton.BackColor = System.Drawing.Color.White;
            this.searchPhoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPhoneButton.FlatAppearance.BorderSize = 0;
            this.searchPhoneButton.Name = "searchPhoneButton";
            this.searchPhoneButton.UseVisualStyleBackColor = false;
            this.searchPhoneButton.Click += new System.EventHandler(this.searchPhoneButton_Click);
            // 
            // searchNameButton
            // 
            resources.ApplyResources(this.searchNameButton, "searchNameButton");
            this.searchNameButton.BackColor = System.Drawing.Color.White;
            this.searchNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchNameButton.FlatAppearance.BorderSize = 0;
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.UseVisualStyleBackColor = false;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // viewAllCustomerButton
            // 
            resources.ApplyResources(this.viewAllCustomerButton, "viewAllCustomerButton");
            this.viewAllCustomerButton.BackColor = System.Drawing.Color.White;
            this.viewAllCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllCustomerButton.FlatAppearance.BorderSize = 0;
            this.viewAllCustomerButton.Name = "viewAllCustomerButton";
            this.viewAllCustomerButton.UseVisualStyleBackColor = false;
            this.viewAllCustomerButton.Click += new System.EventHandler(this.viewAllCustomerButton_Click);
            // 
            // searchNumButton
            // 
            resources.ApplyResources(this.searchNumButton, "searchNumButton");
            this.searchNumButton.BackColor = System.Drawing.Color.White;
            this.searchNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchNumButton.FlatAppearance.BorderSize = 0;
            this.searchNumButton.Name = "searchNumButton";
            this.searchNumButton.UseVisualStyleBackColor = false;
            this.searchNumButton.Click += new System.EventHandler(this.searchNumButton_Click);
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Name = "searchTextBox";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Name = "searchLabel";
            // 
            // genderComboBox
            // 
            resources.ApplyResources(this.genderComboBox, "genderComboBox");
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            resources.GetString("genderComboBox.Items"),
            resources.GetString("genderComboBox.Items1")});
            this.genderComboBox.Name = "genderComboBox";
            // 
            // genderLabel
            // 
            resources.ApplyResources(this.genderLabel, "genderLabel");
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Name = "genderLabel";
            // 
            // SearchCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchGenderButton;
        private System.Windows.Forms.Button searchPhoneButton;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button viewAllCustomerButton;
        private System.Windows.Forms.Button searchNumButton;
        public System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        public System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.DataGridView customersDataGridView;
    }
}