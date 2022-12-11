namespace Munch
{
    partial class ModifyCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.customersDataGridView);
            this.panel1.Controls.Add(this.custNumTextBox);
            this.panel1.Controls.Add(this.custNumLabel);
            this.panel1.Controls.Add(this.modifyCustomerButton);
            this.panel1.Controls.Add(this.genderComboBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.phoneNumLabel);
            this.panel1.Controls.Add(this.nameLabel);
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
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            this.customersDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customersDataGridView_CellMouseClick);
            // 
            // custNumTextBox
            // 
            resources.ApplyResources(this.custNumTextBox, "custNumTextBox");
            this.custNumTextBox.Name = "custNumTextBox";
            // 
            // custNumLabel
            // 
            resources.ApplyResources(this.custNumLabel, "custNumLabel");
            this.custNumLabel.ForeColor = System.Drawing.Color.White;
            this.custNumLabel.Name = "custNumLabel";
            // 
            // modifyCustomerButton
            // 
            resources.ApplyResources(this.modifyCustomerButton, "modifyCustomerButton");
            this.modifyCustomerButton.BackColor = System.Drawing.Color.White;
            this.modifyCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyCustomerButton.FlatAppearance.BorderSize = 0;
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.UseVisualStyleBackColor = false;
            this.modifyCustomerButton.Click += new System.EventHandler(this.modifyCustomerButton_Click);
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
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // phoneNumberTextBox
            // 
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            // 
            // genderLabel
            // 
            resources.ApplyResources(this.genderLabel, "genderLabel");
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Name = "genderLabel";
            // 
            // phoneNumLabel
            // 
            resources.ApplyResources(this.phoneNumLabel, "phoneNumLabel");
            this.phoneNumLabel.ForeColor = System.Drawing.Color.White;
            this.phoneNumLabel.Name = "phoneNumLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Name = "nameLabel";
            // 
            // ModifyCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox custNumTextBox;
        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.Button modifyCustomerButton;
        public System.Windows.Forms.ComboBox genderComboBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView customersDataGridView;
    }
}