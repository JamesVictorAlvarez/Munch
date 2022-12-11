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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveReservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.reservationDataGridView);
            this.panel1.Controls.Add(this.removeCustomerButton);
            this.panel1.Name = "panel1";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.reservationDataGridView.EnableHeadersVisualStyles = false;
            this.reservationDataGridView.GridColor = System.Drawing.Color.Gray;
            this.reservationDataGridView.MultiSelect = false;
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.RowHeadersVisible = false;
            this.reservationDataGridView.RowTemplate.Height = 25;
            this.reservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reservationDataGridView_CellMouseClick);
            // 
            // removeCustomerButton
            // 
            resources.ApplyResources(this.removeCustomerButton, "removeCustomerButton");
            this.removeCustomerButton.BackColor = System.Drawing.Color.White;
            this.removeCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeCustomerButton.FlatAppearance.BorderSize = 0;
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.UseVisualStyleBackColor = false;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // RemoveReservation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveReservation";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.DataGridView reservationDataGridView;
    }
}