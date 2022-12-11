namespace Munch
{
    partial class ViewTable
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
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.DisplayTablesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableDataGridView);
            this.panel1.Controls.Add(this.DisplayTablesButton);
            this.panel1.Location = new System.Drawing.Point(140, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 365);
            this.panel1.TabIndex = 0;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Location = new System.Drawing.Point(74, 111);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(484, 235);
            this.tableDataGridView.TabIndex = 17;
            // 
            // DisplayTablesButton
            // 
            this.DisplayTablesButton.BackColor = System.Drawing.Color.White;
            this.DisplayTablesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisplayTablesButton.FlatAppearance.BorderSize = 0;
            this.DisplayTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayTablesButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTablesButton.Location = new System.Drawing.Point(142, 27);
            this.DisplayTablesButton.Name = "DisplayTablesButton";
            this.DisplayTablesButton.Size = new System.Drawing.Size(349, 57);
            this.DisplayTablesButton.TabIndex = 16;
            this.DisplayTablesButton.Text = "Display Tables";
            this.DisplayTablesButton.UseVisualStyleBackColor = false;
            this.DisplayTablesButton.Click += new System.EventHandler(this.DisplayTablesButton_Click);
            // 
            // ViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTable";
            this.Text = "ViewTable";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Button DisplayTablesButton;
    }
}