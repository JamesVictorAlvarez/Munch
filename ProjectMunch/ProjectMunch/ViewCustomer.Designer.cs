namespace ProjectMunch
{
    partial class ViewCustomerForm
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
            this.ViewCustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.customersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new ProjectMunch.CustomersDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new ProjectMunch.CustomersDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCustomersDataGridView
            // 
            this.ViewCustomersDataGridView.AllowUserToAddRows = false;
            this.ViewCustomersDataGridView.AllowUserToDeleteRows = false;
            this.ViewCustomersDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.ViewCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCustomersDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.ViewCustomersDataGridView.Location = new System.Drawing.Point(80, 64);
            this.ViewCustomersDataGridView.Name = "ViewCustomersDataGridView";
            this.ViewCustomersDataGridView.ReadOnly = true;
            this.ViewCustomersDataGridView.Size = new System.Drawing.Size(443, 331);
            this.ViewCustomersDataGridView.TabIndex = 0;
            // 
            // customersDataSetBindingSource
            // 
            this.customersDataSetBindingSource.DataSource = this.customersDataSet;
            this.customersDataSetBindingSource.Position = 0;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customersDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.ViewCustomersDataGridView);
            this.Name = "ViewCustomerForm";
            this.Text = "ViewCustomer";
            this.Load += new System.EventHandler(this.ViewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewCustomersDataGridView;
        private System.Windows.Forms.BindingSource customersDataSetBindingSource;
        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CustomersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}