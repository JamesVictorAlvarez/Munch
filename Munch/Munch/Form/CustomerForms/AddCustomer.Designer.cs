namespace Munch
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.genderComboBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.phoneNumLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.addCustomerButton);
            this.panel1.Name = "panel1";
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
            // addCustomerButton
            // 
            resources.ApplyResources(this.addCustomerButton, "addCustomerButton");
            this.addCustomerButton.BackColor = System.Drawing.Color.White;
            this.addCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerButton.FlatAppearance.BorderSize = 0;
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // AddCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addCustomerButton;
    }
}