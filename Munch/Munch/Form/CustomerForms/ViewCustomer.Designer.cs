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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1.Location = new System.Drawing.Point(153, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 424);
            this.panel1.TabIndex = 1;
            // 
            // ViewCustomersDataGridView
            // 
            this.ViewCustomersDataGridView.AllowUserToAddRows = false;
            this.ViewCustomersDataGridView.AllowUserToDeleteRows = false;
            this.ViewCustomersDataGridView.AllowUserToResizeColumns = false;
            this.ViewCustomersDataGridView.AllowUserToResizeRows = false;
            this.ViewCustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewCustomersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ViewCustomersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewCustomersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ViewCustomersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewCustomersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewCustomersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewCustomersDataGridView.EnableHeadersVisualStyles = false;
            this.ViewCustomersDataGridView.GridColor = System.Drawing.Color.Gray;
            this.ViewCustomersDataGridView.Location = new System.Drawing.Point(58, 41);
            this.ViewCustomersDataGridView.MinimumSize = new System.Drawing.Size(550, 272);
            this.ViewCustomersDataGridView.MultiSelect = false;
            this.ViewCustomersDataGridView.Name = "ViewCustomersDataGridView";
            this.ViewCustomersDataGridView.ReadOnly = true;
            this.ViewCustomersDataGridView.RowHeadersVisible = false;
            this.ViewCustomersDataGridView.RowTemplate.Height = 25;
            this.ViewCustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewCustomersDataGridView.Size = new System.Drawing.Size(580, 340);
            this.ViewCustomersDataGridView.TabIndex = 26;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
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