namespace MongoTest
{
    partial class MainForm
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
            this.btGGroup = new System.Windows.Forms.Button();
            this.btRoleTable = new System.Windows.Forms.Button();
            this.btUserTable = new System.Windows.Forms.Button();
            this.btRoleUser = new System.Windows.Forms.Button();
            this.dtDeleteTime = new System.Windows.Forms.DateTimePicker();
            this.btDeleteRow = new System.Windows.Forms.Button();
            this.tbEditRole = new System.Windows.Forms.TextBox();
            this.btReadRole = new System.Windows.Forms.Button();
            this.btEditUser = new System.Windows.Forms.Button();
            this.tbEditUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGGroup
            // 
            this.btGGroup.Location = new System.Drawing.Point(37, 42);
            this.btGGroup.Name = "btGGroup";
            this.btGGroup.Size = new System.Drawing.Size(75, 23);
            this.btGGroup.TabIndex = 0;
            this.btGGroup.Text = "GGroup";
            this.btGGroup.UseVisualStyleBackColor = true;
            this.btGGroup.Click += new System.EventHandler(this.btGGroup_Click);
            // 
            // btRoleTable
            // 
            this.btRoleTable.Location = new System.Drawing.Point(165, 42);
            this.btRoleTable.Name = "btRoleTable";
            this.btRoleTable.Size = new System.Drawing.Size(75, 23);
            this.btRoleTable.TabIndex = 3;
            this.btRoleTable.Text = "RoleTable";
            this.btRoleTable.UseVisualStyleBackColor = true;
            this.btRoleTable.Click += new System.EventHandler(this.btRoleTable_Click);
            // 
            // btUserTable
            // 
            this.btUserTable.Location = new System.Drawing.Point(293, 42);
            this.btUserTable.Name = "btUserTable";
            this.btUserTable.Size = new System.Drawing.Size(75, 23);
            this.btUserTable.TabIndex = 4;
            this.btUserTable.Text = "UserTable";
            this.btUserTable.UseVisualStyleBackColor = true;
            this.btUserTable.Click += new System.EventHandler(this.btUserTable_Click);
            // 
            // btRoleUser
            // 
            this.btRoleUser.Location = new System.Drawing.Point(165, 95);
            this.btRoleUser.Name = "btRoleUser";
            this.btRoleUser.Size = new System.Drawing.Size(75, 23);
            this.btRoleUser.TabIndex = 5;
            this.btRoleUser.Text = "Role.User";
            this.btRoleUser.UseVisualStyleBackColor = true;
            this.btRoleUser.Click += new System.EventHandler(this.btRoleUser_Click);
            // 
            // dtDeleteTime
            // 
            this.dtDeleteTime.Location = new System.Drawing.Point(281, 95);
            this.dtDeleteTime.Name = "dtDeleteTime";
            this.dtDeleteTime.Size = new System.Drawing.Size(87, 21);
            this.dtDeleteTime.TabIndex = 6;
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Location = new System.Drawing.Point(374, 94);
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btDeleteRow.TabIndex = 7;
            this.btDeleteRow.Text = "删除Role";
            this.btDeleteRow.UseVisualStyleBackColor = true;
            this.btDeleteRow.Click += new System.EventHandler(this.btDeleteRow_Click);
            // 
            // tbEditRole
            // 
            this.tbEditRole.Location = new System.Drawing.Point(37, 151);
            this.tbEditRole.Name = "tbEditRole";
            this.tbEditRole.Size = new System.Drawing.Size(100, 21);
            this.tbEditRole.TabIndex = 8;
            // 
            // btReadRole
            // 
            this.btReadRole.Location = new System.Drawing.Point(158, 149);
            this.btReadRole.Name = "btReadRole";
            this.btReadRole.Size = new System.Drawing.Size(75, 23);
            this.btReadRole.TabIndex = 9;
            this.btReadRole.Text = "读取角色";
            this.btReadRole.UseVisualStyleBackColor = true;
            this.btReadRole.Click += new System.EventHandler(this.btReadRole_Click);
            // 
            // btEditUser
            // 
            this.btEditUser.Location = new System.Drawing.Point(374, 147);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(75, 23);
            this.btEditUser.TabIndex = 10;
            this.btEditUser.Text = "保存";
            this.btEditUser.UseVisualStyleBackColor = true;
            this.btEditUser.Click += new System.EventHandler(this.btEditUser_Click);
            // 
            // tbEditUserName
            // 
            this.tbEditUserName.Location = new System.Drawing.Point(251, 149);
            this.tbEditUserName.Name = "tbEditUserName";
            this.tbEditUserName.Size = new System.Drawing.Size(100, 21);
            this.tbEditUserName.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 231);
            this.Controls.Add(this.tbEditUserName);
            this.Controls.Add(this.btEditUser);
            this.Controls.Add(this.btReadRole);
            this.Controls.Add(this.tbEditRole);
            this.Controls.Add(this.btDeleteRow);
            this.Controls.Add(this.dtDeleteTime);
            this.Controls.Add(this.btRoleUser);
            this.Controls.Add(this.btUserTable);
            this.Controls.Add(this.btRoleTable);
            this.Controls.Add(this.btGGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongodb查重工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGGroup;
        private System.Windows.Forms.Button btRoleTable;
        private System.Windows.Forms.Button btUserTable;
        private System.Windows.Forms.Button btRoleUser;
        private System.Windows.Forms.DateTimePicker dtDeleteTime;
        private System.Windows.Forms.Button btDeleteRow;
        private System.Windows.Forms.TextBox tbEditRole;
        private System.Windows.Forms.Button btReadRole;
        private System.Windows.Forms.Button btEditUser;
        private System.Windows.Forms.TextBox tbEditUserName;
    }
}