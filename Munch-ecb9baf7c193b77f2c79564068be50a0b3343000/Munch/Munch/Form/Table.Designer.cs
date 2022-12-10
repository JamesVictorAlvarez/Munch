namespace Munch
{
    partial class Table
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
            this.ViewTablesButton = new System.Windows.Forms.Button();
            this.searchTableButton = new System.Windows.Forms.Button();
            this.modifyTableButton = new System.Windows.Forms.Button();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.ViewTablesButton);
            this.panel1.Controls.Add(this.searchTableButton);
            this.panel1.Controls.Add(this.modifyTableButton);
            this.panel1.Controls.Add(this.removeTableButton);
            this.panel1.Controls.Add(this.addTableButton);
            this.panel1.Location = new System.Drawing.Point(96, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 347);
            this.panel1.TabIndex = 5;
            // 
            // ViewTablesButton
            // 
            this.ViewTablesButton.BackColor = System.Drawing.Color.White;
            this.ViewTablesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewTablesButton.FlatAppearance.BorderSize = 0;
            this.ViewTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTablesButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTablesButton.Location = new System.Drawing.Point(150, 65);
            this.ViewTablesButton.Name = "ViewTablesButton";
            this.ViewTablesButton.Size = new System.Drawing.Size(349, 57);
            this.ViewTablesButton.TabIndex = 4;
            this.ViewTablesButton.Text = "View Tables";
            this.ViewTablesButton.UseVisualStyleBackColor = false;
            this.ViewTablesButton.Click += new System.EventHandler(this.ViewTablesButton_Click);
            // 
            // searchTableButton
            // 
            this.searchTableButton.BackColor = System.Drawing.Color.White;
            this.searchTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchTableButton.FlatAppearance.BorderSize = 0;
            this.searchTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTableButton.Location = new System.Drawing.Point(342, 229);
            this.searchTableButton.Name = "searchTableButton";
            this.searchTableButton.Size = new System.Drawing.Size(157, 57);
            this.searchTableButton.TabIndex = 3;
            this.searchTableButton.Text = "Search";
            this.searchTableButton.UseVisualStyleBackColor = false;
            this.searchTableButton.Click += new System.EventHandler(this.searchTableButton_Click);
            // 
            // modifyTableButton
            // 
            this.modifyTableButton.BackColor = System.Drawing.Color.White;
            this.modifyTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyTableButton.FlatAppearance.BorderSize = 0;
            this.modifyTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyTableButton.Location = new System.Drawing.Point(150, 229);
            this.modifyTableButton.Name = "modifyTableButton";
            this.modifyTableButton.Size = new System.Drawing.Size(157, 57);
            this.modifyTableButton.TabIndex = 2;
            this.modifyTableButton.Text = "Modify Table";
            this.modifyTableButton.UseVisualStyleBackColor = false;
            this.modifyTableButton.Click += new System.EventHandler(this.modifyTableButton_Click);
            // 
            // removeTableButton
            // 
            this.removeTableButton.BackColor = System.Drawing.Color.White;
            this.removeTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTableButton.FlatAppearance.BorderSize = 0;
            this.removeTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTableButton.Location = new System.Drawing.Point(342, 145);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(157, 57);
            this.removeTableButton.TabIndex = 1;
            this.removeTableButton.Text = "Remove Table";
            this.removeTableButton.UseVisualStyleBackColor = false;
            this.removeTableButton.Click += new System.EventHandler(this.removeTableButton_Click);
            // 
            // addTableButton
            // 
            this.addTableButton.BackColor = System.Drawing.Color.White;
            this.addTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTableButton.FlatAppearance.BorderSize = 0;
            this.addTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTableButton.Location = new System.Drawing.Point(150, 145);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(157, 57);
            this.addTableButton.TabIndex = 0;
            this.addTableButton.Text = "Add Table";
            this.addTableButton.UseVisualStyleBackColor = false;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 464);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewTablesButton;
        private System.Windows.Forms.Button searchTableButton;
        private System.Windows.Forms.Button modifyTableButton;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Button addTableButton;
    }
}