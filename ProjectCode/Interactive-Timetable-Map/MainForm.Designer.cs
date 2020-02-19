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
            this.userGroupBoxUI.Location = new System.Drawing.Point(611, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 426);
            this.userGroupBoxUI.TabIndex = 1;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox timeTableGroupBoxUI;
        private System.Windows.Forms.GroupBox userGroupBoxUI;
    }
}

