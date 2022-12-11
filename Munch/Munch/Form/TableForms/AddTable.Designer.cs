namespace Munch
{
    partial class AddTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTableButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.sectionTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addTableButton);
            this.panel1.Name = "panel1";
            // 
            // capacityTextBox
            // 
            resources.ApplyResources(this.capacityTextBox, "capacityTextBox");
            this.capacityTextBox.Name = "capacityTextBox";
            // 
            // sectionTextBox
            // 
            resources.ApplyResources(this.sectionTextBox, "sectionTextBox");
            this.sectionTextBox.Name = "sectionTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // addTableButton
            // 
            resources.ApplyResources(this.addTableButton, "addTableButton");
            this.addTableButton.BackColor = System.Drawing.Color.White;
            this.addTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTableButton.FlatAppearance.BorderSize = 0;
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.UseVisualStyleBackColor = false;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // AddTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTableButton;
    }
}