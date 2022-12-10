namespace ProjectMunch
{
    partial class ModifyCustomerForm
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
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderComboBox.Location = new System.Drawing.Point(356, 184);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(219, 24);
            this.genderComboBox.TabIndex = 13;
            this.genderComboBox.Text = "Gender";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.nameTextBox.Location = new System.Drawing.Point(356, 69);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(219, 36);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(356, 121);
            this.phoneNumberTextBox.Multiline = true;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(219, 36);
            this.phoneNumberTextBox.TabIndex = 11;
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.genderLabel.Location = new System.Drawing.Point(37, 185);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(222, 23);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Customer\'s Gender:";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneNumLabel.Location = new System.Drawing.Point(37, 134);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(305, 23);
            this.phoneNumLabel.TabIndex = 9;
            this.phoneNumLabel.Text = "Customer\'s Phone Number:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(37, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(213, 25);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Customer\'s Name:";
            // 
            // modifyCustomerButton
            // 
            this.modifyCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.modifyCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyCustomerButton.Location = new System.Drawing.Point(205, 240);
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.Size = new System.Drawing.Size(216, 52);
            this.modifyCustomerButton.TabIndex = 14;
            this.modifyCustomerButton.Text = "Modify Customer";
            this.modifyCustomerButton.UseVisualStyleBackColor = false;
            this.modifyCustomerButton.Click += new System.EventHandler(this.modifyCustomerButton_Click);
            // 
            // custNumLabel
            // 
            this.custNumLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.custNumLabel.Location = new System.Drawing.Point(37, 27);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(213, 25);
            this.custNumLabel.TabIndex = 15;
            this.custNumLabel.Text = "Customer\'s Num:";
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.custNumTextBox.Location = new System.Drawing.Point(356, 12);
            this.custNumTextBox.Multiline = true;
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.Size = new System.Drawing.Size(219, 36);
            this.custNumTextBox.TabIndex = 16;
            this.custNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.customersDataGridView.Location = new System.Drawing.Point(616, 12);
            this.customersDataGridView.MaximumSize = new System.Drawing.Size(443, 292);
            this.customersDataGridView.MinimumSize = new System.Drawing.Size(443, 292);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.Size = new System.Drawing.Size(443, 292);
            this.customersDataGridView.TabIndex = 17;
            this.customersDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customersDataGridView_CellMouseClick);
            // 
            // ModifyCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 316);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.custNumTextBox);
            this.Controls.Add(this.custNumLabel);
            this.Controls.Add(this.modifyCustomerButton);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ModifyCustomerForm";
            this.Text = "Modify Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button modifyCustomerButton;
        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.DataGridView customersDataGridView;
        public System.Windows.Forms.ComboBox genderComboBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox phoneNumberTextBox;
        public System.Windows.Forms.TextBox custNumTextBox;
    }
}