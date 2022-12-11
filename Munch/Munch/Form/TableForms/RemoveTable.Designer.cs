namespace Munch
{
    partial class RemoveTable
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
            this.tableIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableIdTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.removeTableButton);
            this.panel1.Location = new System.Drawing.Point(253, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 290);
            this.panel1.TabIndex = 0;
            // 
            // tableIdTextBox
            // 
            this.tableIdTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIdTextBox.Location = new System.Drawing.Point(235, 89);
            this.tableIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.Size = new System.Drawing.Size(46, 23);
            this.tableIdTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Table ID:";
            // 
            // removeTableButton
            // 
            this.removeTableButton.BackColor = System.Drawing.Color.White;
            this.removeTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTableButton.FlatAppearance.BorderSize = 0;
            this.removeTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTableButton.Location = new System.Drawing.Point(87, 144);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(225, 57);
            this.removeTableButton.TabIndex = 10;
            this.removeTableButton.Text = "Remove";
            this.removeTableButton.UseVisualStyleBackColor = false;
            this.removeTableButton.Click += new System.EventHandler(this.removeTableButton_Click);
            // 
            // RemoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveTable";
            this.Text = "RemoveTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tableIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeTableButton;
    }
}