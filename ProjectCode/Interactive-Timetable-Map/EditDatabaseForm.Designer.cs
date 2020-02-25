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
            this.databaseGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.userGroupBoxUI.SuspendLayout();
            this.databaseGroupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBoxUI
            // 
            this.userGroupBoxUI.Controls.Add(this.button2);
            this.userGroupBoxUI.Controls.Add(this.button1);
            this.userGroupBoxUI.Controls.Add(this.backButton);
            this.userGroupBoxUI.Location = new System.Drawing.Point(611, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 237);
            this.userGroupBoxUI.TabIndex = 3;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
            // 
            // databaseGroupBoxUI
            // 
            this.databaseGroupBoxUI.Controls.Add(this.label5);
            this.databaseGroupBoxUI.Controls.Add(this.textBox5);
            this.databaseGroupBoxUI.Controls.Add(this.label4);
            this.databaseGroupBoxUI.Controls.Add(this.textBox4);
            this.databaseGroupBoxUI.Controls.Add(this.label3);
            this.databaseGroupBoxUI.Controls.Add(this.textBox3);
            this.databaseGroupBoxUI.Controls.Add(this.labelID);
            this.databaseGroupBoxUI.Controls.Add(this.comboBoxID);
            this.databaseGroupBoxUI.Controls.Add(this.labelLastName);
            this.databaseGroupBoxUI.Controls.Add(this.labelFirstName);
            this.databaseGroupBoxUI.Controls.Add(this.textBoxLastName);
            this.databaseGroupBoxUI.Controls.Add(this.textBoxFirstName);
            this.databaseGroupBoxUI.Location = new System.Drawing.Point(12, 12);
            this.databaseGroupBoxUI.Name = "databaseGroupBoxUI";
            this.databaseGroupBoxUI.Size = new System.Drawing.Size(593, 237);
            this.databaseGroupBoxUI.TabIndex = 2;
            this.databaseGroupBoxUI.TabStop = false;
            this.databaseGroupBoxUI.Text = "Edit Database";
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
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(73, 104);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(156, 20);
            this.textBoxLastName.TabIndex = 35;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(73, 73);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(156, 20);
            this.textBoxFirstName.TabIndex = 32;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 73);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(48, 13);
            this.labelFirstName.TabIndex = 33;
            this.labelFirstName.Text = "Monday:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(8, 104);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(51, 13);
            this.labelLastName.TabIndex = 34;
            this.labelLastName.Text = "Tuesday:";
            // 
            // comboBoxID
            // 
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(86, 26);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 31;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(5, 29);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(76, 13);
            this.labelID.TabIndex = 30;
            this.labelID.Text = "Module Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Module";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove Module";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Wednesday:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(325, 73);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Thursday:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(325, 105);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Friday:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 136);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 44;
            // 
            // EditDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.userGroupBoxUI);
            this.Controls.Add(this.databaseGroupBoxUI);
            this.Name = "EditDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDatabaseForm";
            this.userGroupBoxUI.ResumeLayout(false);
            this.databaseGroupBoxUI.ResumeLayout(false);
            this.databaseGroupBoxUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroupBoxUI;
        private System.Windows.Forms.GroupBox databaseGroupBoxUI;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
    }
}