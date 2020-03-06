namespace Interactive_Timetable_Map
{
    partial class EditDatabaseForm
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
            this.userGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.removeModuleButton = new System.Windows.Forms.Button();
            this.addModuleButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.editDatabaseGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.labelFriday = new System.Windows.Forms.Label();
            this.textBoxFriday = new System.Windows.Forms.TextBox();
            this.labelThursday = new System.Windows.Forms.Label();
            this.textBoxThursday = new System.Windows.Forms.TextBox();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.textBoxWednesday = new System.Windows.Forms.TextBox();
            this.moduleNameLabel = new System.Windows.Forms.Label();
            this.moduleNameComboBox = new System.Windows.Forms.ComboBox();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.textBoxTuesday = new System.Windows.Forms.TextBox();
            this.textBoxMonday = new System.Windows.Forms.TextBox();
            this.userGroupBoxUI.SuspendLayout();
            this.editDatabaseGroupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBoxUI
            // 
            this.userGroupBoxUI.Controls.Add(this.removeModuleButton);
            this.userGroupBoxUI.Controls.Add(this.addModuleButton);
            this.userGroupBoxUI.Controls.Add(this.backButton);
            this.userGroupBoxUI.Location = new System.Drawing.Point(611, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 237);
            this.userGroupBoxUI.TabIndex = 3;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
            // 
            // removeModuleButton
            // 
            this.removeModuleButton.Location = new System.Drawing.Point(6, 112);
            this.removeModuleButton.Name = "removeModuleButton";
            this.removeModuleButton.Size = new System.Drawing.Size(164, 23);
            this.removeModuleButton.TabIndex = 6;
            this.removeModuleButton.Text = "Remove Module";
            this.removeModuleButton.UseVisualStyleBackColor = true;
            // 
            // addModuleButton
            // 
            this.addModuleButton.Location = new System.Drawing.Point(6, 83);
            this.addModuleButton.Name = "addModuleButton";
            this.addModuleButton.Size = new System.Drawing.Size(164, 23);
            this.addModuleButton.TabIndex = 5;
            this.addModuleButton.Text = "Add Module";
            this.addModuleButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(6, 19);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(164, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // editDatabaseGroupBoxUI
            // 
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelFriday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.textBoxFriday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelThursday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.textBoxThursday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelWednesday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.textBoxWednesday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.moduleNameLabel);
            this.editDatabaseGroupBoxUI.Controls.Add(this.moduleNameComboBox);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelTuesday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelMonday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.textBoxTuesday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.textBoxMonday);
            this.editDatabaseGroupBoxUI.Location = new System.Drawing.Point(12, 12);
            this.editDatabaseGroupBoxUI.Name = "editDatabaseGroupBoxUI";
            this.editDatabaseGroupBoxUI.Size = new System.Drawing.Size(593, 237);
            this.editDatabaseGroupBoxUI.TabIndex = 2;
            this.editDatabaseGroupBoxUI.TabStop = false;
            this.editDatabaseGroupBoxUI.Text = "Edit Database";
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Location = new System.Drawing.Point(21, 136);
            this.labelFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(38, 13);
            this.labelFriday.TabIndex = 45;
            this.labelFriday.Text = "Friday:";
            // 
            // textBoxFriday
            // 
            this.textBoxFriday.Location = new System.Drawing.Point(73, 136);
            this.textBoxFriday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFriday.Name = "textBoxFriday";
            this.textBoxFriday.ReadOnly = true;
            this.textBoxFriday.Size = new System.Drawing.Size(156, 20);
            this.textBoxFriday.TabIndex = 44;
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Location = new System.Drawing.Point(267, 105);
            this.labelThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(54, 13);
            this.labelThursday.TabIndex = 43;
            this.labelThursday.Text = "Thursday:";
            // 
            // textBoxThursday
            // 
            this.textBoxThursday.Location = new System.Drawing.Point(325, 105);
            this.textBoxThursday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxThursday.Name = "textBoxThursday";
            this.textBoxThursday.ReadOnly = true;
            this.textBoxThursday.Size = new System.Drawing.Size(156, 20);
            this.textBoxThursday.TabIndex = 42;
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Location = new System.Drawing.Point(254, 73);
            this.labelWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(67, 13);
            this.labelWednesday.TabIndex = 41;
            this.labelWednesday.Text = "Wednesday:";
            // 
            // textBoxWednesday
            // 
            this.textBoxWednesday.Location = new System.Drawing.Point(325, 73);
            this.textBoxWednesday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWednesday.Name = "textBoxWednesday";
            this.textBoxWednesday.ReadOnly = true;
            this.textBoxWednesday.Size = new System.Drawing.Size(156, 20);
            this.textBoxWednesday.TabIndex = 40;
            // 
            // moduleNameLabel
            // 
            this.moduleNameLabel.AutoSize = true;
            this.moduleNameLabel.Location = new System.Drawing.Point(5, 29);
            this.moduleNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleNameLabel.Name = "moduleNameLabel";
            this.moduleNameLabel.Size = new System.Drawing.Size(76, 13);
            this.moduleNameLabel.TabIndex = 30;
            this.moduleNameLabel.Text = "Module Name:";
            // 
            // moduleNameComboBox
            // 
            this.moduleNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moduleNameComboBox.FormattingEnabled = true;
            this.moduleNameComboBox.Location = new System.Drawing.Point(86, 26);
            this.moduleNameComboBox.Name = "moduleNameComboBox";
            this.moduleNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.moduleNameComboBox.TabIndex = 31;
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Location = new System.Drawing.Point(8, 104);
            this.labelTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(51, 13);
            this.labelTuesday.TabIndex = 34;
            this.labelTuesday.Text = "Tuesday:";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Location = new System.Drawing.Point(11, 73);
            this.labelMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(48, 13);
            this.labelMonday.TabIndex = 33;
            this.labelMonday.Text = "Monday:";
            // 
            // textBoxTuesday
            // 
            this.textBoxTuesday.Location = new System.Drawing.Point(73, 104);
            this.textBoxTuesday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTuesday.Name = "textBoxTuesday";
            this.textBoxTuesday.ReadOnly = true;
            this.textBoxTuesday.Size = new System.Drawing.Size(156, 20);
            this.textBoxTuesday.TabIndex = 35;
            // 
            // textBoxMonday
            // 
            this.textBoxMonday.Location = new System.Drawing.Point(73, 73);
            this.textBoxMonday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMonday.Name = "textBoxMonday";
            this.textBoxMonday.ReadOnly = true;
            this.textBoxMonday.Size = new System.Drawing.Size(156, 20);
            this.textBoxMonday.TabIndex = 32;
            // 
            // EditDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.userGroupBoxUI);
            this.Controls.Add(this.editDatabaseGroupBoxUI);
            this.Name = "EditDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDatabaseForm";
            this.userGroupBoxUI.ResumeLayout(false);
            this.editDatabaseGroupBoxUI.ResumeLayout(false);
            this.editDatabaseGroupBoxUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroupBoxUI;
        private System.Windows.Forms.GroupBox editDatabaseGroupBoxUI;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button removeModuleButton;
        private System.Windows.Forms.Button addModuleButton;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.TextBox textBoxFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.TextBox textBoxThursday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.TextBox textBoxWednesday;
        private System.Windows.Forms.Label moduleNameLabel;
        private System.Windows.Forms.ComboBox moduleNameComboBox;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.TextBox textBoxTuesday;
        private System.Windows.Forms.TextBox textBoxMonday;
    }
}