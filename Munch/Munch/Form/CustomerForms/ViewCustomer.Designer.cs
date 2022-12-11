namespace Munch
{
    partial class ViewCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewCustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.ViewCustomersDataGridView);
            this.panel1.Location = new System.Drawing.Point(187, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 393);
            this.panel1.TabIndex = 1;
            // 
            // ViewCustomersDataGridView
            // 
            this.ViewCustomersDataGridView.AllowUserToAddRows = false;
            this.ViewCustomersDataGridView.AllowUserToDeleteRows = false;
            this.ViewCustomersDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.ViewCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCustomersDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.ViewCustomersDataGridView.Location = new System.Drawing.Point(27, 45);
            this.ViewCustomersDataGridView.Name = "ViewCustomersDataGridView";
            this.ViewCustomersDataGridView.ReadOnly = true;
            this.ViewCustomersDataGridView.Size = new System.Drawing.Size(409, 321);
            this.ViewCustomersDataGridView.TabIndex = 1;
            this.ViewCustomersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCustomersDataGridView_CellContentClick);
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCustomer";
            this.Text = "ViewCustomer";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ViewCustomersDataGridView;
    }
}