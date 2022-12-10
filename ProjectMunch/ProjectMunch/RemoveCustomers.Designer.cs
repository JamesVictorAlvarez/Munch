namespace ProjectMunch
{
    partial class RemoveCustomersForm
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
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.customersDataGridView.Location = new System.Drawing.Point(30, 146);
            this.customersDataGridView.MaximumSize = new System.Drawing.Size(443, 292);
            this.customersDataGridView.MinimumSize = new System.Drawing.Size(443, 292);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.Size = new System.Drawing.Size(443, 292);
            this.customersDataGridView.TabIndex = 18;
            this.customersDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customersDataGridView_CellMouseClick);
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.custNumTextBox.Location = new System.Drawing.Point(254, 24);
            this.custNumTextBox.Multiline = true;
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.Size = new System.Drawing.Size(219, 36);
            this.custNumTextBox.TabIndex = 20;
            this.custNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custNumLabel
            // 
            this.custNumLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.custNumLabel.Location = new System.Drawing.Point(26, 35);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(213, 25);
            this.custNumLabel.TabIndex = 19;
            this.custNumLabel.Text = "Customer\'s Num:";
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.removeCustomerButton.Location = new System.Drawing.Point(144, 76);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(216, 52);
            this.removeCustomerButton.TabIndex = 21;
            this.removeCustomerButton.Text = "Remove Customer";
            this.removeCustomerButton.UseVisualStyleBackColor = false;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // RemoveCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.removeCustomerButton);
            this.Controls.Add(this.custNumTextBox);
            this.Controls.Add(this.custNumLabel);
            this.Controls.Add(this.customersDataGridView);
            this.Name = "RemoveCustomersForm";
            this.Text = "Remove Customers";
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDataGridView;
        public System.Windows.Forms.TextBox custNumTextBox;
        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.Button removeCustomerButton;
    }
}