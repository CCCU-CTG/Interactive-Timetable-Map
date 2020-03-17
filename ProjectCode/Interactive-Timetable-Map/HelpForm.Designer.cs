namespace Interactive_Timetable_Map
{
    partial class HelpForm
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
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.helpIndexTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // helpTextBox
            // 
            this.helpTextBox.Location = new System.Drawing.Point(13, 13);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.Size = new System.Drawing.Size(676, 103);
            this.helpTextBox.TabIndex = 0;
            this.helpTextBox.TabStop = false;
            this.helpTextBox.Text = "\r\n";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(696, 39);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(92, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.toolTip.SetToolTip(this.nextButton, "Show Next Help Text");
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(696, 68);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(92, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.toolTip.SetToolTip(this.previousButton, "Show Previous Help Text");
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // helpIndexTextBox
            // 
            this.helpIndexTextBox.Location = new System.Drawing.Point(696, 13);
            this.helpIndexTextBox.Name = "helpIndexTextBox";
            this.helpIndexTextBox.ReadOnly = true;
            this.helpIndexTextBox.Size = new System.Drawing.Size(92, 20);
            this.helpIndexTextBox.TabIndex = 3;
            this.toolTip.SetToolTip(this.helpIndexTextBox, "Help Index");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 130);
            this.Controls.Add(this.helpIndexTextBox);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.helpTextBox);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox helpTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox helpIndexTextBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}