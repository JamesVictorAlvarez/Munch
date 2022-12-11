namespace Munch
{
    partial class AddReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableGridView = new System.Windows.Forms.DataGridView();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableGridView);
            this.panel1.Controls.Add(this.customerGridView);
            this.panel1.Controls.Add(this.reservationDataGridView);
            this.panel1.Controls.Add(this.dateTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tableIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.time2);
            this.panel1.Controls.Add(this.time1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.custNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addCustomerButton);
            this.panel1.Controls.Add(this.custNumTextBox);
            this.panel1.Controls.Add(this.custNumLabel);
            this.panel1.Name = "panel1";
            // 
            // tableGridView
            // 
            resources.ApplyResources(this.tableGridView, "tableGridView");
            this.tableGridView.AllowUserToAddRows = false;
            this.tableGridView.AllowUserToDeleteRows = false;
            this.tableGridView.AllowUserToResizeColumns = false;
            this.tableGridView.AllowUserToResizeRows = false;
            this.tableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableGridView.BackgroundColor = System.Drawing.Color.White;
            this.tableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableGridView.EnableHeadersVisualStyles = false;
            this.tableGridView.GridColor = System.Drawing.Color.Gray;
            this.tableGridView.MultiSelect = false;
            this.tableGridView.Name = "tableGridView";
            this.tableGridView.ReadOnly = true;
            this.tableGridView.RowHeadersVisible = false;
            this.tableGridView.RowTemplate.Height = 25;
            this.tableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableGridView_CellMouseClick);
            // 
            // customerGridView
            // 
            resources.ApplyResources(this.customerGridView, "customerGridView");
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.AllowUserToResizeColumns = false;
            this.customerGridView.AllowUserToResizeRows = false;
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.customerGridView.EnableHeadersVisualStyles = false;
            this.customerGridView.GridColor = System.Drawing.Color.Gray;
            this.customerGridView.MultiSelect = false;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerGridView_CellMouseClick);
            // 
            // reservationDataGridView
            // 
            resources.ApplyResources(this.reservationDataGridView, "reservationDataGridView");
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.AllowUserToResizeColumns = false;
            this.reservationDataGridView.AllowUserToResizeRows = false;
            this.reservationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.reservationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reservationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.reservationDataGridView.EnableHeadersVisualStyles = false;
            this.reservationDataGridView.GridColor = System.Drawing.Color.Gray;
            this.reservationDataGridView.MultiSelect = false;
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.RowHeadersVisible = false;
            this.reservationDataGridView.RowTemplate.Height = 25;
            this.reservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dateTextBox
            // 
            resources.ApplyResources(this.dateTextBox, "dateTextBox");
            this.dateTextBox.Name = "dateTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // tableIdTextBox
            // 
            resources.ApplyResources(this.tableIdTextBox, "tableIdTextBox");
            this.tableIdTextBox.Name = "tableIdTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // time2
            // 
            resources.ApplyResources(this.time2, "time2");
            this.time2.Name = "time2";
            this.time2.TextChanged += new System.EventHandler(this.time2_TextChanged);
            // 
            // time1
            // 
            resources.ApplyResources(this.time1, "time1");
            this.time1.Name = "time1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // custNameTextBox
            // 
            resources.ApplyResources(this.custNameTextBox, "custNameTextBox");
            this.custNameTextBox.Name = "custNameTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
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
            // AddReservation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCustomerButton;
        public System.Windows.Forms.TextBox custNumTextBox;
        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox time2;
        public System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tableIdTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tableGridView;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.DataGridView reservationDataGridView;
    }
}