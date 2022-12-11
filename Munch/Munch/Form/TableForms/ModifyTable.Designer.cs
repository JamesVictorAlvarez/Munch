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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyTable));
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.modifyTableButton);
            this.panel1.Controls.Add(this.sectionTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Name = "panel1";
            // 
            // tableIdTextBox
            // 
            resources.ApplyResources(this.tableIdTextBox, "tableIdTextBox");
            this.tableIdTextBox.Name = "tableIdTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // capacityTextBox
            // 
            resources.ApplyResources(this.capacityTextBox, "capacityTextBox");
            this.capacityTextBox.Name = "capacityTextBox";
            // 
            // modifyTableButton
            // 
            resources.ApplyResources(this.modifyTableButton, "modifyTableButton");
            this.modifyTableButton.BackColor = System.Drawing.Color.White;
            this.modifyTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyTableButton.FlatAppearance.BorderSize = 0;
            this.modifyTableButton.Name = "modifyTableButton";
            this.modifyTableButton.UseVisualStyleBackColor = false;
            this.modifyTableButton.Click += new System.EventHandler(this.modifyTableButton_Click);
            // 
            // sectionTextBox
            // 
            resources.ApplyResources(this.sectionTextBox, "sectionTextBox");
            this.sectionTextBox.Name = "sectionTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // ModifyTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyTable";
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