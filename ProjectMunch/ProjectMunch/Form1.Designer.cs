namespace ProjectMunch
{
    partial class CustomerForm
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
            this.ViewCustomersButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCustomersButton
            // 
            this.ViewCustomersButton.BackColor = System.Drawing.Color.IndianRed;
            this.ViewCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCustomersButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.ViewCustomersButton.Location = new System.Drawing.Point(48, 57);
            this.ViewCustomersButton.Name = "ViewCustomersButton";
            this.ViewCustomersButton.Size = new System.Drawing.Size(449, 61);
            this.ViewCustomersButton.TabIndex = 1;
            this.ViewCustomersButton.Text = "View Cutomers";
            this.ViewCustomersButton.UseVisualStyleBackColor = false;
            this.ViewCustomersButton.Click += new System.EventHandler(this.ViewCustomersButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddCustomerButton.Location = new System.Drawing.Point(48, 144);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(212, 60);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.removeCustomerButton.Location = new System.Drawing.Point(285, 144);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(212, 60);
            this.removeCustomerButton.TabIndex = 3;
            this.removeCustomerButton.Text = "Remove Customer";
            this.removeCustomerButton.UseVisualStyleBackColor = false;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // modifyCustomerButton
            // 
            this.modifyCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.modifyCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyCustomerButton.Location = new System.Drawing.Point(48, 237);
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.Size = new System.Drawing.Size(212, 63);
            this.modifyCustomerButton.TabIndex = 4;
            this.modifyCustomerButton.Text = "Modify Customer";
            this.modifyCustomerButton.UseVisualStyleBackColor = false;
            this.modifyCustomerButton.Click += new System.EventHandler(this.modifyCustomerButton_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.Color.IndianRed;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchCustomerButton.Location = new System.Drawing.Point(285, 237);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(212, 63);
            this.searchCustomerButton.TabIndex = 5;
            this.searchCustomerButton.Text = "Search Customer";
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ViewCustomersButton);
            this.panel1.Controls.Add(this.modifyCustomerButton);
            this.panel1.Controls.Add(this.searchCustomerButton);
            this.panel1.Controls.Add(this.AddCustomerButton);
            this.panel1.Controls.Add(this.removeCustomerButton);
            this.panel1.Location = new System.Drawing.Point(147, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 355);
            this.panel1.TabIndex = 6;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewCustomersButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.Button modifyCustomerButton;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Panel panel1;
    }
}

