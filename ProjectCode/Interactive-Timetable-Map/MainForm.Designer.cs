namespace Interactive_Timetable_Map
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
            this.components = new System.ComponentModel.Container();
            this.timeTableGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.timetableDataGrid = new System.Windows.Forms.DataGridView();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.editUsersButton = new System.Windows.Forms.Button();
            this.editDatabaseButton = new System.Windows.Forms.Button();
            this.testingLoggedInTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timeTableGroupBoxUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGrid)).BeginInit();
            this.userGroupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTableGroupBoxUI
            // 
            this.timeTableGroupBoxUI.Controls.Add(this.timetableDataGrid);
            this.timeTableGroupBoxUI.Location = new System.Drawing.Point(12, 12);
            this.timeTableGroupBoxUI.Name = "timeTableGroupBoxUI";
            this.timeTableGroupBoxUI.Size = new System.Drawing.Size(593, 273);
            this.timeTableGroupBoxUI.TabIndex = 0;
            this.timeTableGroupBoxUI.TabStop = false;
            this.timeTableGroupBoxUI.Text = "Timetable";
            // 
            // timetableDataGrid
            // 
            this.timetableDataGrid.AllowUserToDeleteRows = false;
            this.timetableDataGrid.AllowUserToResizeColumns = false;
            this.timetableDataGrid.AllowUserToResizeRows = false;
            this.timetableDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetableDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.timetableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday});
            this.timetableDataGrid.Location = new System.Drawing.Point(6, 19);
            this.timetableDataGrid.Name = "timetableDataGrid";
            this.timetableDataGrid.ReadOnly = true;
            this.timetableDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.timetableDataGrid.Size = new System.Drawing.Size(581, 243);
            this.timetableDataGrid.TabIndex = 3;
            this.timetableDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timetableDataGrid_CellMouseClick);
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Monday";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userGroupBoxUI
            // 
            this.userGroupBoxUI.Controls.Add(this.helpButton);
            this.userGroupBoxUI.Controls.Add(this.logoutButton);
            this.userGroupBoxUI.Controls.Add(this.editUsersButton);
            this.userGroupBoxUI.Controls.Add(this.editDatabaseButton);
            this.userGroupBoxUI.Controls.Add(this.testingLoggedInTextBox);
            this.userGroupBoxUI.Controls.Add(this.loginButton);
            this.userGroupBoxUI.Location = new System.Drawing.Point(611, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 281);
            this.userGroupBoxUI.TabIndex = 1;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(6, 191);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(163, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.toolTip.SetToolTip(this.helpButton, "Opens the Help Screen");
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(6, 49);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(164, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.toolTip.SetToolTip(this.logoutButton, "Logs User Out");
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // editUsersButton
            // 
            this.editUsersButton.Location = new System.Drawing.Point(5, 249);
            this.editUsersButton.Name = "editUsersButton";
            this.editUsersButton.Size = new System.Drawing.Size(164, 23);
            this.editUsersButton.TabIndex = 3;
            this.editUsersButton.Text = "Edit Users";
            this.toolTip.SetToolTip(this.editUsersButton, "User Database Editor");
            this.editUsersButton.UseVisualStyleBackColor = true;
            this.editUsersButton.Click += new System.EventHandler(this.EditUsersButton_Click);
            // 
            // editDatabaseButton
            // 
            this.editDatabaseButton.Location = new System.Drawing.Point(5, 220);
            this.editDatabaseButton.Name = "editDatabaseButton";
            this.editDatabaseButton.Size = new System.Drawing.Size(164, 23);
            this.editDatabaseButton.TabIndex = 2;
            this.editDatabaseButton.Text = "Edit Database";
            this.toolTip.SetToolTip(this.editDatabaseButton, "Module Database Editor");
            this.editDatabaseButton.UseVisualStyleBackColor = true;
            this.editDatabaseButton.Click += new System.EventHandler(this.EditDatabaseButton_Click);
            // 
            // testingLoggedInTextBox
            // 
            this.testingLoggedInTextBox.Location = new System.Drawing.Point(7, 78);
            this.testingLoggedInTextBox.Name = "testingLoggedInTextBox";
            this.testingLoggedInTextBox.ReadOnly = true;
            this.testingLoggedInTextBox.Size = new System.Drawing.Size(164, 20);
            this.testingLoggedInTextBox.TabIndex = 1;
            this.testingLoggedInTextBox.Text = "TEMP";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(7, 20);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(164, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.toolTip.SetToolTip(this.loginButton, "Show Login Screen");
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.userGroupBoxUI);
            this.Controls.Add(this.timeTableGroupBoxUI);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.timeTableGroupBoxUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGrid)).EndInit();
            this.userGroupBoxUI.ResumeLayout(false);
            this.userGroupBoxUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox timeTableGroupBoxUI;
        private System.Windows.Forms.GroupBox userGroupBoxUI;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox testingLoggedInTextBox;
        private System.Windows.Forms.DataGridView timetableDataGrid;
        private System.Windows.Forms.Button editUsersButton;
        private System.Windows.Forms.Button editDatabaseButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

