namespace Munch
{
    partial class ModifyTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.modifyTableButton = new System.Windows.Forms.Button();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.modifyTableButton);
            this.panel1.Controls.Add(this.sectionTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(242, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 312);
            this.panel1.TabIndex = 0;
            // 
            // tableIdTextBox
            // 
            this.tableIdTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIdTextBox.Location = new System.Drawing.Point(298, 40);
            this.tableIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.Size = new System.Drawing.Size(46, 23);
            this.tableIdTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Table ID:";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTextBox.Location = new System.Drawing.Point(298, 151);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(46, 23);
            this.capacityTextBox.TabIndex = 17;
            // 
            // modifyTableButton
            // 
            this.modifyTableButton.BackColor = System.Drawing.Color.White;
            this.modifyTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyTableButton.FlatAppearance.BorderSize = 0;
            this.modifyTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyTableButton.Location = new System.Drawing.Point(125, 216);
            this.modifyTableButton.Name = "modifyTableButton";
            this.modifyTableButton.Size = new System.Drawing.Size(219, 57);
            this.modifyTableButton.TabIndex = 13;
            this.modifyTableButton.Text = "Modify";
            this.modifyTableButton.UseVisualStyleBackColor = false;
            this.modifyTableButton.Click += new System.EventHandler(this.modifyTableButton_Click);
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTextBox.Location = new System.Drawing.Point(298, 94);
            this.sectionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(46, 23);
            this.sectionTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Section (1 to 10):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Capacity (1 to 12):";
            // 
            // ModifyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyTable";
            this.Text = "ModifyTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tableIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Button modifyTableButton;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}