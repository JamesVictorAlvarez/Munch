namespace Munch.TableForms
{
    partial class ModifyTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyTableForm));
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyTableButton = new System.Windows.Forms.Button();
            this.tableIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureMin
            // 
            this.pictureMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMin.Image = global::Munch.Properties.Resources.minimize;
            this.pictureMin.Location = new System.Drawing.Point(730, 12);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(26, 28);
            this.pictureMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMin.TabIndex = 7;
            this.pictureMin.TabStop = false;
            this.pictureMin.Click += new System.EventHandler(this.pictureMin_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(762, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(26, 28);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 6;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.sectionTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.modifyTableButton);
            this.panel1.Location = new System.Drawing.Point(76, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 347);
            this.panel1.TabIndex = 8;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTextBox.Location = new System.Drawing.Point(353, 191);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(46, 23);
            this.capacityTextBox.TabIndex = 10;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTextBox.Location = new System.Drawing.Point(353, 134);
            this.sectionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(46, 23);
            this.sectionTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Section:";
            // 
            // modifyTableButton
            // 
            this.modifyTableButton.BackColor = System.Drawing.Color.White;
            this.modifyTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyTableButton.Location = new System.Drawing.Point(150, 259);
            this.modifyTableButton.Name = "modifyTableButton";
            this.modifyTableButton.Size = new System.Drawing.Size(349, 57);
            this.modifyTableButton.TabIndex = 4;
            this.modifyTableButton.Text = "Modify";
            this.modifyTableButton.UseVisualStyleBackColor = false;
            // 
            // tableIdTextBox
            // 
            this.tableIdTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIdTextBox.Location = new System.Drawing.Point(353, 80);
            this.tableIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.Size = new System.Drawing.Size(46, 23);
            this.tableIdTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Table ID:";
            // 
            // ModifyTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureMin);
            this.Controls.Add(this.pictureClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyTableForm";
            this.Text = "ModifyTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMin;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tableIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyTableButton;
    }
}