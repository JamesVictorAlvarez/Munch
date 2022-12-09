namespace Munch.TableForms
{
    partial class AddTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTableForm));
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTableButton = new System.Windows.Forms.Button();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
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
            this.pictureMin.TabIndex = 5;
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
            this.pictureClose.TabIndex = 4;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.sectionTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addTableButton);
            this.panel1.Location = new System.Drawing.Point(76, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 347);
            this.panel1.TabIndex = 6;
            // 
            // addTableButton
            // 
            this.addTableButton.BackColor = System.Drawing.Color.White;
            this.addTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTableButton.Location = new System.Drawing.Point(150, 259);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(349, 57);
            this.addTableButton.TabIndex = 4;
            this.addTableButton.Text = "Add";
            this.addTableButton.UseVisualStyleBackColor = false;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTextBox.Location = new System.Drawing.Point(346, 169);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(46, 23);
            this.capacityTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Section:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(231, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacity:";
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTextBox.Location = new System.Drawing.Point(346, 112);
            this.sectionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(46, 23);
            this.sectionTextBox.TabIndex = 9;
            // 
            // AddTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureMin);
            this.Controls.Add(this.pictureClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTableForm";
            this.Text = "AddTableForm";
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
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}