namespace Munch
{
    partial class ModifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modifyButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showPicture = new System.Windows.Forms.PictureBox();
            this.hidePicture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.userDataGridView);
            this.panel2.Name = "panel2";
            // 
            // userDataGridView
            // 
            resources.ApplyResources(this.userDataGridView, "userDataGridView");
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToResizeColumns = false;
            this.userDataGridView.AllowUserToResizeRows = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.userDataGridView.GridColor = System.Drawing.Color.Gray;
            this.userDataGridView.MultiSelect = false;
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGridView_CellMouseClick_1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.showPicture);
            this.panel1.Controls.Add(this.hidePicture);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.userText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // modifyButton
            // 
            resources.ApplyResources(this.modifyButton, "modifyButton");
            this.modifyButton.BackColor = System.Drawing.Color.White;
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.FlatAppearance.BorderSize = 0;
            this.modifyButton.ForeColor = System.Drawing.Color.Black;
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // passText
            // 
            resources.ApplyResources(this.passText, "passText");
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passText.Name = "passText";
            this.passText.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // userText
            // 
            resources.ApplyResources(this.userText, "userText");
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userText.Name = "userText";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // showPicture
            // 
            resources.ApplyResources(this.showPicture, "showPicture");
            this.showPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPicture.Image = global::Munch.Properties.Resources.unhidden;
            this.showPicture.Name = "showPicture";
            this.showPicture.TabStop = false;
            // 
            // hidePicture
            // 
            resources.ApplyResources(this.hidePicture, "hidePicture");
            this.hidePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePicture.Image = global::Munch.Properties.Resources.hidden;
            this.hidePicture.Name = "hidePicture";
            this.hidePicture.TabStop = false;
            // 
            // ModifyUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyUser";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox showPicture;
        private System.Windows.Forms.PictureBox hidePicture;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}