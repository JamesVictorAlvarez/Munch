namespace Munch
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.userButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(815, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(26, 28);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pictureClose.MouseHover += new System.EventHandler(this.pictureClose_MouseHover);
            // 
            // pictureMin
            // 
            this.pictureMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMin.Image = global::Munch.Properties.Resources.minimize;
            this.pictureMin.Location = new System.Drawing.Point(783, 12);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(26, 28);
            this.pictureMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMin.TabIndex = 2;
            this.pictureMin.TabStop = false;
            this.pictureMin.Click += new System.EventHandler(this.pictureMin_Click);
            this.pictureMin.MouseHover += new System.EventHandler(this.pictureMin_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tableButton);
            this.panel1.Controls.Add(this.settingButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.reserveButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Location = new System.Drawing.Point(104, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 347);
            this.panel1.TabIndex = 3;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.White;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(126, 238);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(123, 57);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Add User";
            this.userButton.UseVisualStyleBackColor = false;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.White;
            this.reserveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.Location = new System.Drawing.Point(126, 144);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(123, 57);
            this.reserveButton.TabIndex = 1;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = false;
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.White;
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.Location = new System.Drawing.Point(126, 56);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(123, 57);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = false;
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.White;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.Location = new System.Drawing.Point(316, 144);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(123, 57);
            this.settingButton.TabIndex = 3;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = false;
            // 
            // tableButton
            // 
            this.tableButton.BackColor = System.Drawing.Color.White;
            this.tableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableButton.Location = new System.Drawing.Point(316, 56);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(123, 57);
            this.tableButton.TabIndex = 4;
            this.tableButton.Text = "Tables";
            this.tableButton.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureMin);
            this.Controls.Add(this.pictureClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button reserveButton;
    }
}