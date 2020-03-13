namespace Interactive_Timetable_Map
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
			this.addUserButton = new System.Windows.Forms.Button();
			this.editUsersGroupBoxUI = new System.Windows.Forms.GroupBox();
			this.labelGroup = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.labelUsername = new System.Windows.Forms.Label();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
			this.editUsersGroupBoxUI.SuspendLayout();
			this.SuspendLayout();
			// 
			// addUserButton
			// 
			this.addUserButton.Location = new System.Drawing.Point(234, 160);
			this.addUserButton.Margin = new System.Windows.Forms.Padding(2);
			this.addUserButton.Name = "addUserButton";
			this.addUserButton.Size = new System.Drawing.Size(164, 26);
			this.addUserButton.TabIndex = 11;
			this.addUserButton.Text = "Add User";
			this.addUserButton.UseVisualStyleBackColor = true;
			this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
			// 
			// editUsersGroupBoxUI
			// 
			this.editUsersGroupBoxUI.Controls.Add(this.checkBoxAdmin);
			this.editUsersGroupBoxUI.Controls.Add(this.label2);
			this.editUsersGroupBoxUI.Controls.Add(this.comboBoxGroup);
			this.editUsersGroupBoxUI.Controls.Add(this.textBoxPassword);
			this.editUsersGroupBoxUI.Controls.Add(this.label1);
			this.editUsersGroupBoxUI.Controls.Add(this.labelGroup);
			this.editUsersGroupBoxUI.Controls.Add(this.textBoxUsername);
			this.editUsersGroupBoxUI.Controls.Add(this.labelUsername);
			this.editUsersGroupBoxUI.Controls.Add(this.textBoxLastName);
			this.editUsersGroupBoxUI.Controls.Add(this.textBoxFirstName);
			this.editUsersGroupBoxUI.Controls.Add(this.labelFirstName);
			this.editUsersGroupBoxUI.Controls.Add(this.labelLastName);
			this.editUsersGroupBoxUI.Location = new System.Drawing.Point(12, 12);
			this.editUsersGroupBoxUI.Name = "editUsersGroupBoxUI";
			this.editUsersGroupBoxUI.Size = new System.Drawing.Size(593, 143);
			this.editUsersGroupBoxUI.TabIndex = 12;
			this.editUsersGroupBoxUI.TabStop = false;
			this.editUsersGroupBoxUI.Text = "Add Users";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(304, 67);
			this.labelGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(39, 13);
			this.labelGroup.TabIndex = 28;
			this.labelGroup.Text = "Group:";
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(353, 33);
			this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(156, 20);
			this.textBoxUsername.TabIndex = 27;
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Location = new System.Drawing.Point(285, 33);
			this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(58, 13);
			this.labelUsername.TabIndex = 26;
			this.labelUsername.Text = "Username:";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(77, 67);
			this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(156, 20);
			this.textBoxLastName.TabIndex = 25;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(77, 33);
			this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(156, 20);
			this.textBoxFirstName.TabIndex = 22;
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(9, 33);
			this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(60, 13);
			this.labelFirstName.TabIndex = 23;
			this.labelFirstName.Text = "First Name:";
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(9, 67);
			this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(61, 13);
			this.labelLastName.TabIndex = 24;
			this.labelLastName.Text = "Last Name:";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(77, 100);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(156, 20);
			this.textBoxPassword.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 100);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "Password:";
			// 
			// comboBoxGroup
			// 
			this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Location = new System.Drawing.Point(353, 64);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(156, 21);
			this.comboBoxGroup.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(293, 100);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Is Admin:";
			// 
			// checkBoxAdmin
			// 
			this.checkBoxAdmin.AutoSize = true;
			this.checkBoxAdmin.Location = new System.Drawing.Point(353, 100);
			this.checkBoxAdmin.Name = "checkBoxAdmin";
			this.checkBoxAdmin.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAdmin.TabIndex = 34;
			this.checkBoxAdmin.UseVisualStyleBackColor = true;
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 213);
			this.Controls.Add(this.editUsersGroupBoxUI);
			this.Controls.Add(this.addUserButton);
			this.Name = "AddUser";
			this.Text = "AddUser";
			this.editUsersGroupBoxUI.ResumeLayout(false);
			this.editUsersGroupBoxUI.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addUserButton;
		private System.Windows.Forms.GroupBox editUsersGroupBoxUI;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.ComboBox comboBoxGroup;
		private System.Windows.Forms.CheckBox checkBoxAdmin;
		private System.Windows.Forms.Label label2;
	}
}