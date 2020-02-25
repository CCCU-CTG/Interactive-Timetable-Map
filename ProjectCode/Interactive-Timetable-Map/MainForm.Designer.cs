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
            this.timeTableGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.userGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.testingLoggedInTextBox = new System.Windows.Forms.TextBox();
            this.userGroupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTableGroupBoxUI
            // 
            this.timeTableGroupBoxUI.Location = new System.Drawing.Point(12, 12);
            this.timeTableGroupBoxUI.Name = "timeTableGroupBoxUI";
            this.timeTableGroupBoxUI.Size = new System.Drawing.Size(593, 426);
            this.timeTableGroupBoxUI.TabIndex = 0;
            this.timeTableGroupBoxUI.TabStop = false;
            this.timeTableGroupBoxUI.Text = "Timetable";
            // 
            // userGroupBoxUI
            // 
            this.userGroupBoxUI.Controls.Add(this.testingLoggedInTextBox);
            this.userGroupBoxUI.Controls.Add(this.loginButton);
            this.userGroupBoxUI.Location = new System.Drawing.Point(611, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 426);
            this.userGroupBoxUI.TabIndex = 1;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(7, 20);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(164, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // testingLoggedInTextBox
            // 
            this.testingLoggedInTextBox.Location = new System.Drawing.Point(7, 50);
            this.testingLoggedInTextBox.Name = "testingLoggedInTextBox";
            this.testingLoggedInTextBox.ReadOnly = true;
            this.testingLoggedInTextBox.Size = new System.Drawing.Size(164, 20);
            this.testingLoggedInTextBox.TabIndex = 1;
            this.testingLoggedInTextBox.Text = "TEMP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userGroupBoxUI);
            this.Controls.Add(this.timeTableGroupBoxUI);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.userGroupBoxUI.ResumeLayout(false);
            this.userGroupBoxUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox timeTableGroupBoxUI;
        private System.Windows.Forms.GroupBox userGroupBoxUI;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox testingLoggedInTextBox;
    }
}

