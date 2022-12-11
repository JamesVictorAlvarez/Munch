namespace Munch
{
    partial class RemoveReservation
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
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.removeCustomerButton);
            this.panel1.Controls.Add(this.reservationDataGridView);
            this.panel1.Location = new System.Drawing.Point(104, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 352);
            this.panel1.TabIndex = 0;
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.BackColor = System.Drawing.Color.White;
            this.removeCustomerButton.FlatAppearance.BorderSize = 0;
            this.removeCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCustomerButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCustomerButton.Location = new System.Drawing.Point(347, 287);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(107, 38);
            this.removeCustomerButton.TabIndex = 29;
            this.removeCustomerButton.Text = "Remove Reservation";
            this.removeCustomerButton.UseVisualStyleBackColor = false;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.GridColor = System.Drawing.Color.IndianRed;
            this.reservationDataGridView.Location = new System.Drawing.Point(173, 25);
            this.reservationDataGridView.MaximumSize = new System.Drawing.Size(450, 222);
            this.reservationDataGridView.MinimumSize = new System.Drawing.Size(450, 222);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.Size = new System.Drawing.Size(450, 222);
            this.reservationDataGridView.TabIndex = 24;
            this.reservationDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reservationDataGridView_CellMouseClick);
            // 
            // RemoveReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveReservation";
            this.Text = "RemoveReservation";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.Button removeCustomerButton;
    }
}