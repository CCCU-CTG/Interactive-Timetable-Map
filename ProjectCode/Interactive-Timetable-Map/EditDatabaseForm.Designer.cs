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
            this.buttonTimeSlot = new System.Windows.Forms.Button();
            this.groupBoxSelected = new System.Windows.Forms.GroupBox();
            this.textBoxTimeSlot = new System.Windows.Forms.TextBox();
            this.removeModuleButton = new System.Windows.Forms.Button();
            this.addModuleButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.editDatabaseGroupBoxUI = new System.Windows.Forms.GroupBox();
            this.comboBoxFri = new System.Windows.Forms.ComboBox();
            this.comboBoxThurs = new System.Windows.Forms.ComboBox();
            this.comboBoxWeds = new System.Windows.Forms.ComboBox();
            this.comboBoxTues = new System.Windows.Forms.ComboBox();
            this.comboBoxMon = new System.Windows.Forms.ComboBox();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.moduleNameLabel = new System.Windows.Forms.Label();
            this.moduleNameComboBox = new System.Windows.Forms.ComboBox();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.userGroupBoxUI.SuspendLayout();
            this.groupBoxSelected.SuspendLayout();
            this.editDatabaseGroupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBoxUI
            // 
            this.userGroupBoxUI.Controls.Add(this.buttonTimeSlot);
            this.userGroupBoxUI.Controls.Add(this.groupBoxSelected);
            this.userGroupBoxUI.Controls.Add(this.removeModuleButton);
            this.userGroupBoxUI.Controls.Add(this.addModuleButton);
            this.userGroupBoxUI.Controls.Add(this.backButton);
            this.userGroupBoxUI.Location = new System.Drawing.Point(276, 12);
            this.userGroupBoxUI.Name = "userGroupBoxUI";
            this.userGroupBoxUI.Size = new System.Drawing.Size(177, 237);
            this.userGroupBoxUI.TabIndex = 3;
            this.userGroupBoxUI.TabStop = false;
            this.userGroupBoxUI.Text = "User";
            // 
            // buttonTimeSlot
            // 
            this.buttonTimeSlot.Location = new System.Drawing.Point(5, 129);
            this.buttonTimeSlot.Name = "buttonTimeSlot";
            this.buttonTimeSlot.Size = new System.Drawing.Size(164, 23);
            this.buttonTimeSlot.TabIndex = 10;
            this.buttonTimeSlot.Text = "Change Selected Time Slot";
            this.buttonTimeSlot.UseVisualStyleBackColor = true;
            this.buttonTimeSlot.Click += new System.EventHandler(this.buttonTimeSlot_Click);
            // 
            // groupBoxSelected
            // 
            this.groupBoxSelected.Controls.Add(this.textBoxTimeSlot);
            this.groupBoxSelected.Location = new System.Drawing.Point(0, 160);
            this.groupBoxSelected.Name = "groupBoxSelected";
            this.groupBoxSelected.Size = new System.Drawing.Size(177, 77);
            this.groupBoxSelected.TabIndex = 9;
            this.groupBoxSelected.TabStop = false;
            this.groupBoxSelected.Text = "Selected Time Slot";
            // 
            // textBoxTimeSlot
            // 
            this.textBoxTimeSlot.Location = new System.Drawing.Point(6, 19);
            this.textBoxTimeSlot.Multiline = true;
            this.textBoxTimeSlot.Name = "textBoxTimeSlot";
            this.textBoxTimeSlot.ReadOnly = true;
            this.textBoxTimeSlot.Size = new System.Drawing.Size(163, 52);
            this.textBoxTimeSlot.TabIndex = 0;
            // 
            // removeModuleButton
            // 
            this.removeModuleButton.Location = new System.Drawing.Point(5, 99);
            this.removeModuleButton.Name = "removeModuleButton";
            this.removeModuleButton.Size = new System.Drawing.Size(164, 23);
            this.removeModuleButton.TabIndex = 6;
            this.removeModuleButton.Text = "Remove Module";
            this.removeModuleButton.UseVisualStyleBackColor = true;
            this.removeModuleButton.Click += new System.EventHandler(this.removeModuleButton_Click);
            // 
            // addModuleButton
            // 
            this.addModuleButton.Location = new System.Drawing.Point(5, 70);
            this.addModuleButton.Name = "addModuleButton";
            this.addModuleButton.Size = new System.Drawing.Size(164, 23);
            this.addModuleButton.TabIndex = 5;
            this.addModuleButton.Text = "Add Module";
            this.addModuleButton.UseVisualStyleBackColor = true;
            this.addModuleButton.Click += new System.EventHandler(this.addModuleButton_Click);
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
            this.editDatabaseGroupBoxUI.Controls.Add(this.comboBoxFri);
            this.editDatabaseGroupBoxUI.Controls.Add(this.comboBoxThurs);
            this.editDatabaseGroupBoxUI.Controls.Add(this.comboBoxWeds);
            this.editDatabaseGroupBoxUI.Controls.Add(this.comboBoxTues);
            this.editDatabaseGroupBoxUI.Controls.Add(this.comboBoxMon);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelFriday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelThursday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelWednesday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.moduleNameLabel);
            this.editDatabaseGroupBoxUI.Controls.Add(this.moduleNameComboBox);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelTuesday);
            this.editDatabaseGroupBoxUI.Controls.Add(this.labelMonday);
            this.editDatabaseGroupBoxUI.Location = new System.Drawing.Point(12, 12);
            this.editDatabaseGroupBoxUI.Name = "editDatabaseGroupBoxUI";
            this.editDatabaseGroupBoxUI.Size = new System.Drawing.Size(258, 237);
            this.editDatabaseGroupBoxUI.TabIndex = 2;
            this.editDatabaseGroupBoxUI.TabStop = false;
            this.editDatabaseGroupBoxUI.Text = "Edit Database";
            // 
            // comboBoxFri
            // 
            this.comboBoxFri.FormattingEnabled = true;
            this.comboBoxFri.Location = new System.Drawing.Point(74, 182);
            this.comboBoxFri.Name = "comboBoxFri";
            this.comboBoxFri.Size = new System.Drawing.Size(156, 21);
            this.comboBoxFri.TabIndex = 50;
            this.comboBoxFri.SelectedIndexChanged += new System.EventHandler(this.comboBoxFri_SelectedIndexChanged);
            // 
            // comboBoxThurs
            // 
            this.comboBoxThurs.FormattingEnabled = true;
            this.comboBoxThurs.Location = new System.Drawing.Point(74, 155);
            this.comboBoxThurs.Name = "comboBoxThurs";
            this.comboBoxThurs.Size = new System.Drawing.Size(156, 21);
            this.comboBoxThurs.TabIndex = 49;
            this.comboBoxThurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxThurs_SelectedIndexChanged);
            // 
            // comboBoxWeds
            // 
            this.comboBoxWeds.FormattingEnabled = true;
            this.comboBoxWeds.Location = new System.Drawing.Point(74, 128);
            this.comboBoxWeds.Name = "comboBoxWeds";
            this.comboBoxWeds.Size = new System.Drawing.Size(156, 21);
            this.comboBoxWeds.TabIndex = 48;
            this.comboBoxWeds.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeds_SelectedIndexChanged);
            // 
            // comboBoxTues
            // 
            this.comboBoxTues.FormattingEnabled = true;
            this.comboBoxTues.Location = new System.Drawing.Point(74, 101);
            this.comboBoxTues.Name = "comboBoxTues";
            this.comboBoxTues.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTues.TabIndex = 47;
            this.comboBoxTues.SelectedIndexChanged += new System.EventHandler(this.comboBoxTues_SelectedIndexChanged);
            // 
            // comboBoxMon
            // 
            this.comboBoxMon.FormattingEnabled = true;
            this.comboBoxMon.Location = new System.Drawing.Point(74, 72);
            this.comboBoxMon.Name = "comboBoxMon";
            this.comboBoxMon.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMon.TabIndex = 46;
            this.comboBoxMon.SelectedIndexChanged += new System.EventHandler(this.comboBoxMon_SelectedIndexChanged);
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Location = new System.Drawing.Point(31, 184);
            this.labelFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(38, 13);
            this.labelFriday.TabIndex = 45;
            this.labelFriday.Text = "Friday:";
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Location = new System.Drawing.Point(15, 158);
            this.labelThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(54, 13);
            this.labelThursday.TabIndex = 43;
            this.labelThursday.Text = "Thursday:";
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Location = new System.Drawing.Point(2, 136);
            this.labelWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(67, 13);
            this.labelWednesday.TabIndex = 41;
            this.labelWednesday.Text = "Wednesday:";
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
            this.moduleNameComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleNameComboBox_SelectedIndexChanged);
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Location = new System.Drawing.Point(18, 109);
            this.labelTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(51, 13);
            this.labelTuesday.TabIndex = 34;
            this.labelTuesday.Text = "Tuesday:";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Location = new System.Drawing.Point(21, 80);
            this.labelMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(48, 13);
            this.labelMonday.TabIndex = 33;
            this.labelMonday.Text = "Monday:";
            // 
            // EditDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 255);
            this.Controls.Add(this.userGroupBoxUI);
            this.Controls.Add(this.editDatabaseGroupBoxUI);
            this.Name = "EditDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDatabaseForm";
            this.userGroupBoxUI.ResumeLayout(false);
            this.groupBoxSelected.ResumeLayout(false);
            this.groupBoxSelected.PerformLayout();
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
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label moduleNameLabel;
        private System.Windows.Forms.ComboBox moduleNameComboBox;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.ComboBox comboBoxFri;
        private System.Windows.Forms.ComboBox comboBoxThurs;
        private System.Windows.Forms.ComboBox comboBoxWeds;
        private System.Windows.Forms.ComboBox comboBoxTues;
        private System.Windows.Forms.ComboBox comboBoxMon;
        private System.Windows.Forms.Button buttonTimeSlot;
        private System.Windows.Forms.GroupBox groupBoxSelected;
        private System.Windows.Forms.TextBox textBoxTimeSlot;
    }
}