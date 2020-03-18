namespace Interactive_Timetable_Map
{
    partial class EditUsersForm
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
            this.userGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.editUsersGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.userGroupBoxUI.SuspendLayout();
            this.editUsersGroupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBoxUI
            // 
            this.userGroupBoxUI.Controls.Add(this.changePasswordButton);
            this.userGroupBoxUI.Controls.Add(this.backButton);
            this.userGroupBoxUI.Controls.Add(this.addUserButton);
            this.userGroupBoxUI.Controls.Add(this.removeUserButton);
            this.userGroupBoxUI.Location = new System.Drawing.Point(281, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 184);
            this.userGroupBoxUI.TabIndex = 3;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(5, 150);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(164, 26);
            this.changePasswordButton.TabIndex = 13;
            this.changePasswordButton.Text = "Change Password";
            this.toolTip.SetToolTip(this.changePasswordButton, "Password Changing Screen For Selected User");
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(6, 19);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(164, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.toolTip.SetToolTip(this.backButton, "Back To Previous Screen");
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(5, 90);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(164, 26);
            this.addUserButton.TabIndex = 10;
            this.addUserButton.Text = "Add User";
            this.toolTip.SetToolTip(this.addUserButton, "Opens A New User Screen");
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Location = new System.Drawing.Point(5, 120);
            this.removeUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(164, 26);
            this.removeUserButton.TabIndex = 11;
            this.removeUserButton.Text = "Remove User";
            this.toolTip.SetToolTip(this.removeUserButton, "Removes Selected User");
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // editUsersGroupBoxUI
            // 
            this.editUsersGroupBoxUI.Controls.Add(this.textBoxGroup);
            this.editUsersGroupBoxUI.Controls.Add(this.labelGroup);
            this.editUsersGroupBoxUI.Controls.Add(this.textBoxUsername);
            this.editUsersGroupBoxUI.Controls.Add(this.labelUsername);
            this.editUsersGroupBoxUI.Controls.Add(this.textBoxLastName);
            this.editUsersGroupBoxUI.Controls.Add(this.textBoxFirstName);
            this.editUsersGroupBoxUI.Controls.Add(this.labelFirstName);
            this.editUsersGroupBoxUI.Controls.Add(this.labelLastName);
            this.editUsersGroupBoxUI.Controls.Add(this.comboBoxID);
            this.editUsersGroupBoxUI.Controls.Add(this.labelID);
            this.editUsersGroupBoxUI.Location = new System.Drawing.Point(12, 12);
            this.editUsersGroupBoxUI.Name = "editUsersGroupBoxUI";
            this.editUsersGroupBoxUI.Size = new System.Drawing.Size(263, 184);
            this.editUsersGroupBoxUI.TabIndex = 2;
            this.editUsersGroupBoxUI.TabStop = false;
            this.editUsersGroupBoxUI.Text = "Edit Users";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(73, 139);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(156, 20);
            this.textBoxGroup.TabIndex = 29;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(24, 139);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(39, 13);
            this.labelGroup.TabIndex = 28;
            this.labelGroup.Text = "Group:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(73, 114);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(156, 20);
            this.textBoxUsername.TabIndex = 27;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(5, 114);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 26;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(73, 90);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(156, 20);
            this.textBoxLastName.TabIndex = 25;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(73, 66);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(156, 20);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(5, 66);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 23;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(5, 90);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 24;
            this.labelLastName.Text = "Last Name:";
            // 
            // comboBoxID
            // 
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(31, 26);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 21;
            this.toolTip.SetToolTip(this.comboBoxID, "Select User By ID");
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(5, 29);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "ID:";
            // 
            // EditUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 207);
            this.Controls.Add(this.userGroupBoxUI);
            this.Controls.Add(this.editUsersGroupBoxUI);
            this.Name = "EditUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUsersForm";
            this.userGroupBoxUI.ResumeLayout(false);
            this.editUsersGroupBoxUI.ResumeLayout(false);
            this.editUsersGroupBoxUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroupBoxUI;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.GroupBox editUsersGroupBoxUI;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ToolTip toolTip;
    }
}