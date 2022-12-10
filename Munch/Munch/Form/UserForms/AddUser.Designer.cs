namespace Munch
{
    partial class AddUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPicture = new System.Windows.Forms.PictureBox();
            this.hidePicture = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userDbDataSet1 = new Munch.UserDbDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Munch.UserDbDataSet1TableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Munch.UserDbDataSet1TableAdapters.TableAdapterManager();
            this.loginTableAdapter1 = new Munch.UserDbDataSet1TableAdapters.LoginTableAdapter();
            this.loginTableAdapter2 = new Munch.UserDbDataSet1TableAdapters.LoginTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.showPicture);
            this.panel1.Controls.Add(this.hidePicture);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.userText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(299, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 258);
            this.panel1.TabIndex = 0;
            // 
            // showPicture
            // 
            this.showPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPicture.Image = global::Munch.Properties.Resources.unhidden;
            this.showPicture.Location = new System.Drawing.Point(199, 168);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(24, 20);
            this.showPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPicture.TabIndex = 5;
            this.showPicture.TabStop = false;
            this.showPicture.Click += new System.EventHandler(this.showPicture_Click);
            // 
            // hidePicture
            // 
            this.hidePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePicture.Image = global::Munch.Properties.Resources.hidden;
            this.hidePicture.Location = new System.Drawing.Point(199, 168);
            this.hidePicture.Name = "hidePicture";
            this.hidePicture.Size = new System.Drawing.Size(24, 20);
            this.hidePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePicture.TabIndex = 6;
            this.hidePicture.TabStop = false;
            this.hidePicture.Click += new System.EventHandler(this.hidePicture_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(62, 206);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 35);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(38, 168);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(163, 21);
            this.passText.TabIndex = 4;
            this.passText.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // userText
            // 
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.Location = new System.Drawing.Point(38, 108);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(185, 21);
            this.userText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD USER";
            // 
            // userDbDataSet1
            // 
            this.userDbDataSet1.DataSetName = "UserDbDataSet1";
            this.userDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.userDbDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Munch.UserDbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // loginTableAdapter2
            // 
            this.loginTableAdapter2.ClearBeforeFill = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox showPicture;
        private System.Windows.Forms.PictureBox hidePicture;
        private UserDbDataSet1 userDbDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private UserDbDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
        private UserDbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private UserDbDataSet1TableAdapters.LoginTableAdapter loginTableAdapter1;
        private UserDbDataSet1TableAdapters.LoginTableAdapter loginTableAdapter2;
    }
}