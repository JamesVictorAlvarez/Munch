namespace Munch
{
    partial class ModifyReservation
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
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.modifyCustomerButton);
            this.panel1.Controls.Add(this.custNumTextBox);
            this.panel1.Controls.Add(this.custNumLabel);
            this.panel1.Controls.Add(this.reservationDataGridView);
            this.panel1.Location = new System.Drawing.Point(100, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 392);
            this.panel1.TabIndex = 0;
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.reservationDataGridView.Location = new System.Drawing.Point(262, 65);
            this.reservationDataGridView.MaximumSize = new System.Drawing.Size(530, 252);
            this.reservationDataGridView.MinimumSize = new System.Drawing.Size(530, 252);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.Size = new System.Drawing.Size(530, 252);
            this.reservationDataGridView.TabIndex = 25;
            this.reservationDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reservationDataGridView_CellMouseClick);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dateTextBox.Location = new System.Drawing.Point(37, 291);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(194, 26);
            this.dateTextBox.TabIndex = 55;
            this.dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Date (yyyy-mm-dd)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableIdTextBox
            // 
            this.tableIdTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tableIdTextBox.Location = new System.Drawing.Point(39, 183);
            this.tableIdTextBox.Multiline = true;
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.Size = new System.Drawing.Size(194, 26);
            this.tableIdTextBox.TabIndex = 53;
            this.tableIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Table Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time2
            // 
            this.time2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.time2.Location = new System.Drawing.Point(168, 241);
            this.time2.Multiline = true;
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(43, 26);
            this.time2.TabIndex = 50;
            this.time2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time1
            // 
            this.time1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.time1.Location = new System.Drawing.Point(59, 240);
            this.time1.Multiline = true;
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(43, 26);
            this.time1.TabIndex = 49;
            this.time1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.custNameTextBox.Location = new System.Drawing.Point(37, 129);
            this.custNameTextBox.Multiline = true;
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.custNameTextBox.TabIndex = 47;
            this.custNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Customer\'s Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifyCustomerButton
            // 
            this.modifyCustomerButton.BackColor = System.Drawing.Color.White;
            this.modifyCustomerButton.FlatAppearance.BorderSize = 0;
            this.modifyCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyCustomerButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCustomerButton.Location = new System.Drawing.Point(85, 323);
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.Size = new System.Drawing.Size(107, 38);
            this.modifyCustomerButton.TabIndex = 45;
            this.modifyCustomerButton.Text = "Modify Reservation";
            this.modifyCustomerButton.UseVisualStyleBackColor = false;
            this.modifyCustomerButton.Click += new System.EventHandler(this.modifyCustomerButton_Click);
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.custNumTextBox.Location = new System.Drawing.Point(37, 76);
            this.custNumTextBox.Multiline = true;
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.Size = new System.Drawing.Size(194, 26);
            this.custNumTextBox.TabIndex = 44;
            this.custNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custNumLabel
            // 
            this.custNumLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNumLabel.ForeColor = System.Drawing.Color.White;
            this.custNumLabel.Location = new System.Drawing.Point(36, 56);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(195, 17);
            this.custNumLabel.TabIndex = 43;
            this.custNumLabel.Text = "Customer\'s Num";
            this.custNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyReservation";
            this.Text = "ModifyReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        public System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tableIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox time2;
        public System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyCustomerButton;
        public System.Windows.Forms.TextBox custNumTextBox;
        private System.Windows.Forms.Label custNumLabel;
    }
}