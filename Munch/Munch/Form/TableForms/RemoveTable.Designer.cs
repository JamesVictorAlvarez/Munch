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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableIdTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.removeTableButton);
            this.panel1.Name = "panel1";
            // 
            // tableIdTextBox
            // 
            resources.ApplyResources(this.tableIdTextBox, "tableIdTextBox");
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.TextChanged += new System.EventHandler(this.tableIdTextBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // removeTableButton
            // 
            resources.ApplyResources(this.removeTableButton, "removeTableButton");
            this.removeTableButton.BackColor = System.Drawing.Color.White;
            this.removeTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTableButton.FlatAppearance.BorderSize = 0;
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.UseVisualStyleBackColor = false;
            this.removeTableButton.Click += new System.EventHandler(this.removeTableButton_Click);
            // 
            // RemoveTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveTable";
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