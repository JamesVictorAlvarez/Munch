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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tableGridView = new System.Windows.Forms.DataGridView();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
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
            this.panel1.Controls.Add(this.tableGridView);
            this.panel1.Controls.Add(this.customerGridView);
            this.panel1.Controls.Add(this.reservationDataGridView);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 577);
            this.panel1.TabIndex = 0;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dateTextBox.Location = new System.Drawing.Point(365, 498);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(194, 26);
            this.dateTextBox.TabIndex = 42;
            this.dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(367, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date (yyyy-mm-dd)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableIdTextBox
            // 
            this.tableIdTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tableIdTextBox.Location = new System.Drawing.Point(367, 390);
            this.tableIdTextBox.Multiline = true;
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.Size = new System.Drawing.Size(194, 26);
            this.tableIdTextBox.TabIndex = 40;
            this.tableIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Table Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(455, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time2
            // 
            this.time2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.time2.Location = new System.Drawing.Point(496, 448);
            this.time2.Multiline = true;
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(43, 26);
            this.time2.TabIndex = 35;
            this.time2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time2.TextChanged += new System.EventHandler(this.time2_TextChanged);
            // 
            // time1
            // 
            this.time1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.time1.Location = new System.Drawing.Point(387, 447);
            this.time1.Multiline = true;
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(43, 26);
            this.time1.TabIndex = 34;
            this.time1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(365, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.custNameTextBox.Location = new System.Drawing.Point(365, 336);
            this.custNameTextBox.Multiline = true;
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.custNameTextBox.TabIndex = 32;
            this.custNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Customer\'s Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.White;
            this.addCustomerButton.FlatAppearance.BorderSize = 0;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(413, 530);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(107, 38);
            this.addCustomerButton.TabIndex = 28;
            this.addCustomerButton.Text = "Add Reservation";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.custNumTextBox.Location = new System.Drawing.Point(365, 283);
            this.custNumTextBox.Multiline = true;
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.Size = new System.Drawing.Size(194, 26);
            this.custNumTextBox.TabIndex = 27;
            this.custNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custNumLabel
            // 
            this.custNumLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNumLabel.ForeColor = System.Drawing.Color.White;
            this.custNumLabel.Location = new System.Drawing.Point(364, 263);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(195, 17);
            this.custNumLabel.TabIndex = 26;
            this.custNumLabel.Text = "Customer\'s Num";
            this.custNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableGridView
            // 
            this.tableGridView.AllowUserToAddRows = false;
            this.tableGridView.AllowUserToDeleteRows = false;
            this.tableGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.tableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGridView.GridColor = System.Drawing.Color.IndianRed;
            this.tableGridView.Location = new System.Drawing.Point(588, 263);
            this.tableGridView.MaximumSize = new System.Drawing.Size(300, 250);
            this.tableGridView.MinimumSize = new System.Drawing.Size(300, 250);
            this.tableGridView.Name = "tableGridView";
            this.tableGridView.ReadOnly = true;
            this.tableGridView.Size = new System.Drawing.Size(300, 250);
            this.tableGridView.TabIndex = 25;
            this.tableGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableGridView_CellMouseClick);
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.GridColor = System.Drawing.Color.IndianRed;
            this.customerGridView.Location = new System.Drawing.Point(29, 263);
            this.customerGridView.MaximumSize = new System.Drawing.Size(300, 250);
            this.customerGridView.MinimumSize = new System.Drawing.Size(300, 250);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.Size = new System.Drawing.Size(300, 250);
            this.customerGridView.TabIndex = 24;
            this.customerGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerGridView_CellMouseClick);
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.reservationDataGridView.Location = new System.Drawing.Point(167, 14);
            this.reservationDataGridView.MaximumSize = new System.Drawing.Size(600, 222);
            this.reservationDataGridView.MinimumSize = new System.Drawing.Size(600, 222);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.Size = new System.Drawing.Size(600, 222);
            this.reservationDataGridView.TabIndex = 23;
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 683);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.DataGridView tableGridView;
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
    }
}